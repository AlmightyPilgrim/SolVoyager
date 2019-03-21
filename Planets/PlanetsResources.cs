using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources;
using Currency;

namespace Planets // Resources
{
    // maybe try to make classes for each type of metal, per planet.
    // need a list for planets
    // list will be help with organizing resources
    // might need a resource list

    // modifier increase: high +3, AA +2, Standard +-1, BA -2, low -3

    public class EarthResources // base modifiers: metal - 4, fabric - 3, gemstone - 5, supply- 2
    {                  
        Metal metalEarthCost = new Metal();
        Fabric fabricEarthCost = new Fabric();
        Gemstones gemstoneEarthCost = new Gemstones();
        Supplies supplyEarthCost = new Supplies();
        
        //basevalue is the base modifier
        public int EarthPlatinium ()
        {
            int basevalue = 4 + 3;
            int earthPlatinium = metalEarthCost.Platinium(basevalue);
            return earthPlatinium;
        }

        public int EarthPalladium ()
        {
            int basevalue = 4 + 3;
            int earthPalladium = metalEarthCost.Palladium(basevalue);
            return earthPalladium;
        }    //separating the subtypes of resources to be able to pull individually

        public int EarthTitanium ()
        {
            int basevalue = 4 + 3;
            int earthTitanium = metalEarthCost.Titanium(basevalue);
            return earthTitanium;
        }

        public void EarthMetals() // high modifier
        {
            int earthPlatinium = EarthPlatinium();
            int earthPalladium = EarthPalladium();
            int earthTitanium = EarthTitanium();

            Console.WriteLine($"{earthPlatinium} - Platinium value on Earth\n" +
                $"{earthPalladium} - Palladium value on Earth\n" +
                $"{earthTitanium} - Titanium value on Earth");
        }

        public double EarthSilk ()
        {
            double basevalue = (1 / 3.0);
            double earthSilk = fabricEarthCost.Silk(basevalue);
            return earthSilk;
        }

        public double EarthCotton ()
        {
            double basevalue = (1 / 3.0);
            double earthCotton = fabricEarthCost.Cotton(basevalue);
            return earthCotton;
        }

        public double EarthLinen()
        {
            double basevalue = (1 / 3.0);
            double earthLinen = fabricEarthCost.Linen(basevalue);
            return earthLinen;
        }

        public void EarthFabric() // low, if not fractional modifier
        {
            double earthSilk = EarthSilk();
            double earthCotton = EarthCotton();
            double earthLinen = EarthLinen();

            Console.WriteLine($"{earthSilk} - Silk value on Earth\n" +
                $"{earthCotton} - Cotton value on Earth\n" +
                $"{earthLinen} - Linen value on Earth");
        }

        public int EarthDiamond()
        {
            int basevalue = 5 + 1;
            int earthDiamond = gemstoneEarthCost.Diamond(basevalue);
            return earthDiamond;
        }

        public int EarthRuby()
        {
            int basevalue = 5 + 1;
            int earthRuby = gemstoneEarthCost.Ruby(basevalue);
            return earthRuby;
        }

        public int EarthSapphire()
        {
            int basevalue = 5 + 1;
            int earthSapphire = gemstoneEarthCost.Sapphire(basevalue);
            return earthSapphire;
        }

        public void EarthGemstone() // standard modifier
        {
            int earthDiamond = EarthDiamond();
            int earthRuby = EarthRuby();
            int earthSapphire = EarthSapphire();

            Console.WriteLine($"{earthDiamond} - Diamond value on Earth\n" +
                $"{earthRuby} - Ruby value on Earth\n" +
                $"{earthSapphire} - Sapphire value on Earth");
        }

        public double EarthFood()
        {
            int basevalue = 2 - 1;
            double earthFood = supplyEarthCost.Food(basevalue);
            return earthFood;
        }

        public double EarthWater()
        {
            int basevalue = 2 - 1;
            double earthWater = supplyEarthCost.Water(basevalue);
            return earthWater;
        }

        public double EarthAlcohol()
        {
            int basevalue = 2 - 1;
            double earthAlcohol = supplyEarthCost.Alcohol(basevalue);
            return earthAlcohol;
        }

        public double EarthMedicine()
        {
            int basevalue = 2 - 1;
            double earthMedicine = supplyEarthCost.Medicine(basevalue);
            return earthMedicine;
        }

        public void EarthSupply() // below average modifier
        {
            double earthFood = EarthFood();
            double earthWater = EarthWater();
            double earthAlcohol = EarthAlcohol();
            double earthMedicine = EarthMedicine();

            Console.WriteLine($"{earthFood} - Food value on Earth\n" +
                $"{earthWater} - Water value on Earth\n" +
                $"{earthAlcohol} - Alcohol value on Earth\n" +
                $"{earthMedicine} - Medicine value on Earth");
        }
    }

