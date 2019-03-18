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
        public int diaBasePrice(int gemModifier)
        {
            return gemModifier;
        }
    }
    class Ruby
    {
        Creds gemstoneCreds = new Creds();
        public int rubyBasePrice(int gemModifier)
        {
            return gemModifier;
        }
    }
    class Sapphire
    {
        Creds gemstoneCreds = new Creds();
        public int sappBasePrice(int gemModifier)
        {
            return gemModifier;
        }
    }
}
