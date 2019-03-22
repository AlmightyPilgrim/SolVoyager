using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class MiningColony
    {
        Market colonyMarket = new Market();
        MiningColonyResources showResources = new MiningColonyResources();
        public void colonyDisplay()
        {
            bool check = true;
            Console.WriteLine("Welcome to the Mining Colony.");
            Console.WriteLine("Do you wish to buy and sell [1], or view the market [2]?");
            string answer = Console.ReadLine();
            while (check == true)
            {
                if (answer == "1")
                {
                    colonyMarket.MarketDisplay("Colony");
                }
                else if (answer == "2")
                {
                    showResources.ColonyMetals();
                    showResources.ColonyFabric();
                    showResources.ColonyGemstone();
                    showResources.ColonySupply();
                }
                else
                {
                    Console.WriteLine("Invalid Input, try again");
                }

                Console.WriteLine("Do you wish to buy or sell now [1], or leave planet [2]?");
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

        public double ColonyLocation()
        {
            double location = 7.65;
            return location;
        }
    }
}
