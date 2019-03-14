using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources;
using Currency;

namespace PlanetsResources
{
    // maybe try to make classes for each type of metal, per planet.
    // need a list for planets
    // list will be help with organizing resources
    // might need a resource list
    public class Earth // base modifiers: metal - 4, fabric - 3, gemstone - 5, supply- 2
    {                  // modifier increase: high +3, AA +2, Standard +-1, BA -2, low -3
        Metals metalEarthCost = new Metals();
        Fabric fabricEarthCost = new Fabric();
        Gemstones gemstoneEarthCost = new Gemstones();
        Supplies supplyEarthCost = new Supplies();
        //basevalue is the base modifier

        public int EarthMetals(int metal) // high modifier
        {
            int basevalue = 4 + 3;

            int earthPlatinium = metalEarthCost.Platinium(basevalue);
            int earthPalladium = metalEarthCost.Palladium(basevalue);
            int earthTitanium = metalEarthCost.Titanium(basevalue);

            Console.WriteLine($"{earthPlatinium} - Platinium value on Earth\n" +
                $"{earthPalladium} - Palladium value on Earth\n" +
                $"{earthTitanium} - Titanium value on Earth");
            return metal;
        }

        public double EarthFabric(double fabric) // low, if not fractional modifier
        {
            double basevalue = (1 / 3.0);

            double earthSilk = fabricEarthCost.Silk(basevalue);
            double earthCotton = fabricEarthCost.Cotton(basevalue);
            double earthLinen = fabricEarthCost.Linen(basevalue);

            Console.WriteLine($"{earthSilk} - Silk value on Earth\n" +
                $"{earthCotton} - Cotton value on Earth\n" +
                $"{earthLinen} - Linen value on Earth");
            return fabric;
        }

        public int EarthGemstone(int gemstone) // standard modifier
        {
            int basevalue = 5 + 1;

            int earthDiamond = gemstoneEarthCost.Diamond(basevalue);
            int earthRuby = gemstoneEarthCost.Ruby(basevalue);
            int earthSapphire = gemstoneEarthCost.Sapphire(basevalue);

            Console.WriteLine($"{earthDiamond} - Diamond value on Earth\n" +
                $"{earthRuby} - Ruby value on Earth\n" +
                $"{earthSapphire} - Sapphire value on Earth");
            return gemstone;
        }

        public int EarthSupply(int supply) // below average modifier
        {
            int basevalue = 2 - 1;
            double earthFood = supplyEarthCost.Food(basevalue);
            double earthWater = supplyEarthCost.Water(basevalue);
            double earthAlcohol = supplyEarthCost.Alcohol(basevalue);
            double earthMedicine = supplyEarthCost.Medicine(basevalue);

            Console.WriteLine($"{earthFood} - Food value on Earth\n" +
                $"{earthWater} - Water value on Earth\n" +
                $"{earthAlcohol} - Alcohol value on Earth\n" +
                $"{earthMedicine} - Medicine value on Earth");
            return supply;
        }
    }

    public class Mars // base modifiers: metal - 3, fabric - 3, gemstone - 6, supply - 4
    {
        Metals metalMarsCost = new Metals();
        Fabric fabricMarsCost = new Fabric();
        Gemstones gemstoneMarsCost = new Gemstones();
        Supplies supplyMarsCost = new Supplies();

        public int MarsMetals(int metal) // above average modifier
        {
            int basevalue = 3 + 2;

            int marsPlatinium = metalMarsCost.Platinium(basevalue);
            int marsPalladium = metalMarsCost.Palladium(basevalue);
            int marsTitanium = metalMarsCost.Titanium(basevalue);

            Console.WriteLine($"{marsPlatinium} - Platinium value on Mars\n" +
                $"{marsPalladium} - Palladium value on Mars\n" +
                $"{marsTitanium} - Titanium value on Mars");
            return metal;
        }

        public double MarsFabric(double fabric) // above average modifier
        {
            int basevalue = 3 + 2;

            double marsSilk = fabricMarsCost.Silk(basevalue);
            double marsCotton = fabricMarsCost.Cotton(basevalue);
            double marsLinen = fabricMarsCost.Linen(basevalue);

            Console.WriteLine($"{marsSilk} - Silk value on Mars\n" +
                $"{marsCotton} - Cotton value on Mars\n" +
                $"{marsLinen} - Linen value on Mars");
            return fabric;
        }

        public int MarsGemstone(int gemstone) // high modifier
        {
            int basevalue= 5;

            int marsDiamond = gemstoneMarsCost.Diamond(basevalue);
            int marsRuby = gemstoneMarsCost.Ruby(basevalue);
            int marsSapphire = gemstoneMarsCost.Sapphire(basevalue);

            Console.WriteLine($"{marsDiamond} - Diamond value on Mars\n" +
                $"{marsRuby} - Ruby value on Mars\n" +
                $"{marsSapphire} - Sapphire value on Mars");
            return gemstone;
        }

        public double MarsSupply(double supply) // standard modifier
        {
            int basevalue = 2;

            double marsFood = supplyMarsCost.Food(basevalue);
            double marsWater = supplyMarsCost.Water(basevalue);
            double marsAlcohol = supplyMarsCost.Alcohol(basevalue);
            double marsMedicine = supplyMarsCost.Medicine(basevalue);

            Console.WriteLine($"{marsFood} - Food value on Mars\n" +
                $"{marsWater} - Water value on Mars\n" +
                $"{marsAlcohol} - Alcohol value on Mars\n" +
                $"{marsMedicine} - Medicine value on Mars");
            return supply;
        }
    }   
    