    public class TauCetiResources // base modifiers: metal - 3, fabric - 3, gemstone - 6, supply - 4
    {
        Metal metaTauCost = new Metal();
        Fabric fabricTauCost = new Fabric();
        Gemstones gemstoneTauCost = new Gemstones();
        Supplies supplyTauCost = new Supplies();

        public int TauPlatinium()
        {
            int basevalue = 3 + 2;
            int tauPlatinium = metaTauCost.Platinium(basevalue);
            return tauPlatinium;
        }

        public int TauPalladium()
        {
            int basevalue = 3 + 2;
            int tauPalladium = metaTauCost.Palladium(basevalue);
            return tauPalladium;
        }    //separating the subtypes of resources to be able to pull individually

        public int TauTitanium()
        {
            int basevalue = 3 + 2;
            int tauTitanium = metaTauCost.Titanium(basevalue);
            return tauTitanium;
        }

        public void TauMetals() // above average modifier
        {
            int tauPlatinium = TauPlatinium();
            int tauPalladium = TauPalladium();
            int tauTitanium = TauTitanium();

            Console.WriteLine($"{tauPlatinium} - Platinium value on Tau Ceti\n" +
                $"{tauPalladium} - Palladium value on Tau Ceti\n" +
                $"{tauTitanium} - Titanium value on Tau Ceti");
        }

        public double TauSilk()
        {
            int basevalue = 3 + 2;
            double TauSilk = fabricTauCost.Silk(basevalue);
            return TauSilk;
        }

        public double TauCotton()
        {
            int basevalue = 3 + 2;
            double TauCotton = fabricTauCost.Cotton(basevalue);
            return TauCotton;
        }

        public double TauLinen()
        {
            int basevalue = 3 + 2;
            double tauLinen = fabricTauCost.Linen(basevalue);
            return tauLinen;
        }

        public void TauFabric() // above average modifier
        {
            double tauSilk = this.TauSilk();
            double tauCotton = this.TauCotton();
            double tauLinen = TauLinen();

            Console.WriteLine($"{tauSilk} - Silk value on Tau Ceti\n" +
                $"{tauCotton} - Cotton value on Tau Ceti\n" +
                $"{tauLinen} - Linen value on Tau Ceti");
        }

        public int TauDiamond()
        {
            int basevalue = 6 + 3;
            int tauDiamond = gemstoneTauCost.Diamond(basevalue);
            return tauDiamond;
        }

        public int TauRuby()
        {
            int basevalue = 6 + 3;
            int tauRuby = gemstoneTauCost.Ruby(basevalue);
            return tauRuby;
        }

        public int TauSapphire()
        {
            int basevalue = 6 + 3;
            int tauSapphire = gemstoneTauCost.Sapphire(basevalue);
            return tauSapphire;
        }

        public void TauGemstone() // high modifier
        {
            int tauDiamond = TauDiamond();
            int tauRuby = TauRuby();
            int tauSapphire = TauSapphire();

            Console.WriteLine($"{tauDiamond} - Diamond value on Tau Ceti\n" +
                $"{tauRuby} - Ruby value on Tau Ceti\n" +
                $"{tauSapphire} - Sapphire value on Tau Ceti");
        }

        public double TauFood()
        {
            int basevalue = 2 + 1;
            double tauFood = supplyTauCost.Food(basevalue);
            return tauFood;
        }

        public double TauWater()
        {
            int basevalue = 2 + 1;
            double tauWater = supplyTauCost.Water(basevalue);
            return tauWater;
        }

        public double TauAlcohol()
        {
            int basevalue = 2 + 1;
            double tauAlcohol = supplyTauCost.Alcohol(basevalue);
            return tauAlcohol;
        }

        public double TauMedicine()
        {
            int basevalue = 2 + 1;
            double tauMedicine = supplyTauCost.Medicine(basevalue);
            return tauMedicine;
        }

        public void TauSupply() // standard modifier
        {
            double tauFood = TauFood();
            double tauWater = TauWater();
            double tauAlcohol = TauAlcohol();
            double tauMedicine = TauMedicine();

            Console.WriteLine($"{tauFood} - Food value on Tau Ceti\n" +
                $"{tauWater} - Water value on Tau Ceti\n" +
                $"{tauAlcohol} - Alcohol value on Tau Ceti\n" +
                $"{tauMedicine} - Medicine value on Tau Ceti");
        }
    }   
    
