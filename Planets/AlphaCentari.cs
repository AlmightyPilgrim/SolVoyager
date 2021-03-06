﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vessel;

namespace Planets
{
    public class AlphaCentari
    {
        Market centariMarket = new Market();
        AlphaCentariResources showResources = new AlphaCentariResources();
        public void alphaDisplay(Ship playerShip)
        {
            bool check = true;
            Console.WriteLine("Welcome to Alpha Centari.");
            Console.WriteLine("Do you wish to buy and sell [1], or view the market [2]?");
            string answer = Console.ReadLine();
            while (check == true)
            {
                if (answer == "1")
                {
                    centariMarket.MarketDisplay("Alpha", playerShip);
                }
                else if (answer == "2")
                {
                    showResources.CentariMetals();
                    showResources.CentariFabric();
                    showResources.CentariGemstone();
                    showResources.CentariSupply();
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

        public double AlphaLocation()
        {
            double location = 4.3;
            return location;
        }
    }
}
