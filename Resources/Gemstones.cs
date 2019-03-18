using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency;

namespace Resources
{
    class Diamond
    {
        Creds gemstoneCreds = new Creds();
        public int diaBasePrice(int gemModifier) // base mod of 6
        {
            gemModifier *= 6;
            return gemstoneCreds.GemstoneCreds(gemModifier);
        }
    }
    class Ruby
    {
        Creds gemstoneCreds = new Creds();
        public int rubyBasePrice(int gemModifier) // base mod of 3
        {
            gemModifier *= 3;
            return gemstoneCreds.GemstoneCreds(gemModifier);
        }
    }
    class Sapphire
    {
        Creds gemstoneCreds = new Creds();
        public int sappBasePrice(int gemModifier) // base mod of 4
        {
            gemModifier *= 4;
            return gemstoneCreds.GemstoneCreds(gemModifier);
        }
    }
}
