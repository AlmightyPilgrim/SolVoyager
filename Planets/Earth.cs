using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources;
using Vessel;

namespace Planets
{ // Earth is the baseline class for each of the planets, as everything that happens in it, will be takn and applied to other planet classes.
    public class Earth
    {
        Market earthMarket = new Market();
        EarthResources showResources = new EarthResources();
        Ship locationHelp = new Ship();

        public void earthDisplay()
        {
            bool check = true;
            Console.WriteLine("Welcome to Earth.");
            Console.WriteLine("Do you wish to buy and sell [1], or view the market [2]?");
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

        public double EarthLocation()
        {
            double location = 0;
            return location;
        }
    }
}
