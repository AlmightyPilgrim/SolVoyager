using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Mars
    {
        Market marsMarket = new Market();
        MarsResources showResources = new MarsResources();
        public void marsDisplay()
        {
            bool check = true;
            Console.WriteLine("Welcome to Mars.");
            Console.WriteLine("Do you wish to view the market [1], or buy and sell [2]?");
            string answer = Console.ReadLine();
            while (check == true)
            {
                if (answer == "1")
                {
                    marsMarket.MarketDisplay("Mars");
                }
                else if (answer == "2")
                {
                    showResources.MarsMetals();
                    showResources.MarsFabric();
                    showResources.MarsGemstone();
                    showResources.MarsSupply();
                }
                else
                {
                    Console.WriteLine("Invalid Input, try again");
                }

                Console.WriteLine("Do you wish to view market now [1], or leave planet [2]?");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                }
                else
                {
                    Console.WriteLine("Leaving Planet now.");
                    check = false;
                }
            }
            Console.Clear();
        }

        public double EarthLocation()
        {

            return 1;
        }
    }
}