    public class MiningColonyResources // base modifiers - 2, fabric - 4, gemstone - 4, supply - 5
    {
        Metal metalColonyCost = new Metal();
        Fabric fabricColonyCost = new Fabric();
        Gemstones gemstoneColonyCost = new Gemstones();
        Supplies supplyColonyCost = new Supplies();

        public int ColonyPlatinium()
        {
            int basevalue = 1;
            int colonyPlatinium = metalColonyCost.Platinium(basevalue);
            return colonyPlatinium;
        }

        public int ColonyPalladium()
        {
            int basevalue = 1;
            int colonyPalladium = metalColonyCost.Palladium(basevalue);
            return colonyPalladium;
        }    //separating the subtypes of resources to be able to pull individually

        public int ColonyTitanium()
        {
            int basevalue = 1;
            int colonyTitanium = metalColonyCost.Titanium(basevalue);
            return colonyTitanium;
        }

        public void ColonyMetals() // might have a negative modifier, or fractional
        {
            int colonyPlatinium = ColonyPlatinium();
            int colonyPalladium = ColonyPalladium();
            int colonyTitanium = ColonyTitanium();

            Console.WriteLine($"{colonyPlatinium} - Platinium value on the Mining Colony\n" +
                $"{colonyPalladium} - Palladium value on the Mining Colony\n" +
                $"{colonyTitanium} - Titanium value on the Mining Colony");
        }

        public double ColonySilk()
        {
            int basevalue = 4 + 2;
            double colonySilk = fabricColonyCost.Silk(basevalue);
            return colonySilk;
        }

        public double ColonyCotton()
        {
            int basevalue = 4 + 2;
            double colonyCotton = fabricColonyCost.Cotton(basevalue);
            return colonyCotton;
        }

        public double ColonyLinen()
        {
            int basevalue = 4 + 2;
            double colonyLinen = fabricColonyCost.Linen(basevalue);
            return colonyLinen;
        }

        public void ColonyFabric() // higher than average modifier
        {
            double colonySilk = ColonySilk();
            double colonyCotton = ColonyCotton();
            double colonyLinen = ColonyLinen();

            Console.WriteLine($"{colonySilk} - Silk value on the Mining Colony\n" +
                $"{colonyCotton} - Cotton value on the Mining Colony\n" +
                $"{colonyLinen} - Linen value on the Mining Colony");
        }

        public int ColonyDiamond()
        {
            int basevalue = 4 - 2;
            int colonyDiamond = gemstoneColonyCost.Diamond(basevalue);
            return colonyDiamond;
        }

        public int ColonyRuby()
        {
            int basevalue = 4 - 2;
            int colonyRuby = gemstoneColonyCost.Ruby(basevalue);
            return colonyRuby;
        }

        public int ColonySapphire()
        {
            int basevalue = 4 - 2;
            int colonySapphire = gemstoneColonyCost.Sapphire(basevalue);
            return colonySapphire;
        }

        public void ColonyGemstone() // below average modifier
        {
            int colonyDiamond = ColonyDiamond();
            int colonyRuby = ColonyRuby();
            int colonySapphire = ColonySapphire();

            Console.WriteLine($"{colonyDiamond} - Diamond value on the Mining Colony\n" +
                $"{colonyRuby} - Ruby value on the Mining Colony\n" +
                $"{colonySapphire} - Sapphire value on the Mining Colony");
        }

        public double ColonyFood()
        {
            int basevalue = 5 + 3;
            double colonyFood = supplyColonyCost.Food(basevalue);
            return colonyFood;
        }

        public double ColonyWater()
        {
            int basevalue = 5 + 3;
            double colonyWater = supplyColonyCost.Water(basevalue);
            return colonyWater;
        }

        public double ColonyAlcohol()
        {
            int basevalue = 5 + 3;
            double colonyAlcohol = supplyColonyCost.Alcohol(basevalue);
            return colonyAlcohol;
        }

        public double ColonyMedicine()
        {
            int basevalue = 5 + 3;
            double colonyMedicine = supplyColonyCost.Medicine(basevalue);
            return colonyMedicine;
        }

        public void ColonySupply() // high modifier
        {
            double colonyFood = ColonyFood();
            double colonyWater = ColonyWater();
            double colonyAlcohol = ColonyAlcohol();
            double colonyMedicine = ColonyMedicine();

            Console.WriteLine($"{colonyFood} - Food value on the Mining Colony\n" +
                $"{colonyWater} - Water value on the Mining Colony\n" +
                $"{colonyAlcohol} - Alcohol value on the Mining Colony\n" +
                $"{colonyMedicine} - Medicine value on the Mining Colony");
        }
    }

