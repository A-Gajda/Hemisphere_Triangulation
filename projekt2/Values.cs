using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekt2.Triangulation;
using System.Drawing;
using Point = projekt2.Triangulation.Point;
using System.IO;

namespace projekt2
{
    static class Values
    {
        public static int density;
        public static Point[,] points;
        public static List<Triangle> triangles;
        public static int radius;
        public static Point S;
        public static int m;
        public static double kd;
        public static double ks;
        public static Color color = Color.Blue;
        public static Bitmap textureBitmap;
        public static Bitmap normalBitmap;
        public static Point lightSource;
        public static bool lightSourceMove = false;
        public static Color lightColor = Color.White;
        public static Point changedLightSource;
        public static double k;
        public static Color[,] textureColor;
        public static Point[,] allSpherePoints;
        public static Vector[,] normalVectors;
    }
}

