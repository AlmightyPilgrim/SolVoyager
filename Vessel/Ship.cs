using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources;
using Currency;

namespace Vessel
{
    public class Ship
    {
        Creds crateTrack = new Creds();

        public void Crew()
        {

        }
        public int Capacity(int x)
        {
            int hold = 0;
            hold += x;
            if (hold > 20)
            {
                Console.WriteLine("Overburdened, dicking crates till at max capacity of 20");
                while (hold > 20)
                {
                    hold--;
                }
            }
            crateTrack.Crates(hold);
            return hold;
        }

        public double WarpEquation(int warp)
        {
            double x = 10 / 3.0;
            double y = -11 / 3.0;
            warp = 5;
            double z = 10 - warp;
            double velocity = (Math.Pow(warp, x)) + (Math.Pow(z, y));
            Console.WriteLine($"Warp speed is {velocity}");
            return velocity;
        }

    }
}
