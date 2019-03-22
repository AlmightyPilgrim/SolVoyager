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
        // int platstore = 0;
        int palladstore = 0;
        int titanstore = 0;
        int silkstore = 0;
        int cottonstore = 0;
        int linenstore = 0;
        int diamstore = 0;
        int rubystore = 0;
        int sappstore = 0;
        int foodstore = 0;
        int waterstore = 0;
        int alcostore = 0;
        int medistore = 0;
        // double wallet = 10000;

        public int Capacity(int input)  // tracking number of crates, and limiting amount allowed
        {
            int hold = metalCapacity(1) + fabricCapacity(1) + gemCapacity(1) + supplyCapacity(1);
            hold -= input;
            if (hold > 100)
            {
                Console.WriteLine("Overburdened, ditching crates till at max capacity of 20");
                while (hold > 100)
                {
                    hold -= 1;
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
            int platstore = 0 + input;
            return platstore;
        }

        public int palladCrate(int input)
        {
            palladstore += input;
            int testvalue = palladstore + input;
            return testvalue;
        }

        public int titanCrate(int input)
        {
            titanstore += input;
            return titanstore;
        }

        public int fabricCapacity(int input)
        {
            Console.WriteLine("Which type of Metal: \n1 - Silk\n2 - Cotton\n3 - Linen");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{silkCrate(0)} crates of silk");
                    break;
                case "2":
                    Console.WriteLine($"{cottonCrate(0)} crates of cotton");
                    break;
                case "3":
                    Console.WriteLine($"{linenCrate(0)} crates of linen");
                    break;
                default:
                    Console.WriteLine("Invaild Input");
                    break;
            }
            input = 0;
            return input;
        }

        public int silkCrate(int input)
        {
            silkstore += input;
            return silkstore;
        }

        public int cottonCrate(int input)
        {
            cottonstore += input;
            return cottonstore;
        }

        public int linenCrate(int input)
        {
            linenstore += input;
            return linenstore;
        }

        public int gemCapacity(int input)
        {
            Console.WriteLine("Which type of Metal: \n1 - Diamond\n2 - Ruby\n3 - Sapphire");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{diaCrate(0)} crates of diamond");
                    break;
                case "2":
                    Console.WriteLine($"{rubyCrate(0)} crates of ruby");
                    break;
                case "3":
                    Console.WriteLine($"{sappCrate(0)} crates of sapphire");
                    break;
                default:
                    Console.WriteLine("Invaild Input");
                    break;
            }
            input = 0;
            return input;
        }

        public int diaCrate(int input)
        {
            diamstore += input;
            return diamstore;
        }
        public int rubyCrate(int input)
        {
            rubystore += input;
            return rubystore;
        }
        public int sappCrate(int input)
        {
            sappstore += input;
            return sappstore;
        }

        public int supplyCapacity(int input)
        {
            Console.WriteLine("Which type of Metal: \n1 - Food\n2 - Water\n3 - Alcohol\n4 - Medicine");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{foodCrate(0)} crates of food");
                    break;
                case "2":
                    Console.WriteLine($"{waterCrate(0)} crates of water");
                    break;
                case "3":
                    Console.WriteLine($"{alcoCrate(0)} crates of alcohol");
                    break;
                case "4":
                    Console.WriteLine($"{mediCrate(0)} crates of medicine");
                    break;
                default:
                    Console.WriteLine("Invaild Input");
                    break;
            }
            input = 0;
            return input;
        }

        public int foodCrate(int input)
        {
            foodstore += input;
            return foodstore;
        }
        public int waterCrate(int input)
        {
            waterstore += input;
            return waterstore;
        }
        public int alcoCrate(int input)
        {
            alcostore += input;
            return alcostore;
        }
        public int mediCrate(int input)
        {
            medistore += input;
            return medistore;
        }

        // the players wallet
        public double playerWallet(double input)
        {
            double wallet = 0 + input;
            wallet = Math.Round(wallet, 2);
            if (wallet < 0)
            {
                Console.Clear();
                Console.WriteLine("You have overspent");
            }
            return wallet;
        }

        public double WarpEquation()
        {
            double x = 10 / 3.0;
            double y = -11 / 3.0;
            int warp = 5;
            double z = 10 - warp;
            double velocity = (Math.Pow(warp, x)) + (Math.Pow(z, y));
            // distance / velocity gives age
            return velocity;
        }
    }
}
