using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency;
using Resources;
using Planets;
using Vessel;
using CharacterDesign;
using RandomEvents;
using OpeningTitlePage;
using Figgle;

namespace SolVoyager
{
    class Program
    {
        static void Main(string[] args)
        { 
            GameRun playRun = new GameRun();
            playRun.Run();
        }
    }
}