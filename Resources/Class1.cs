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

    public class Gemstones
    {
        public void Diamond()
        {

        }

        public void Ruby()
        {

        }

        public void Sapphire()
        {

        }
    }

    public class Supplies
    {
        public void Food()
        {

        }

        public void Water()
        {

        }

        public void Alcohol()
        {

        }

        public void Medicine()
        {

        }
    }
}
