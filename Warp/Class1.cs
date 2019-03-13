using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warp
{
    public class WarpSpeed
    {
        public double WarpEquation(double warp)
        {
            double x = 10 / 3.0;
            double y = -11 / 3.0;
            warp = 5;
            double z = 10 - warp;
            double v = (Math.Pow(warp, x)) + (Math.Pow(z, y));
            Console.WriteLine($"Warp spped is {v}");
            return v;
        }
    }

    public class Travel
    {

    }
}
