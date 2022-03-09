using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projekt2.Triangulation;
using Point = projekt2.Triangulation.Point;

namespace projekt2
{
    public partial class Form1 : Form
    {
        Point movingPoint = null;
        double timerAngle = 0;

        public Form1()
        {
            InitializeComponent();
            Values.radius = Math.Min(canva.Width, canva.Height) / 2 - 20;
            Values.S = new Point(canva.Width / 2, canva.Height / 2);
            Values.density = dokladnoscTriangulacjiTrackBar.Value;
            Values.lightSource = new Point(Values.S.X, Values.S.Y, lightSourceZTrackBar.Value);
            Values.changedLightSource = new Point(Values.lightSource);
            Values.textureBitmap = new Bitmap(new Bitmap(@"..\..\..\..\textures\colorfuldrops_matching.jpg"), canva.Width, canva.Height);
            Values.normalBitmap = new Bitmap(new Bitmap(@"..\..\..\..\textures\colorfuldrops_normalmap_matching.jpg"), canva.Width, canva.Height);
            Values.textureColor = new Color[canva.Width, canva.Height];
            Values.allSpherePoints = new Point[canva.Width, canva.Height];
            Values.normalVectors = new Vector[canva.Width, canva.Height];
            for (int x = 1; x < canva.Width; x++)
                for (int y = 1; y < canva.Height; y++)
                {
                    Values.textureColor[x, y] = Values.textureBitmap.GetPixel(x, y);
                    Values.allSpherePoints[x, y] = new Point(x, y, (int)Math.Max(0, Math.Sqrt(Values.radius * Values.radius
                        - (Values.S.X - x) * (Values.S.X - x) - (Values.S.Y - y) * (Values.S.Y - y))));
                    Values.normalVectors[x, y] = SetVectorN(Values.allSpherePoints[x, y]);
                }
            dokladnoscTriangulacjiLabel.Text = dokladnoscTriangulacjiTrackBar.Value.ToString();
            Values.points = GenerateSphere.GeneratePoints(Values.density, Values.radius, Values.S);
            Values.triangles = GenerateSphere.GenerateTriangulation(Values.points);
            Values.m = mTrackBar.Value;
            Values.kd = (double)kdTrackBar.Value / 100;
            Values.ks = (double)ksTrackBar.Value / 100;
            Values.k = (double)kTrackBar.Value / 100;
            mLabel.Text = mTrackBar.Value.ToString();
            kdLabel.Text = ((double)kdTrackBar.Value / 100).ToString();
            ksLabel.Text = ((double)ksTrackBar.Value / 100).ToString();
            kLabel.Text = Values.k.ToString();
            lightSourceZLabel.Text = lightSourceZTrackBar.Value.ToString();
        }

        private void canva_Paint(object sender, PaintEventArgs e)
        {
            var dbm = new DirectBitmap(canva.Width, canva.Height);
            var g = Graphics.FromImage(dbm.Bitmap);
            foreach (Point p in Values.points)
            {
                dbm.SetPixel(p.X, p.Y, FillPointPrecisely(p.X, p.Y));
            }
            foreach (Triangle t in Values.triangles)
            {
                FillPolygon(t, dbm);
            }
            foreach (Triangle t in Values.triangles)
            {
                if (pokazLinieCheck.Checked) t.Draw(g);
            }
            foreach (Point p in Values.points)
            {
                if (pokazLinieCheck.Checked) p.Draw(g);
            }
            //g.FillEllipse(new SolidBrush(Values.lightColor), Values.lightSource.X - 5, Values.lightSource.Y - 5, 10, 10);
            e.Graphics.DrawImage(dbm.Bitmap, 0, 0);
        }

