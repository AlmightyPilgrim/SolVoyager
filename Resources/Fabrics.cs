using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency;

namespace Resources
{
    class Silk
    {
        Creds fabricCreds = new Creds();
        public double silkBasePrice(int fabricModifier) // modifier of 4
        {
            fabricModifier *= 4;
            return fabricCreds.FabricCreds(fabricModifier);
        }
    }
    class Cotton
    {
        Creds fabricCreds = new Creds(); // modifer of 2
        public double cottonBasePrice(int fabricModifier)
        {
            fabricModifier *= 2;
            return fabricCreds.FabricCreds(fabricModifier);
        }
    }
    class Linen
    {
        Creds fabricCreds = new Creds(); // no modifier
        public double cottonBasePrice(int fabricModifier)
        {
            fabricModifier *= 1;
            return fabricCreds.FabricCreds(fabricModifier);
        }
    }
}
