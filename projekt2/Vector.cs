using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class Vector
    {
        private double x;
        private double y;
        private double z;

        public Vector(double xx = 0, double yy = 0, double zz = 0)
        {
            x = xx;
            y = yy;
            z = zz;
        }

        public Vector(Vector p)
        {
            x = p.X;
            y = p.Y;
            z = p.Z;
        }

        public double X
        {
            get => x;
            set => x = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }

        public double Z
        {
            get => z;
            set => z = value;
        }

        public void Normalize()
        {
            double length = this.X * this.X + this.Y * this.Y + this.Z * this.Z;
            length = Math.Sqrt(length);
            if (length == 0) return;
            this.X = this.X / length;
            this.Y = this.Y / length;
            this.Z = this.Z / length;
        }

        public static Vector operator *(double a, Vector b)
        {
            return new Vector(a * b.X, a * b.Y, a * b.Z);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static double operator *(Vector a, Vector b) //iloczyn skalarny wektorów
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        public static Vector operator ^(Vector a, Vector b) //iloczyn wektorowy wektorów
        {
            return new Vector(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X - b.Z, a.X * b.Y - a.Y * b.X);
        }
    }
}