        private void FillPolygon(IPolygon polygon, DirectBitmap dbm)
        {
            int[] sorted = SortPolygon(polygon);
            Point[] points = polygon.Points();
            int ymin = points[sorted[0]].Y;
            int ymax = points[sorted[sorted.Length - 1]].Y;
            int idx = 0;
            var AET = new List<AET>();
            Color A = dbm.GetPixel(points[0].X, points[0].Y);
            Color B = dbm.GetPixel(points[1].X, points[1].Y);
            Color C = dbm.GetPixel(points[2].X, points[2].Y);
            for (int y = ymin; y <= ymax; y++)
            {
                while (idx < sorted.Length && points[sorted[idx]].Y == y)
                {
                    Point p = points[sorted[idx]];
                    Point prev = points[(sorted[idx] - 1 + points.Length) % points.Length];
                    Point next = points[(sorted[idx] + 1) % points.Length];
                    if (prev.Y > p.Y) AET.Add(new projekt2.AET(p, prev, (double)p.X,
                           (prev.Y == p.Y) ? 0 : (double)(prev.X - p.X) / (double)(prev.Y - p.Y)));
                    else
                    {
                        foreach (projekt2.AET aet in AET)
                        {
                            if ((aet.first == prev && aet.second == p) || (aet.first == p && aet.second == prev))
                            {
                                AET.Remove(aet);
                                break;
                            }
                        }
                    }
                    if (next.Y > p.Y) AET.Add(new projekt2.AET(p, next, (double)p.X,
                           (next.Y == p.Y) ? 0 : (double)(next.X - p.X) / (double)(next.Y - p.Y)));
                    else
                    {
                        foreach (projekt2.AET aet in AET)
                        {
                            if ((aet.first == next && aet.second == p) || (aet.first == p && aet.second == next))
                            {
                                AET.Remove(aet);
                                break;
                            }
                        }
                    }
                    idx++;
                }
                AET.Sort(new AETComparator());
                for (int i = 0; i < AET.Count / 2; i++)
                {
                    for (int x = (int)Math.Floor(AET[2 * i].x); x <= (int)Math.Ceiling(AET[2 * i + 1].x); x++)
                    {
                        if (kolorDokladnyRadioButton.Checked) dbm.SetPixel(x, y, FillPointPrecisely(x, y));
                        if (kolorInterpolacjaRadioButton.Checked && !points[0].IsItMeMore(x, y) && !points[1].IsItMeMore(x, y)
                            && !points[2].IsItMeMore(x, y)) dbm.SetPixel(x, y, InterpolateColor(x, y, (Triangle)polygon, A, B, C));
                    }
                    AET[2 * i].x += AET[2 * i].w;
                    AET[2 * i + 1].x += AET[2 * i + 1].w;
                }
            }
            Values.lightSource = new Point(Values.changedLightSource);
        }

        private int[] SortPolygon(IPolygon polygon)
        {
            Point[] points = polygon.Points();
            int[] sorted = new int[points.Length];
            for (int i = 0; i < sorted.Length; i++) sorted[i] = i;
            Array.Sort(points, sorted, new PolygonComparator());
            return sorted;
        }

