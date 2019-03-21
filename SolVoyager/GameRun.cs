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
        TauCeti planetCeti = new TauCeti();
        PlanetDistance travelTime = new PlanetDistance();
        Ship playerShip = new Ship();

        public void Run()
        {
            string location = "Earth";
            bool check = true;
            // Opening page, with quit or start game option
            // Run Character Creation
            // Into buying your first resource to trade to another system
            // display the base prices for resources
            // slowly increase payloads with longer play, forced to start with 1 maybe 2 crates
            playerTrader.Gender();
            playerTrader.Name();
            Console.WriteLine("Which planet do you wish to start on?\nEarth\tTau Ceti\nMining Colony\tAlpha Centari");
            // begin journey on Earth
            while (check == true)
            {
                switch (location)
                {
                    case "Earth":
                        planetEarth.earthDisplay();
                        break;
                    case "Tau Ceti":
                        planetCeti.tauDisplay();
                        break;
                    case "Mining Colony":
                        planetColony.colonyDisplay();
                        break;
                    case "Alpha Centari":
                        planetCentari.alphaDisplay();
                        break;                    
                }

            }
        }
    }
}
