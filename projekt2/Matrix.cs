using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2.Triangulation
{
    class Matrix
    {
        public Vector[] vectors;

        public Matrix(Vector p0, Vector p1, Vector p2)
        {
            vectors = new Vector[3];
            vectors[0] = p0;
            vectors[1] = p1;
            vectors[2] = p2;
        }

        public static Vector operator *(Matrix m, Vector p)
        {
            return new Vector(m.vectors[0].X * p.X + m.vectors[1].X * p.Y + m.vectors[2].X * p.Z,
                m.vectors[0].Y * p.Z + m.vectors[1].Y * p.Y + m.vectors[2].Y * p.Z,
                m.vectors[0].Z * p.X + m.vectors[1].Z * p.Y + m.vectors[2].Z * p.Z);
        }

        public static Matrix operator *(double a, Matrix m)
        {
            return new Matrix(a * m.vectors[0], a * m.vectors[1], a * m.vectors[2]);
        }
    }
}
