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
using RandomEvents;
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




            //        Title title = new Title("",0,0);
            //            Console.CursorVisible = false;
            //            string[] str = new string[] {"      0                    ",
            //                                     "0000 0   0   0 00000  00 00",
            //                                     "0     0  00  0 0      00 00",
            //                                     "0000 0 0 0 0 0 0 000  00 00",
            //                                     "   0 000 0  00 0   0  00 00",
            //                                     "0000 0 0 0   0 00000  00 00"};
            //            int n = str.Length;

            //            Title[] ET = new Title[n];
            //            int x, y;
            //            x = 15;
            //            y = 8;
            //            for (int i = 0; i < n; i++)
            //            {
            //                ET[i] = new Title(str[i], x, y + i);
            //            }

            //            while (true)
            //            {
            //                while (true)
            //                {
            //                    foreach (Title et in ET)
            //                    {
            //                        et.ve();
            //                    }
            //                }

            //            }
            //        }
            //    }
            //}
