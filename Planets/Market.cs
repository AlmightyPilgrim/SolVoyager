using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources;
using Vessel;

namespace Planets
{
    public class Market
    {
        Metal metalPrice = new Metal();
        Fabric fabricPrice = new Fabric();
        Gemstones gemstonePrice = new Gemstones();
        Supplies supplyPrice = new Supplies();
        Ship vesselHold = new Ship();

        public string MarketDisplay(string world)
        {
            int metal = 0;
            double fabric = 0;
            int gem = 0;
            double supply = 0;
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
                        FabricBuy(fabric);
                    }
                    else
                    {
                        FabricBuy(fabric);
                    }
                    break;
                case "3"://gemstone                    
                    Console.WriteLine("Do you wish to buy or sell?");
                    answer = Console.ReadLine();
                    if (answer == "buy")
                    {
                        GemstoneBuy(gem);
                    }
                    else
                    {
                        GemstoneSell(gem);
                    }
                    break;
                case "4"://supplies                 
                    Console.WriteLine("Do you wish to buy or sell?");
                    answer = Console.ReadLine();
                    if (answer == "buy")
                    {
                        SupplyBuy(supply);
                    }
                    else
                    {
                        SupplySell(supply);
                    }
                    break;
            }
            return world;
        }

        public int MetalMarketBuy(int input)
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
                    metalTotal *= answer;
                    vesselHold.platCrate(answer);
                    return metalTotal;
                case "2":
                    Console.WriteLine($"{vesselHold.palladCrate(0)} palladium crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    metalTotal = metalPrice.Palladium(input);
                    vesselHold.palladCrate(answer);
                    return metalTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.titanCrate(0)} titanium crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    metalTotal = metalPrice.Titanium(input);
                    vesselHold.titanCrate(answer);
                    return metalTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return input;
            }
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
                    metalTotal *= answer;
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
        public double FabricBuy(double input)
        {
            double fabricTotal;
            Console.WriteLine("Which type of Metal: \n1 - Silk\n2 - Cotton\n3 - Linen");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.silkCrate(0)} silk crates\n How many do you wish to sell");
                    int answer = int.Parse(Console.ReadLine());
                    fabricTotal = fabricPrice.Silk(input);
                    fabricTotal *= answer;
                    vesselHold.silkCrate(answer);
                    return fabricTotal;
                case "2":
                    Console.WriteLine($"{vesselHold.cottonCrate(0)} cotton crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    fabricTotal = fabricPrice.Cotton(input);
                    vesselHold.cottonCrate(answer);
                    return fabricTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.linenCrate(0)} linen crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    fabricTotal = fabricPrice.Linen(input);
                    vesselHold.linenCrate(answer);
                    return fabricTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return input;
            }
        }
        public double FabricSell(double input)
        {
            double fabricTotal;
            Console.WriteLine("Which type of Metal: \n1 - Silk\n2 - Cotton\n3 - Linen");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.silkCrate(0)} silk crates\n How many do you wish to sell");
                    int answer = int.Parse(Console.ReadLine());
                    fabricTotal = fabricPrice.Silk(input);
                    fabricTotal *= answer;
                    answer *= -1;
                    vesselHold.silkCrate(answer);
                    return fabricTotal;
                case "2":
                    Console.WriteLine($"{vesselHold.cottonCrate(0)} cotton crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    fabricTotal = fabricPrice.Cotton(input);
                    answer *= -1;
                    vesselHold.cottonCrate(answer);
                    return fabricTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.linenCrate(0)} linen crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    fabricTotal = fabricPrice.Linen(input);
                    answer *= -1;
                    vesselHold.linenCrate(answer);
                    return fabricTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return input;
            }
        }
        public int GemstoneBuy(int input)
        {
            int gemTotal;
            Console.WriteLine("Which type of Metal: \n1 - Diamond\n2 - Ruby\n3 - Sapphire");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.diaCrate(0)} diamond crates\n How many do you wish to sell");
                    int answer = int.Parse(Console.ReadLine());
                    gemTotal = gemstonePrice.Diamond(input);
                    gemTotal *= answer;
                    vesselHold.diaCrate(answer);
                    return gemTotal;
                case "2":
                    Console.WriteLine($"{vesselHold.rubyCrate(0)} ruby crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    gemTotal = gemstonePrice.Ruby(input);
                    vesselHold.rubyCrate(answer);
                    return gemTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.sappCrate(0)} sapphire crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    gemTotal = gemstonePrice.Sapphire(input);
                    vesselHold.sappCrate(answer);
                    return gemTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return input;
            }
        }
        public int GemstoneSell(int input)
        {
            int gemTotal;
            Console.WriteLine("Which type of Metal: \n1 - Diamond\n2 - Ruby\n3 - Sapphire");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.diaCrate(0)} diamond crates\n How many do you wish to sell");
                    int answer = int.Parse(Console.ReadLine());
                    gemTotal = gemstonePrice.Diamond(input);
                    gemTotal *= answer;
                    answer *= -1;
                    vesselHold.diaCrate(answer);
                    return gemTotal;
                case "2":
                    Console.WriteLine($"{vesselHold.rubyCrate(0)} ruby crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    gemTotal = gemstonePrice.Ruby(input);
                    answer *= -1;
                    vesselHold.rubyCrate(answer);
                    return gemTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.sappCrate(0)} sapphire crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    gemTotal = gemstonePrice.Sapphire(input);
                    answer *= -1;
                    vesselHold.sappCrate(answer);
                    return gemTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return input;
            }
        }
        public double SupplyBuy(double input)
        {
            double supplyTotal;
            Console.WriteLine("Which type of Metal: \n1 - Food\n2 - Water\n3 - Alcohol\n4 - Medicine");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.foodCrate(0)} food crates\n How many do you wish to sell");
                    int answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Food(input);
                    supplyTotal *= answer;
                    vesselHold.foodCrate(answer);
                    return supplyTotal;
                case "2":
                    Console.WriteLine($"{vesselHold.waterCrate(0)} water crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Water(input);
                    vesselHold.waterCrate(answer);
                    return supplyTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.alcoCrate(0)} alcohol crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Alcohol(input);
                    vesselHold.alcoCrate(answer);
                    return supplyTotal;
                case "4":
                    Console.WriteLine($"{vesselHold.mediCrate(0)} medicine crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Medicine(input);
                    vesselHold.mediCrate(answer);
                    return supplyTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return input;
            }
        }
        public double SupplySell(double input)
        {
            double supplyTotal;
            Console.WriteLine("Which type of Metal: \n1 - Food\n2 - Water\n3 - Alcohol\n4 - Medicine");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.foodCrate(0)} food crates\n How many do you wish to sell");
                    int answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Food(input);
                    supplyTotal *= answer;
                    answer *= -1;
                    vesselHold.foodCrate(answer);
                    return supplyTotal;
                case "2":
                    Console.WriteLine($"{vesselHold.waterCrate(0)} water crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Water(input);
                    answer *= -1;
                    vesselHold.waterCrate(answer);
                    return supplyTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.alcoCrate(0)} alcohol crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Alcohol(input);
                    answer *= -1;
                    vesselHold.alcoCrate(answer);
                    return supplyTotal;
                case "4":
                    Console.WriteLine($"{vesselHold.mediCrate(0)} medicine crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Medicine(input);
                    answer *= -1;
                    vesselHold.mediCrate(answer);
                    return supplyTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return input;
            }
        }
    }
}
