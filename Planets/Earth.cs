using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources;

namespace Planets
{
    public class Earth
    {
        Market earthMarket = new Market();
        EarthResources showResources = new EarthResources();
        public void earthDisplay()
        {
            bool check = true;
            Console.WriteLine("Welcome to Earth.");
            Console.WriteLine("Do you wish to view the market [1], or buy and sell [2]?");
            string answer = Console.ReadLine();
            while (check == true)
            {
                if (answer == "1")
                {
                    earthMarket.MarketDisplay("Earth");
                }
                else if (answer == "2")
                {
                    showResources.EarthMetals();
                    showResources.EarthFabric();
                    showResources.EarthGemstone();
                    showResources.EarthSupply();
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

    }
}
