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
        public static int Area(int width, int length)
        {
            if (width < 0 || length < 0) return 0;
            return width * length;
        }
        //----------------
        public static int Area(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0) return 0;
            return (a + b + c) / 2;
        }
        //----------------
        public static double Area(double radius)
        {
            if (radius < 0) return 0;
            double pi = Math.PI;
            return radius * radius * pi;
        }

    }
}
