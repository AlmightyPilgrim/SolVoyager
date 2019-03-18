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
        public int silkBasePrice(int fabricModifier)
        {
            return fabricModifier;
        }
    }
    class Cotton
    {
        Creds fabricCreds = new Creds();
        public int cottonBasePrice(int fabricModifier)
        {
            return fabricModifier;
        }
    }
    class Linen
    {
        Creds fabricCreds = new Creds();
        public int cottonBasePrice(int fabricModifier)
        {
            return fabricModifier;
        }
    }
}
