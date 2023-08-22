using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal static class GeometryHelper
    {
        //----------------
        public static int Quadrilateral(int width, int length)
        {
            if (width < 0 || length < 0) return 0;
            return width * length;
        }
        //----------------
        public static int Triangular(int bottomSet, int height)
        {
            if (bottomSet < 0 || height < 0) return 0;
            return (bottomSet * height) / 2;
        }
        //----------------
        public static double Circle(double radius)
        {
            if (radius < 0) return 0;
            double pi = Math.PI;
            return radius * radius * pi;
        }

    }
}
