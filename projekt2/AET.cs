using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekt2.Triangulation;
using Point = projekt2.Triangulation.Point;

namespace projekt2
{
    class AET
    {
        public Point first;
        public Point second;
        public double x;
        public double w;

        public AET(Point first, Point second, double x, double w)
        {
            this.first = first;
            this.second = second;
            this.x = x;
            this.w = w;
        }
    }
}
