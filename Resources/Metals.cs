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
        public int platBasePrice(int metalModifier)
        {
            return metalModifier;
        }
    }
    class Palladium
    {
        Creds metalCredits = new Creds();
        public int palladBasePrice(int metalModifier)
        {
            return metalModifier;
        }
    }
    class Titanium
    {
        Creds metalCredits = new Creds();
        public int titanBasePrice(int metalModifier)
        {
            return metalModifier;
        }
    }
}
