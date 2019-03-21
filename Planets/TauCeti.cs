using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class TauCeti
    {
        Market tauMarket = new Market();
        TauCetiResources showResources = new TauCetiResources();
        public void tauDisplay()
        {
            bool check = true;
            Console.WriteLine("Welcome to Tau Ceti.");
            Console.WriteLine("Do you wish to buy and sell [1], or view the market [2]?");
            string answer = Console.ReadLine();
            while (check == true)
            {
                if (answer == "1")
                {
                    tauMarket.MarketDisplay("Tau Ceti");
                }
                else if (answer == "2")
                {
                    showResources.TauMetals();
                    showResources.TauFabric();
                    showResources.TauGemstone();
                    showResources.TauSupply();
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

        public double TauCetiLocation()
        {
            double location = 11.89;
            return location;
        }
    }
}
