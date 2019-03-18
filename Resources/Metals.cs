using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency;

namespace Resources
{
    class Platinium
    {
        Creds metalCredits = new Creds();
        public int platBasePrice(int metalModifier) // platinium has a base modifer of 3
        {
            metalModifier *= 3;
            return metalCredits.MetalCreds(metalModifier);
        }
    }
    class Palladium
    {
        Creds metalCredits = new Creds();
        public int palladBasePrice(int metalModifier) //palladium has a base modifier of 4
        {
            metalModifier *= 4;
            return metalCredits.MetalCreds(metalModifier);
        }
    }
    class Titanium
    {
        Creds metalCredits = new Creds();
        public int titanBasePrice(int metalModifier) // titanium has a base modifer of 2
        {
            metalModifier *= 2;
            return metalCredits.MetalCreds(metalModifier);
        }
    }
}
