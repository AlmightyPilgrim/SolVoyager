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
        public int Capacity(int input)  // tracking number of crates, and limiting amount allowed
        {
            int hold = metalCapacity(1) + fabricCapacity(1) + gemCapacity(1) + supplyCapacity(1);
            hold -= input;
            if (hold > 20)
            {
                Console.WriteLine("Overburdened, ditching crates till at max capacity of 20");
                while (hold > 20)
                {
                    hold--;
                }
            }
            crateTrack.Crates(hold);
            return hold;
        }

        public int metalCapacity(int input) //keep track of different materials crates
        {
            Console.WriteLine("Which type of Metal: \n1 - Platinium\n2 - Palladium\n3 - Titanium");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{platCrate(0)} crates of platinium");
                    break;
                case "2":
                    Console.WriteLine($"{palladCrate(0)} crates of palladium");
                    break;
                case "3":
                    Console.WriteLine($"{titanCrate(0)} crates of titanium");
                    break;
                default:
                    Console.WriteLine("Invaild Input");
                    break;
            }
            input = platCrate(0) + palladCrate(0) + titanCrate(0);
            return input;
        }

        public int platCrate(int input)
        {
            int store = 0;
            store += input;
            return store;
        }

        public int palladCrate(int input)
        {
            int store = 0;
            store += input;
            return store;
        }

        public int titanCrate(int input)
        {
            int store = 0;
            store += input;
            return store;
        }

        public int fabricCapacity(int input)
        {
            Console.WriteLine("Which type of Metal: \n1 - Platinium\n2 - Palladium\n3 - Titanium");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($" crates of platinium");
                    break;
                case "2":
                    Console.WriteLine($" crates of palladium");
                    break;
                case "3":
                    Console.WriteLine($" crates of titanium");
                    break;
                default:
                    Console.WriteLine("Invaild Input");
                    break;
            }
            input = 0;
            return input;
        }

        public int silkCrate()
        {
            return 1;
        }

        public int cottonCrate()
        {
            return 1;
        }

        public int linenCrate()
        {
            return 1;
        }

        public int gemCapacity(int input)
        {
            Console.WriteLine("Which type of Metal: \n1 - Platinium\n2 - Palladium\n3 - Titanium");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($" crates of platinium");
                    break;
                case "2":
                    Console.WriteLine($" crates of palladium");
                    break;
                case "3":
                    Console.WriteLine($" crates of titanium");
                    break;
                default:
                    Console.WriteLine("Invaild Input");
                    break;
            }
            input = 0;
            return input;
        }

        public int diaCrate()
        {
            return 1;
        }
        public int rubyCrate()
        {
            return 1;
        }
        public int sappCrate()
        {
            return 1;
        }

        public int supplyCapacity(int input)
        {
            Console.WriteLine("Which type of Metal: \n1 - Platinium\n2 - Palladium\n3 - Titanium");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($" crates of platinium");
                    break;
                case "2":
                    Console.WriteLine($" crates of palladium");
                    break;
                case "3":
                    Console.WriteLine($" crates of titanium");
                    break;
                default:
                    Console.WriteLine("Invaild Input");
                    break;
            }
            input = 0;
            return input;
        }

        public int foodCrate()
        {
            return 1;
        }
        public int waterCrate()
        {
            return 1;
        }
        public int alcoCrate()
        {
            return 1;
        }
        public int mediCrate()
        {
            return 1;
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
