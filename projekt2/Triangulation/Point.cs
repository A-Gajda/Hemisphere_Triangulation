using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace projekt2.Triangulation
{
    class Point : Object
    {
        private int x;
        private int y;
        private int z;

        public Point(int xx = 0, int yy = 0, int zz = 0)
        {
            x = xx;
            y = yy;
            z = zz;
        }

        public Point(Point p)
        {
            x = p.X;
            y = p.Y;
            z = p.Z;
        }

        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y;
            set => y = value;
        }

        public int Z
        {
            get => z;
            set => z = value;
        }

        public bool IsItMe(int x, int y)
        {
            return ((x - this.x) * (x - this.x) + (y - this.y) * (y - this.y) <= 25);
        }

        public bool IsItMeMore(int x, int y)
        {
            return (x == this.X && y == this.Y);
        }

        public void Draw(Graphics e)
        {
            Brush brush = new SolidBrush(Color.Black);
            e.FillEllipse(brush, this.X - 2, this.y - 2, 5, 5);
        }

        public static Point operator * (double a, Point b)
        {
            return new Point((int)(a * b.X), (int)(a * b.Y), (int)(a * b.Z));
        }

        public static Point operator - (Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
    }
}
