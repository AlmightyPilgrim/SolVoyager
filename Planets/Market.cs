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

        public string MarketDisplay(string world)
        {
            int metal;
            double fabric;
            int gem;
            int supply;
            if (world == "Earth")
            {
                metal = 7;
                fabric = (1 / 3.0);
                gem = 6;
                supply = 1;
            }
            else if (world == "Alpha")
            {
                metal = 4;
                fabric = 5;
                gem = 8;
                supply = 5;
            }
            else if (world == "Colony")
            {
                metal = 1;
                fabric = 6;
                gem = 2;
                supply = 8;
            }
            else if (world == "Mars")
            {
                metal = 5;
                fabric = 5;
                gem = 9;
                supply = 3;
            }
            Console.WriteLine("Which resource would you like to view? \n1 - Metals\t 2 - Fabrics\n3 - Gemstone\t 4 - Supplies");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": //Metal selection buy/sell                    
                    Console.WriteLine("Do you wish to buy or sell?");
                    string answer = Console.ReadLine();
                    if (answer == "buy")
                    {
                        MetalMarketBuy(metal);
                    }
                    else
                    {
                        MetalMarketSell(metal);
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
            return world;
        }
        public int MetalMarketSell(int input)
        {
            int metalTotal;
            Console.WriteLine("Which type of Metal: \n1 - Platinium\n2 - Palladium\n3 - Titanium");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.platCrate(0)} platinum crates\n How many do you wish to sell");
                    int answer = int.Parse(Console.ReadLine());
                    metalTotal = metalPrice.Platinium(input);
                    answer *= -1;
                    vesselHold.platCrate(answer);
                    return metalTotal;                    
                case "2":
                    Console.WriteLine($"{vesselHold.palladCrate(0)} palladium crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    metalTotal = metalPrice.Palladium(input);
                    answer *= -1;
                    vesselHold.palladCrate(answer);
                    return metalTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.titanCrate(0)} titanium crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    metalTotal = metalPrice.Titanium(input);
                    answer *= -1;
                    vesselHold.titanCrate(answer);
                    return metalTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return input;
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
