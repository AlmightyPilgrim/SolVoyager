using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency;
using Resources;
using Planets;
using Warp;
using Vessel;
using CharacterDesign;

namespace SolVoyager
{
    class Program
    {
        static void Main(string[] args)
        {
            AlphaCentari testEarth = new AlphaCentari();
            testEarth.CentariMetals(12);
            testEarth.CentariFabric(1);
            testEarth.CentariGemstone(1);
            testEarth.CentariSupply(1);
        }
    }
}
