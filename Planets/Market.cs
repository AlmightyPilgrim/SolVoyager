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
        public void MarketDisplay()
        {
            Metal metalPrice = new Metal();
            Fabric fabricPrice = new Fabric();
            Gemstones gemstonePrice = new Gemstones();
            Supplies supplyPrice = new Supplies();

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
