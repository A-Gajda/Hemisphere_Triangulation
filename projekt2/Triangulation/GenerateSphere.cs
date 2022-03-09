using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2.Triangulation
{
    static class GenerateSphere
    {
        public static Point[,] GeneratePoints(int density, int r, Point S)
        {
            Point[,] points = new Point[density + 1, 2 * density + 1];
            for (int tita = 0; tita <= density; tita++)
            {
                double vtita = (double)tita * (Math.PI / (double)density / 2);
                for (int nphi = -density; nphi <= density; nphi++)
                {
                    double vphi = (double)nphi * (Math.PI / (double)density);
                    points[tita, nphi + density] = new Point((int)(r * Math.Sin(vtita) * Math.Cos(vphi)) + S.X,
                        (int)(r * Math.Sin(vtita) * Math.Sin(vphi)) + S.Y, (int)(r * Math.Cos(vtita)) + S.Z);
                }
            }
            return points;
        }

        public static List<Triangle> GenerateTriangulation(Point[,] points)
        {
            List<Triangle> triangles = new List<Triangle>();
            for (int i = 1; i <= points.GetLongLength(0) - 1; i++)
            {
                for (int j = 0; j <= points.GetLongLength(1) - 2; j++)
                {
                    triangles.Add(new Triangle(points[i, j], points[i, j + 1], points[i - 1, j]));
                    triangles.Add(new Triangle(points[i, j + 1], points[i - 1, j + 1], points[i - 1, j]));
                }
            }
            return triangles;
        }
    }
}
