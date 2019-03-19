using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources;

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
        public int PlatCrates(int x)
        {

            return x;
        }

        public int PalladCrates(int x)
        {

            return x;
        }

        public int TitanCrates(int x)
        {

            return x;
        }

        public double SilkCrates(int x)
        {
            return x;
        }

        public double CottonCrates(int x)
        {
            return x;
        }

        public double LinenCrates(int x)
        {
            return x;
        }

        public int DiamondCrates(int x)
        {
            return x;
        }

        public int RubyCrates(int x)
        {
            return x;
        }

        public int SapphireCrates(int x)
        {
            return x;
        }

        public double FoodCrates(int x)
        {
            return x;
        }

        public double WaterCrates(int x)
        {
            return x;
        }

        public double AlcoholCrates(int x)
        {
            return x;
        }

        public double MedicineCrates(int x)
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
            Console.WriteLine($"Warp speed is {velocity}");
            return velocity;
        }

    }
}
