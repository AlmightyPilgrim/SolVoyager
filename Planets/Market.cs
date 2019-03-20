using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources;
using Vessel;

namespace Planets
{
    class Market
    {
        Metal metalPrice = new Metal();
        Fabric fabricPrice = new Fabric();
        Gemstones gemstonePrice = new Gemstones();
        Supplies supplyPrice = new Supplies();
        Ship vesselHold = new Ship();

        public void MarketDisplay()
        {
            Console.WriteLine("Which resource would you like to view? \n1 - Metals\t 2 - Fabrics\n3 - Gemstone\t 4 - Supplies");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": //Metal selection buy/sell                    
                    Console.WriteLine("Do you wish to buy or sell?");
                    string answer = Console.ReadLine();
                    if (answer == "buy")
                    {
                        MetalMarketBuy();
                    }
                    else
                    {
                        MetalMarketSell();
                    }
                    break;
                case "2"://Fabric                    
                    Console.WriteLine("Do you wish to buy or sell?");
                    answer = Console.ReadLine();
                    if (answer == "buy")
                    {
                        GemstoneBuy();
                    }
                    else
                    {
                        GemstoneSell();
                    }
                    break;
                case "3"://gemstone                    
                    Console.WriteLine("Do you wish to buy or sell?");
                    answer = Console.ReadLine();
                    if (answer == "buy")
                    {
                        GemstoneBuy();
                    }
                    else
                    {
                        GemstoneSell();
                    }
                    break;
                case "4"://supplies                 
                    Console.WriteLine("Do you wish to buy or sell?");
                    answer = Console.ReadLine();
                    if (answer == "buy")
                    {
                        SupplyBuy();
                    }
                    else
                    {
                        SupplySell();
                    }
                    break;
            }
        }
        public void MetalMarketSell()
        {
            Console.WriteLine("Which type of Metal: \n1 - Platinium\n2 - Palladium\n3 - Titanium");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.platCrate(0)} platinum crates\n How many do you wish to sell");
                    int answer = int.Parse(Console.ReadLine());
                    answer *= -1;
                    vesselHold.platCrate(answer);
                    break;
                case "2":
                    Console.WriteLine($"{vesselHold.palladCrate(0)} palladium crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    answer *= -1;
                    vesselHold.palladCrate(answer);
                    break;
                case "3":
                    Console.WriteLine($"{vesselHold.titanCrate(0)} titanium crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    answer *= -1;
                    vesselHold.titanCrate(answer);
                    break;
                default:
                    
                    break;
            }
        }
        public void MetalMarketBuy()
        {

        }
        public void FabricBuy()
        {

        }
        public void FabricSell()
        {

        }
        public void GemstoneBuy()
        {

        }
        public void GemstoneSell()
        {

        }
        public void SupplyBuy()
        {

        }
        public void SupplySell()
        {

        }
    }
}
