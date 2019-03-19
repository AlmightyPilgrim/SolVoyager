using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources;

namespace Planets
{
    class Earth
    {
        EarthResources materialsEarth = new EarthResources();
        public void MarketDisplay()
        {
            Console.WriteLine("Which Resource Prices would you like to view? \n1 - Metals\t 2 - Fabrics\n3 - Gemstone\t 4 - Supplies");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Metal Prices:");
                    materialsEarth.EarthMetals();
                    break;
                case "2":
                    Console.WriteLine("Fabric Prices:");
                    materialsEarth.EarthFabric();
                    break;
                case "3":
                    Console.WriteLine("Gemstone Prices:");
                    materialsEarth.EarthGemstone();
                    break;
                case "4":
                    Console.WriteLine("Basic Supply Prices:");
                    materialsEarth.EarthSupply();
                    break;

            }
            
        }
    }
}