    public class AlphaCentariResources // base modifiers: metal - 3, fabic - 4, gemstone - 5, supply - 3
    {
        Metal metalCentariCost = new Metal();
        Fabric fabricCentariCost = new Fabric();
        Gemstones gemstoneCentariCost = new Gemstones();
        Supplies supplyCentariCost = new Supplies();

        public int CentariPlatinium()
        {
            int basevalue = 3 + 1;
            int centariPlatinium = metalCentariCost.Platinium(basevalue);
            return centariPlatinium;
        }

        public int CentariPalladium()
        {
            int basevalue = 3 + 1;
            int centariPalladium = metalCentariCost.Palladium(basevalue);
            return centariPalladium;
        }    //separating the subtypes of resources to be able to pull individually

        public int CentariTitanium()
        {
            int basevalue = 3 + 1;
            int centariTitanium = metalCentariCost.Titanium(basevalue);
            return centariTitanium;
        }

        public void CentariMetals() // standard modifier
        {
            int centariPlatinium = CentariPlatinium();
            int centariPalladium = CentariPalladium();
            int centariTitanium = CentariTitanium();

            Console.WriteLine($"{centariPlatinium} - Platinium value on Alpha Centari\n" +
                $"{centariPalladium} - Palladium value on Alpha Centari\n" +
                $"{centariTitanium} - Titanium value on Alpha Centari");
        }

        public double CentariSilk()
        {
            int basevalue = 4 + 1;
            double centariSilk = fabricCentariCost.Silk(basevalue);
            return centariSilk;
        }

        public double CentariCotton()
        {
            int basevalue = 4 + 1;
            double centariCotton = fabricCentariCost.Cotton(basevalue);
            return centariCotton;
        }

        public double CentariLinen()
        {
            int basevalue = 4 + 1;
            double centariLinen = fabricCentariCost.Linen(basevalue);
            return centariLinen;
        }

        public void CentariFabric() // standard modifier
        {
            double centariSilk = CentariSilk();
            double centariCotton = CentariCotton();
            double centariLinen = CentariLinen();

            Console.WriteLine($"{centariSilk} - Silk value on Alpha Centari\n" +
                $"{centariCotton} - Cotton value on Alpha Centari\n" +
                $"{centariLinen} - Linen value on Alpha Centari");
        }

        public int CentariDiamond()
        {
            int basevalue = 5 + 3;
            int centariDiamond = gemstoneCentariCost.Diamond(basevalue);
            return centariDiamond;
        }

        public int CentariRuby()
        {
            int basevalue = 5 + 3;
            int centariRuby = gemstoneCentariCost.Ruby(basevalue);
            return centariRuby;
        }

        public int CentariSapphire()
        {
            int basevalue = 5 + 3;
            int centariSapphire = gemstoneCentariCost.Sapphire(basevalue);
            return centariSapphire;
        }

        public void CentariGemstone() // high modifier
        {
            int centariDiamond = CentariDiamond();
            int centariRuby = CentariRuby();
            int centariSapphire = CentariSapphire();

            Console.WriteLine($"{centariDiamond} - Diamond value on Alpha Centari\n" +
                $"{centariRuby} - Ruby value on Alpha Centari\n" +
                $"{centariSapphire} - Sapphire value on Alpha Centari");
        }

        public double CentariFood()
        {
            int basevalue = 3 + 2;
            double centariFood = supplyCentariCost.Food(basevalue);
            return centariFood;
        }

        public double CentariWater()
        {
            int basevalue = 3 + 2;
            double centariWater = supplyCentariCost.Water(basevalue);
            return centariWater;
        }

        public double CentariAlcohol()
        {
            int basevalue = 3 + 2;
            double centariAlcohol = supplyCentariCost.Alcohol(basevalue);
            return centariAlcohol;
        }

        public double CentariMedicine()
        {
            int basevalue = 3 + 2;
            double centariMedicine = supplyCentariCost.Medicine(basevalue);
            return centariMedicine;
        }

        public void CentariSupply() // above average- modifier
        {
            double centariFood = CentariFood();
            double centariWater = CentariWater();
            double centariAlcohol = CentariAlcohol();
            double centariMedicine = CentariMedicine();

            Console.WriteLine($"{centariFood} - Food value on Alpha Centari\n" +
                $"{centariWater} - Water value on Alpha Centari\n" +
                $"{centariAlcohol} - Alcohol value on Alpha Centari\n" +
                $"{centariMedicine} - Medicine value on Alpha Centari");
        }
    }
}
