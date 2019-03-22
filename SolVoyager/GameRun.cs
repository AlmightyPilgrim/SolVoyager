using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planets;
using Vessel;
using CharacterDesign;


namespace SolVoyager
{
    public class GameRun
    {
        Character playerTrader = new Character();
        Earth planetEarth = new Earth();
        MiningColony planetColony = new MiningColony();
        AlphaCentari planetCentari = new AlphaCentari();
        TauCeti planeCeti = new TauCeti();
        Ship playerShip = new Ship();

        public void Run()
        {
            // Opening page, with quit or start game option
            // Run Character Creation
            // Into buying your first resource to trade to another system
            // display the base prices for resources
            // slowly increase payloads with longer play, forced to start with 1 maybe 2 crates
            //playerTrader.Gender();
            //playerTrader.Name();
        }
    }
}
