using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency;

namespace Resources
{
    public class Metals // get a base modifier of 2
    {
        Creds metalCredits = new Creds();
        public void Platinium() // will have a modifier of 3
        {
            Console.WriteLine("One of the better metals available, not as rare as palladium, though better for different projects." +
                "The base modifier for platinium 3");
            int metalModifier = 3;
            metalCredits.MetalCreds(metalModifier);
        }

        public void Palladium() // will have a modifier of 4
        {
            int metalModifier = 4;
            metalCredits.MetalCreds(metalModifier);
        }

        public void Titanium()
        {
            int metalModifier = 2;
            metalCredits.MetalCreds(metalModifier);
        }
    }

    public class Fabric
    {
        Creds fabricCreds = new Creds();
        public void Silk() // modifier of 4
        {
            double fabricModifier = 4;
            fabricCreds.FabricCreds(fabricModifier);
        }
        
        public void Cotton() // modifier of 2
        {
            double fabricModifier = 2;
            fabricCreds.FabricCreds(fabricModifier);
        }

        public void Linen() // no modifier
        {
            double fabricModifier = 1;
            fabricCreds.FabricCreds(fabricModifier);
        }
    }

    public class Gemstones // base modifier of 6
    {
        Creds gemstoneCreds = new Creds();
        public void Diamond()  // base modifier of 4
        {
            int gemstoneModifier = 6;
            gemstoneCreds.GemstoneCreds(gemstoneModifier);
        }

        public void Ruby() // base modifier of 3
        {
            int supplyModifier = 3;
            gemstoneCreds.FabricCreds(supplyModifier);
        }

        public void Sapphire() // base modifier of 4
        {
            int supplyModifier = 4;
            gemstoneCreds.FabricCreds(supplyModifier);
        }
    }

    public class Supplies // base modifier of 1
    {
        Creds supplyCreds = new Creds();
        public void Food() // no modifier
        {
            double supplyModifier = 1;
            supplyCreds.FabricCreds(supplyModifier);
        }

        public void Water() // no modifier
        {
            double supplyModifier = 1;
            supplyCreds.FabricCreds(supplyModifier);
        }

        public void Alcohol() // modifier of 2
        {
            double supplyModifier = 2;
            supplyCreds.FabricCreds(supplyModifier);
        }

        public void Medicine() // modifier of 5
        {
            double supplyModifier = 5;
            supplyCreds.FabricCreds(supplyModifier);
        }
    }
}
