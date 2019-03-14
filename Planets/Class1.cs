using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources;
using Currency;

namespace Planets
{
    public class Earth // base modifiers: metal - 4, fabric - 3, gemstone - 5, supply- 2
    {                  // modifier increase: high +3, AA +2, Standard +-1, BA -2, low -3
        public int EarthMetals(int x) // high modifier
        {
            return x;
        }

        public double EarthFabric(double x) // low, if not fractional modifier
        {
            return x;
        }

        public int EarthGemstone(int x) // standard modifier
        {
            return x;
        }

        public int EarthSupply(int x) // below average modifier
        {
            return x;
        }
    }

    public class Mars
    {
        public int MarsMetals(int x) // above average modifier
        {
            return x;
        }

        public double MarsFabric(double x) // above average modifier
        {
            return x;
        }

        public int MarsGemstone(int x) // high modifier
        {
            return x;
        }

        public int MarsSupply(int x) // standard modifier
        {
            return x;
        }
    }   
    
    public class MiningColony
    {
        public int ColonyMetals(int x) // might have a negative modifier, or fractional
        {
            return x;
        }

        public double ColonyFabric(double x) // higher than average modifier
        {
            return x;
        }

        public int ColonyGemstone(int x) // below average modifier
        {
            return x;
        }

        public int ColonySupply(int x) // high modifier
        {
            return x;
        }
    }

    public class AlphaCentari
    {
        public int CentariMetals(int x) // standard modifier
        {
            return x;
        }

        public double CentariFabric(double x) // standard modifier
        {
            return x;
        }

        public int CentariGemstone(int x) // high modifier
        {
            return x;
        }

        public int CentariSupply(int x) // above average- modifier
        {
            return x;
        }
    }
}
