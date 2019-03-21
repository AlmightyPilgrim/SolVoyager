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

        // include loops in the display incase of trying to view multiple types as well
        // also making it so they dont go to ship and back to planet
        public string MarketDisplay(string world)
        {
            bool check = true;
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
            Console.WriteLine(vesselHold.playerWallet(0));
            while (check == true)
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
                            metal = MetalMarketBuy(metal) * -1;
                            marketWallet(metal);
                        }
                        else
                        {
                            metal = MetalMarketSell(metal);
                            marketWallet(metal);
                        }
                        break;
                    case "2"://Fabric                    
                        Console.WriteLine("Do you wish to buy or sell?");
                        answer = Console.ReadLine();
                        if (answer == "buy")
                        {
                            fabric = -1 * FabricBuy(fabric);
                            marketWallet(fabric);
                        }
                        else
                        {
                            fabric = FabricSell(fabric);
                            marketWallet(fabric);
                        }
                        break;
                    case "3"://gemstone                    
                        Console.WriteLine("Do you wish to buy or sell?");
                        answer = Console.ReadLine();
                        if (answer == "buy")
                        {
                            gem = -1 * GemstoneBuy(gem);
                            marketWallet(gem);
                        }
                        else
                        {
                            gem = -1 * GemstoneSell(gem);
                            marketWallet(gem);
                        }
                        break;
                    case "4"://supplies                 
                        Console.WriteLine("Do you wish to buy or sell?");
                        answer = Console.ReadLine();
                        if (answer == "buy")
                        {
                            supply = -1 * SupplyBuy(supply);
                            marketWallet(supply);
                        }
                        else
                        {
                            supply = SupplySell(supply);
                            marketWallet(supply);
                        }
                        break;
                }
                Console.WriteLine("Do you wish to view additional resources?\n\ty/n");
                string decision = Console.ReadLine();
                if (decision == "y")
                {
                }
                else
                {
                    check = false;
                }
                Console.Clear();
            }
            return world;
        }


        // buy sell methods, just need to add the wallet to sad methods or in the display
        // method, also need to include a way to monitor the both amounts.
        public int MetalMarketBuy(int metalMod)
        {
            int metalTotal;
            Console.WriteLine("Which type of Metal: \n1 - Platinium\n2 - Palladium\n3 - Titanium");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.platCrate(0)} platinum crates\n How many do you wish to buy");
                    int answer = int.Parse(Console.ReadLine());
                    metalTotal = metalPrice.Platinium(metalMod);
                    metalTotal = metalTotal * answer;
                    vesselHold.platCrate(answer);
                    return metalTotal;
                case "2":
                    Console.WriteLine($"{vesselHold.palladCrate(0)} palladium crates\n How many do you wish to buy");
                    answer = int.Parse(Console.ReadLine());
                    metalTotal = metalPrice.Palladium(metalMod);
                    metalTotal = metalTotal * answer;
                    vesselHold.palladCrate(answer);
                    return metalTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.titanCrate(0)} titanium crates\n How many do you wish to buy");
                    answer = int.Parse(Console.ReadLine());
                    metalTotal = metalPrice.Titanium(metalMod);
                    metalTotal = metalTotal * answer;
                    vesselHold.titanCrate(answer);
                    return metalTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return metalMod;
            }
        }
        public int MetalMarketSell(int metalMod)
        {
            int metalTotal;
            Console.WriteLine("Which type of Metal: \n1 - Platinium\n2 - Palladium\n3 - Titanium");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.platCrate(0)} platinum crates\n How many do you wish to sell");
                    int answer = int.Parse(Console.ReadLine());
                    metalTotal = metalPrice.Platinium(metalMod);
                    metalTotal = metalTotal * answer;
                    answer *= -1;
                    vesselHold.platCrate(answer);
                    return metalTotal;                    
                case "2":
                    Console.WriteLine($"{vesselHold.palladCrate(0)} palladium crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    metalTotal = metalPrice.Palladium(metalMod);
                    metalTotal = metalTotal * answer;
                    answer *= -1;
                    vesselHold.palladCrate(answer);
                    return metalTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.titanCrate(0)} titanium crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    metalTotal = metalPrice.Titanium(metalMod);
                    metalTotal = metalTotal * answer;
                    answer *= -1;
                    vesselHold.titanCrate(answer);
                    return metalTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return metalMod;
            }
        }
        public double FabricBuy(double fabricMod)
        {
            double fabricTotal;
            Console.WriteLine("Which type of Fabric: \n1 - Silk\n2 - Cotton\n3 - Linen");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.silkCrate(0)} silk crates\n How many do you wish to buy");
                    int answer = int.Parse(Console.ReadLine());
                    fabricTotal = fabricPrice.Silk(fabricMod);
                    fabricTotal = fabricTotal * answer;
                    vesselHold.silkCrate(answer);
                    return fabricTotal;
                case "2":
                    Console.WriteLine($"{vesselHold.cottonCrate(0)} cotton crates\n How many do you wish to buy");
                    answer = int.Parse(Console.ReadLine());
                    fabricTotal = fabricPrice.Cotton(fabricMod);
                    fabricTotal = fabricTotal * answer;
                    vesselHold.cottonCrate(answer);
                    return fabricTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.linenCrate(0)} linen crates\n How many do you wish to buy");
                    answer = int.Parse(Console.ReadLine());
                    fabricTotal = fabricPrice.Linen(fabricMod);
                    fabricTotal = fabricTotal * answer;
                    vesselHold.linenCrate(answer);
                    return fabricTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return fabricMod;
            }
        }
        public double FabricSell(double fabricMod)
        {
            double fabricTotal;
            Console.WriteLine("Which type of Fabric: \n1 - Silk\n2 - Cotton\n3 - Linen");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.silkCrate(0)} silk crates\n How many do you wish to sell");
                    int answer = int.Parse(Console.ReadLine());
                    fabricTotal = fabricPrice.Silk(fabricMod);
                    fabricTotal = fabricTotal * answer;
                    answer *= -1;
                    vesselHold.silkCrate(answer);
                    return fabricTotal;
                case "2":
                    Console.WriteLine($"{vesselHold.cottonCrate(0)} cotton crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    fabricTotal = fabricPrice.Cotton(fabricMod);
                    fabricTotal = fabricTotal * answer;
                    answer *= -1;
                    vesselHold.cottonCrate(answer);
                    return fabricTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.linenCrate(0)} linen crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    fabricTotal = fabricPrice.Linen(fabricMod);
                    fabricTotal = fabricTotal * answer;
                    answer *= -1;
                    vesselHold.linenCrate(answer);
                    return fabricTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return fabricMod;
            }
        }
        public int GemstoneBuy(int gemMod)
        {
            int gemTotal;
            Console.WriteLine("Which type of Gemstone: \n1 - Diamond\n2 - Ruby\n3 - Sapphire");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.diaCrate(0)} diamond crates\n How many do you wish to buy");
                    int answer = int.Parse(Console.ReadLine());
                    gemTotal = gemstonePrice.Diamond(gemMod);
                    gemTotal = gemTotal * answer;
                    vesselHold.diaCrate(answer);
                    return gemTotal;
                case "2":
                    Console.WriteLine($"{vesselHold.rubyCrate(0)} ruby crates\n How many do you wish to buy");
                    answer = int.Parse(Console.ReadLine());
                    gemTotal = gemstonePrice.Ruby(gemMod);
                    gemTotal = gemTotal * answer;
                    vesselHold.rubyCrate(answer);
                    return gemTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.sappCrate(0)} sapphire crates\n How many do you wish to buy");
                    answer = int.Parse(Console.ReadLine());
                    gemTotal = gemstonePrice.Sapphire(gemMod);
                    gemTotal = gemTotal * answer;
                    vesselHold.sappCrate(answer);
                    return gemTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return gemMod;
            }
        }
        public int GemstoneSell(int gemMod)
        {
            int gemTotal;
            Console.WriteLine("Which type of Gemstone: \n1 - Diamond\n2 - Ruby\n3 - Sapphire");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.diaCrate(0)} diamond crates\n How many do you wish to sell");
                    int answer = int.Parse(Console.ReadLine());
                    gemTotal = gemstonePrice.Diamond(gemMod);
                    gemTotal *= answer;
                    answer *= -1;
                    vesselHold.diaCrate(answer);
                    return gemTotal;
                case "2":
                    Console.WriteLine($"{vesselHold.rubyCrate(0)} ruby crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    gemTotal = gemstonePrice.Ruby(gemMod);
                    gemTotal *= answer;
                    answer *= -1;
                    vesselHold.rubyCrate(answer);
                    return gemTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.sappCrate(0)} sapphire crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    gemTotal = gemstonePrice.Sapphire(gemMod);
                    gemTotal *= answer;
                    answer *= -1;
                    vesselHold.sappCrate(answer);
                    return gemTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return gemMod;
            }
        }
        public double SupplyBuy(double supplyMod)
        {
            double supplyTotal;
            Console.WriteLine("Which type of Supply: \n1 - Food\n2 - Water\n3 - Alcohol\n4 - Medicine");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.foodCrate(0)} food crates\n How many do you wish to buy");
                    int answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Food(supplyMod);
                    supplyTotal = supplyTotal * answer;
                    vesselHold.foodCrate(answer);
                    return supplyTotal;
                case "2":
                    Console.WriteLine($"{vesselHold.waterCrate(0)} water crates\n How many do you wish to buy");
                    answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Water(supplyMod);
                    supplyTotal = supplyTotal * answer;
                    vesselHold.waterCrate(answer);
                    return supplyTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.alcoCrate(0)} alcohol crates\n How many do you wish to buy");
                    answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Alcohol(supplyMod);
                    supplyTotal = supplyTotal * answer;
                    vesselHold.alcoCrate(answer);
                    return supplyTotal;
                case "4":
                    Console.WriteLine($"{vesselHold.mediCrate(0)} medicine crates\n How many do you wish to buy");
                    answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Medicine(supplyMod);
                    supplyTotal = supplyTotal * answer;
                    vesselHold.mediCrate(answer);
                    return supplyTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return supplyMod;
            }
        }
        public double SupplySell(double supplyMod)
        {
            double supplyTotal;
            Console.WriteLine("Which type of Supply: \n1 - Food\n2 - Water\n3 - Alcohol\n4 - Medicine");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{vesselHold.foodCrate(0)} food crates\n How many do you wish to sell");
                    int answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Food(supplyMod);
                    supplyTotal = supplyTotal * answer;
                    answer *= -1;
                    vesselHold.foodCrate(answer);
                    return supplyTotal;
                case "2":
                    Console.WriteLine($"{vesselHold.waterCrate(0)} water crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Water(supplyMod);
                    supplyTotal = supplyTotal * answer;
                    answer *= -1;
                    vesselHold.waterCrate(answer);
                    return supplyTotal;
                case "3":
                    Console.WriteLine($"{vesselHold.alcoCrate(0)} alcohol crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Alcohol(supplyMod);
                    supplyTotal = supplyTotal * answer;
                    answer *= -1;
                    vesselHold.alcoCrate(answer);
                    return supplyTotal;
                case "4":
                    Console.WriteLine($"{vesselHold.mediCrate(0)} medicine crates\n How many do you wish to sell");
                    answer = int.Parse(Console.ReadLine());
                    supplyTotal = supplyPrice.Medicine(supplyMod);
                    supplyTotal = supplyTotal * answer;
                    answer *= -1;
                    vesselHold.mediCrate(answer);
                    return supplyTotal;
                default:
                    Console.WriteLine("Invalid Input");
                    return supplyMod;
            }
        }

        // need to fill this method
        public double marketWallet(double price)
        {
            double walletAmount = vesselHold.playerWallet(price); // needs an actual value
            Console.WriteLine($"{walletAmount} credits remaining");
            return walletAmount;
        }
    }
}