    public class MiningColony // base modifiers - 2, fabric - 4, gemstone - 4, supply - 5
    {
        Metals metalColonyCost = new Metals();
        Fabric fabricColonyCost = new Fabric();
        Gemstones gemstoneColonyCost = new Gemstones();
        Supplies supplyColonyCost = new Supplies();

        public int ColonyMetals(int metal) // might have a negative modifier, or fractional
        {
            int basevalue = 1; // the laziness modifier

            int colonyPlatinium = metalColonyCost.Platinium(basevalue);
            int colonyPalladium = metalColonyCost.Palladium(basevalue);
            int colonyTitanium = metalColonyCost.Titanium(basevalue);

            Console.WriteLine($"{colonyPlatinium} - Platinium value on the Mining Colony\n" +
                $"{colonyPalladium} - Palladium value on the Mining Colony\n" +
                $"{colonyTitanium} - Titanium value on the Mining Colony");
            return metal;
        }

        public double ColonyFabric(double fabric) // higher than average modifier
        {
            int basevalue = 4 + 2;

            double colonySilk = fabricColonyCost.Silk(basevalue);
            double colonyCotton = fabricColonyCost.Cotton(basevalue);
            double colonyLinen = fabricColonyCost.Linen(basevalue);

            Console.WriteLine($"{colonySilk} - Silk value on the Mining Colony\n" +
                $"{colonyCotton} - Cotton value on the Mining Colony\n" +
                $"{colonyLinen} - Linen value on the Mining Colony");
            return fabric;
        }

        public int ColonyGemstone(int gemstone) // below average modifier
        {
            int basevalue = 4 - 2;

            int colonyDiamond = gemstoneColonyCost.Diamond(basevalue);
            int colonyRuby = gemstoneColonyCost.Ruby(basevalue);
            int colonySapphire = gemstoneColonyCost.Sapphire(basevalue);

            Console.WriteLine($"{colonyDiamond} - Diamond value on the Mining Colony\n" +
                $"{colonyRuby} - Ruby value on the Mining Colony\n" +
                $"{colonySapphire} - Sapphire value on the Mining Colony");
            return gemstone;
        }

        public double ColonySupply(double supply) // high modifier
        {
            int basevalue = 5 + 3;

            double colonyFood = supplyColonyCost.Food(basevalue);
            double colonyWater = supplyColonyCost.Water(basevalue);
            double colonyAlcohol = supplyColonyCost.Alcohol(basevalue);
            double colonyMedicine = supplyColonyCost.Medicine(basevalue);

            Console.WriteLine($"{colonyFood} - Food value on the Mining Colony\n" +
                $"{colonyWater} - Water value on the Mining Colony\n" +
                $"{colonyAlcohol} - Alcohol value on the Mining Colony\n" +
                $"{colonyMedicine} - Medicine value on the Mining Colony");
            return supply;
        }
    }

    public class AlphaCentari // base modifiers: metal - 3, fabic - 4, gemstone - 5, supply - 3
    {
        Metals metalCentariCost = new Metals();
        Fabric fabricCentariCost = new Fabric();
        Gemstones gemstoneCentariCost = new Gemstones();
        Supplies supplyCentariCost = new Supplies();

        public int CentariMetals(int metal) // standard modifier
        {
            int basevalue = 3 + 1;

            int centariPlatinium = metalCentariCost.Platinium(basevalue);
            int centariPalladium = metalCentariCost.Palladium(basevalue);
            int centariTitantium = metalCentariCost.Titanium(basevalue);

            Console.WriteLine($"{centariPlatinium} - Platinium value on Alpha Centari\n" +
                $"{centariPalladium} - Palladium value on Alpha Centari\n" +
                $"{centariTitantium} - Titanium value on Alpha Centari");
            return metal;
        }

        public double CentariFabric(double fabric) // standard modifier
        {
            int basevalue = 4 + 1;

            double centariSilk = fabricCentariCost.Silk(basevalue);
            double centariCotton = fabricCentariCost.Cotton(basevalue);
            double centariLinen = fabricCentariCost.Linen(basevalue);

            Console.WriteLine($"{centariSilk} - Silk value on Alpha Centari\n" +
                $"{centariCotton} - Cotton value on Alpha Centari\n" +
                $"{centariLinen} - Linen value on Alpha Centari");
            return fabric;
        }

        public int CentariGemstone(int gemstone) // high modifier
        {
            int basevalue = 5 + 3;

            int centariDiamond = gemstoneCentariCost.Diamond(basevalue);
            int centariRuby = gemstoneCentariCost.Ruby(basevalue);
            int centariSapphire = gemstoneCentariCost.Sapphire(basevalue);

            Console.WriteLine($"{centariDiamond} - Diamond value on Alpha Centari\n" +
                $"{centariRuby} - Ruby value on Alpha Centari\n" +
                $"{centariSapphire} - Sapphire value on Alpha Centari");
            return gemstone;
        }

        public double CentariSupply(double supply) // above average- modifier
        {
            int basevalue = 3 + 2;

            double centariFood = supplyCentariCost.Food(basevalue);
            double centariWater = supplyCentariCost.Water(basevalue);
            double centariAlcohol = supplyCentariCost.Alcohol(basevalue);
            double centariMedicine = supplyCentariCost.Medicine(basevalue);

            Console.WriteLine($"{centariFood} - Food value on Alpha Centari\n" +
                $"{centariWater} - Water value on Alpha Centari\n" +
                $"{centariAlcohol} - Alcohol value on Alpha Centari\n" +
                $"{centariMedicine} - Medicine value on Alpha Centari");
            return supply;
        }
    }
}
