using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency;
using Resources;
using PlanetsResources;
using Warp;
using Vessel;
using CharacterDesign;
using OpeningTitlePage;

namespace SolVoyager
{
    class Program
    {
        static void Main(string[] args)
        {
            TitleScene testTitle = new TitleScene();
            AlphaCentari testEarth = new AlphaCentari();
            testEarth.CentariMetals(12);
            testEarth.CentariFabric(1);
            testEarth.CentariGemstone(1);
            testEarth.CentariSupply(1);
        }
    }
}
