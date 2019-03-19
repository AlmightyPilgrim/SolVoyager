using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources;

namespace Planets
{
    class Market
    {
        public void MarketDisplay()
        {
            Console.WriteLine("Which Resource Prices would you like to view? \n1 - Metals\t 2 - Fabrics\n3 - Gemstone\t 4 - Supplies");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": //Metal selection buy/sell
                    Console.WriteLine("Metal Prices:");
                    
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
                    Console.WriteLine("Fabric Prices:");
                    
                    Console.WriteLine("Do you wish to buy or sell?");
                    answer = Console.ReadLine();
                    if (answer == "buy")
                    {
                        MetalMarketBuy();
                    }
                    else
                    {
                        MetalMarketSell();
                    }
                    break;
                case "3"://gemstone
                    Console.WriteLine("Gemstone Prices:");
                    
                    Console.WriteLine("Do you wish to buy or sell?");
                    answer = Console.ReadLine();
                    if (answer == "buy")
                    {
                        MetalMarketBuy();
                    }
                    else
                    {
                        MetalMarketSell();
                    }
                    break;
                case "4"://supplies
                    Console.WriteLine("Basic Supply Prices:");
                   
                    Console.WriteLine("Do you wish to buy or sell?");
                    answer = Console.ReadLine();
                    if (answer == "buy")
                    {
                        MetalMarketBuy();
                    }
                    else
                    {
                        MetalMarketSell();
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
