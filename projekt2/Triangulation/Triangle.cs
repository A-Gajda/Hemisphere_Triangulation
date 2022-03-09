using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace projekt2.Triangulation
{
    class Triangle : IPolygon
    {
        public Point[] points;

        public Triangle(Point p0, Point p1, Point p2)
        {
            points = new Point[3];
            points[0] = p0;
            points[1] = p1;
            points[2] = p2;
        }

        public Point[] Points()
        {
            return points;
        }

        public void Draw(Graphics e)
        {
            Pen pen = new Pen(Color.Black);
            for (int i = 0; i < points.Length; i++)
            {
                e.DrawLine(pen, new System.Drawing.Point(points[i].X, points[i].Y),
                    new System.Drawing.Point(points[(i + 1) % points.Length].X, points[(i + 1) % points.Length].Y));
            }
        }
    }
}