        private class PolygonComparator : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                if (x.GetType().Equals(typeof(Point)) && y.GetType().Equals(typeof(Point)))
                {
                    if (((Point)x).Y < ((Point)y).Y) return -1;
                    if (((Point)x).Y > ((Point)y).Y) return 1;
                    return 0;
                }
                return 0;
            }
        }

        private class AETComparator : IComparer<AET>
        {
            int IComparer<AET>.Compare(AET x, AET y)
            {
                if (x.x < y.x) return -1;
                if (x.x > y.x) return 1;
                return 0;
            }
        }

        private Color FillPointPrecisely(int x, int y)
        {
            Color c = Color.White;
            if (wypelnijKoloremRadioButton.Checked || (wypelnijTeksturaRadioButton.Checked && Values.textureBitmap == null))
            {
                c = Values.color;
            }
            if (wypelnijTeksturaRadioButton.Checked && Values.textureBitmap != null)
            {
                c = Values.textureColor[x, y];
            }
            double IR = (double)c.R / 255;
            double IG = (double)c.G / 255;
            double IB = (double)c.B / 255;
            double R, G, B;
            Point p = Values.allSpherePoints[x, y];
            Vector N = Values.normalVectors[x, y];
            Vector L = new Vector(Values.lightSource.X - p.X, Values.lightSource.Y - p.Y, Values.lightSource.Z - p.Z);
            L.Normalize();
            double cos1 = N * L;
            Vector Rv = 2 * cos1 * N - L;
            Rv.Normalize();
            double cos2 = (new Vector(0, 0, 1)) * Rv;
            cos1 = Math.Max(0, cos1);
            cos2 = Math.Max(0, cos2);
            double cosm = Math.Pow(cos2, Values.m);
            double final = Values.kd * cos1 + Values.ks * cosm;
            R = (double)Values.lightColor.R / 255 * IR * final;
            G = (double)Values.lightColor.G / 255 * IG * final;
            B = (double)Values.lightColor.B / 255 * IB * final;
            int r = (int)(Math.Min(R, 1) * 255);
            int g = (int)(Math.Min(G, 1) * 255);
            int b = (int)(Math.Min(B, 1) * 255);
            if (Double.IsNaN(cos2))
            {
                r = 255;
                g = 255;
                b = 255;
            }
            return Color.FromArgb(r, g, b);
        }

        private Color InterpolateColor(int x, int y, Triangle t, Color aC, Color bC, Color cC)
        {
            Point[] points = t.Points();
            Point a = points[0];
            Point b = points[1];
            Point c = points[2];
            double area = (b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - a.X);
            if (area == 0) return Color.Black;
            double alpha = (double)((b.X - x) * (c.Y - y) - (b.Y - y) * (c.X - x)) / area;
            double beta = (double)((x - a.X) * (c.Y - a.Y) - (y - a.Y) * (c.X - a.X)) / area;
            double gamma = 1 - alpha - beta;
            double R = aC.R * alpha + bC.R * beta + cC.R * gamma;
            double G = aC.G * alpha + bC.G * beta + cC.G * gamma;
            double B = aC.B * alpha + bC.B * beta + cC.B * gamma;
            R = Math.Max(0, R);
            R = Math.Min(255, R);   
            G = Math.Max(0, G); G = Math.Min(255, G);
            B = Math.Max(0, B); B = Math.Min(255, B);
            return Color.FromArgb((int)Math.Ceiling(R), (int)Math.Ceiling(G), (int)Math.Ceiling(B));
        }

        private Vector SetVectorN(Point p)
        {
            Vector Nk = new Vector(p.X - Values.S.X, p.Y - Values.S.Y, p.Z - Values.S.Z);
            Nk.Normalize();
            if (!wektoryNormalneCheckBox.Checked || (wektoryNormalneCheckBox.Checked && Values.normalBitmap == null))
                return Nk;
            Color normalColor = Values.normalBitmap.GetPixel(p.X, p.Y);
            Vector Nt = new Vector(((double)normalColor.R - 127) / 128, ((double)normalColor.G - 127) / 128, 
                ((double)normalColor.B - 127) / 128);
            Nt.Normalize();
            Vector B = Nk ^ (new Vector(0, 0, 1));
            if (Nk.X == 0 && Nk.Y == 0 && Nk.Z == 1) B = new Vector(0, 1, 0);
            B.Normalize();
            Vector T = B ^ Nk;
            T.Normalize();
            Matrix M = new Matrix(T, B, Nk);
            Vector N = Values.k * Nk + (1 - Values.k) * M * Nt;
            N.Normalize();
            return N;
        }

        private void canva_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (Point p in Values.points)
            {
                if (p.IsItMe(e.X, e.Y))
                {
                    movingPoint = p;
                    return;
                }
            }
        }

        private void canva_MouseClick(object sender, MouseEventArgs e)
        {
            if (movingPoint != null)
            {
                movingPoint = null;
            }
        }

        private void canva_MouseMove(object sender, MouseEventArgs e)
        {
            if (movingPoint != null)
            {
                movingPoint.X = e.X;
                movingPoint.Y = e.Y;
                canva.Refresh();
            }
        }

        private void dokladnoscTriangulacjiTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Values.density = dokladnoscTriangulacjiTrackBar.Value;
            dokladnoscTriangulacjiLabel.Text = dokladnoscTriangulacjiTrackBar.Value.ToString();
            Values.points = GenerateSphere.GeneratePoints(Values.density, Math.Min(canva.Width, canva.Height) / 2 - 20,
                new Point(canva.Width / 2, canva.Height / 2));
            Values.triangles = GenerateSphere.GenerateTriangulation(Values.points);
            canva.Refresh();
            canva.Refresh();
        }

        private void pokazLinieCheck_CheckedChanged(object sender, EventArgs e)
        {
            canva.Refresh();
        }

        private void mTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Values.m = mTrackBar.Value;
            mLabel.Text = mTrackBar.Value.ToString();
            canva.Refresh();
        }

        private void kdTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Values.kd = (double)kdTrackBar.Value / 100;
            kdLabel.Text = ((double)kdTrackBar.Value / 100).ToString();
            canva.Refresh();
        }

        private void ksTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Values.ks = (double)ksTrackBar.Value / 100;
            ksLabel.Text = ((double)ksTrackBar.Value / 100).ToString();
            canva.Refresh();
        }

        private void wypelnijKoloremRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            wybierzKolorButton.Enabled = wypelnijKoloremRadioButton.Checked;
            canva.Refresh();
        }

        private void wybierzKolorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Values.color = colorDialog.Color;
                canva.Refresh();
            }
        }

        private void wypelnijTeksturaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            wybierzTekstureButton.Enabled = wypelnijTeksturaRadioButton.Checked;
            canva.Refresh();
        }

        private void wybierzTekstureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Values.textureBitmap = new Bitmap(new Bitmap(fileDialog.FileName), canva.Width, canva.Height);
                for (int x = 1; x < canva.Width; x++)
                    for (int y = 1; y < canva.Height; y++)
                        Values.textureColor[x, y] = Values.textureBitmap.GetPixel(x, y);
                canva.Refresh();
            }
        }

        private void wektoryNormalneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            for (int x = 1; x < canva.Width; x++)
                for (int y = 1; y < canva.Height; y++)
                    Values.normalVectors[x, y] = SetVectorN(Values.allSpherePoints[x, y]);
            wybierzMapeButton.Enabled = wektoryNormalneCheckBox.Checked;
            kTrackBar.Enabled = wektoryNormalneCheckBox.Checked;
            canva.Refresh();
        }

        private void wybierzMapeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Values.normalBitmap = new Bitmap(new Bitmap(fileDialog.FileName), canva.Width, canva.Height);
                for (int x = 1; x < canva.Width; x++)
                    for (int y = 1; y < canva.Height; y++)
                        Values.normalVectors[x, y] = SetVectorN(Values.allSpherePoints[x, y]);
                canva.Refresh();
            }
        }

        private void lightSourceZTrackBar_ValueChanged(object sender, EventArgs e)
        {
            lightSourceZLabel.Text = lightSourceZTrackBar.Value.ToString();
            //Values.lightSource.Z = lightSourceZTrackBar.Value;
            Values.changedLightSource = new Point(Values.lightSource.X, Values.lightSource.Y, lightSourceZTrackBar.Value);
            canva.Refresh();
            canva.Refresh();
        }

        private void startstopButton_Click(object sender, EventArgs e)
        {
            Values.lightSourceMove = !Values.lightSourceMove;
            if (Values.lightSourceMove)
            {
                timer.Start();
                startstopButton.Text = "Zatrzymaj ruch";
            }
            else
            {
                timer.Stop();
                startstopButton.Text = "Rozpocznij ruch";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Values.changedLightSource = new Point(Values.S.X, Values.S.Y, lightSourceZTrackBar.Value);
            timerAngle = 0;
            canva.Refresh();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timerAngle += (double)(5 * Math.PI / 180);
            double r = 150 * timerAngle;
            Values.changedLightSource.X = (int)(r * Math.Cos(timerAngle)) + Values.S.X;
            Values.changedLightSource.Y = (int)(r * Math.Sin(timerAngle)) + Values.S.Y;
            if (r > Values.radius + 3000)
            {
                startstopButton_Click(sender, e);
                resetButton_Click(sender, e);
            }
            canva.Refresh();
        }

        private void wybierzKolorSwiatlaButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Values.lightColor = colorDialog.Color;
                canva.Refresh();
            }
        }

        private void kTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Values.k = (double)kTrackBar.Value / 100;
            kLabel.Text = Values.k.ToString();
            for (int x = 1; x < canva.Width; x++)
                for (int y = 1; y < canva.Height; y++)
                    Values.normalVectors[x, y] = SetVectorN(Values.allSpherePoints[x, y]);
            canva.Refresh();
        }

        private void kolorInterpolacjaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            canva.Refresh();
        }

        private void kolorDokladnyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            canva.Refresh();
        }
    }
}
