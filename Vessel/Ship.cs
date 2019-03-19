using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vessel
{
    public class Ship
    {
        public void Crew()
        {

        }
        public int Capacity(int hold)
        {
            return hold;
        }
        public int Crates(int x)
        {
            return x;
        }

        public double WarpEquation(int warp)
        {
            double x = 10 / 3.0;
            double y = -11 / 3.0;
            warp = 5;
            double z = 10 - warp;
            double velocity = (Math.Pow(warp, x)) + (Math.Pow(z, y));
            Console.WriteLine($"Warp spped is {velocity}");
            return velocity;
        }

    }
}
