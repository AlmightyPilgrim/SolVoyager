using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency;

namespace Resources
{
    // make classes for each of the different types of sub-resources
    public class Metal // get a base modifier of 2
    {
        Creds metalCredits = new Creds();
        public int Platinium(int metalModifier) // will have a modifier of 3
        {
            metalModifier *= 3;
            return metalCredits.MetalCreds(metalModifier);
        }

        public int Palladium(int metalModifier) // will have a modifier of 4
        {
            metalModifier *= 4;
           return  metalCredits.MetalCreds(metalModifier);
        }

        public int Titanium(int metalModifier) //modifier of 2
        {
            metalModifier *= 2;
            return metalCredits.MetalCreds(metalModifier);
        }
    }

    public class Fabric
    {
        Creds fabricCreds = new Creds();
        public double Silk(double fabricModifier) // modifier of 4
        {
            fabricModifier *= 4;
            return fabricCreds.FabricCreds(fabricModifier);
        }
        
        public double Cotton(double fabricModifier) // modifier of 2
        {
            fabricModifier *= 2;
            return fabricCreds.FabricCreds(fabricModifier);
        }

        public double Linen(double fabricModifier) // no modifier
        {
            fabricModifier *= 1;
            return fabricCreds.FabricCreds(fabricModifier);
        }
    }

    public class Gemstones // base modifier of 6
    {
        Creds gemstoneCreds = new Creds();
        public int Diamond(int gemstoneModifier)  // base modifier of 4
        {
            gemstoneModifier *= 6;
            return gemstoneCreds.GemstoneCreds(gemstoneModifier);
        }

        public int Ruby(int gemstoneModifier) // base modifier of 3
        {
            gemstoneModifier *= 3;
            return gemstoneCreds.GemstoneCreds(gemstoneModifier);
        }

        public int Sapphire(int gemstoneModifier) // base modifier of 4
        {
            gemstoneModifier *= 4;
            return gemstoneCreds.GemstoneCreds(gemstoneModifier);
        }
    }

    public class Supplies // base modifier of 1
    {
        Creds supplyCreds = new Creds();
        public double Food(double supplyModifier) // no modifier
        {
            supplyModifier *= 1;
            return supplyCreds.FabricCreds(supplyModifier);
        }

        public double Water(double supplyModifier) // no modifier
        {
            supplyModifier *= 1;
            return supplyCreds.FabricCreds(supplyModifier);
        }

        public double Alcohol(double supplyModifier) // modifier of 2
        {
            supplyModifier *= 2;
            return supplyCreds.Supplies(supplyModifier);
        }

        public double Medicine(double supplyModifier) // modifier of 5
        {
            supplyModifier *= 5;
            return supplyCreds.Supplies(supplyModifier);
        }
    }
}
