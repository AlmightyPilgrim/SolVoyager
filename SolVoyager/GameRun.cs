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
            location = Console.ReadLine();
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
                default:
                    Console.WriteLine("Invalid Entry");
                    // terminate program
                    break;
            }
            // begin journey on Earth
            while (check == true)
            {
                Console.Clear();
                Console.Write("Travel to new location:");
                switch (location)
                {
                    case "Earth":
                        Console.WriteLine("Select new planet\nTau Ceti (11.89 light years)\n" +
                            "Mining Colony (7.65 light years)\nAlpha Centari (4.3 light years)");
                        location = Console.ReadLine();
                        switch (location)
                        {
                            case "Tau Ceti":
                                travelTime.EarthtoTauCeti();
                                playerTrader.CharacterAge(travelTime.EarthtoTauCeti());
                                
                                break;
                            case "Mining Colony":
                                travelTime.EarthtoColony();
                                playerTrader.CharacterAge(travelTime.EarthtoColony());

                                break;
                            case "Alpha Centari":
                                travelTime.EarthtoCentari();
                                playerTrader.CharacterAge(travelTime.EarthtoCentari());

                                break;
                        }
                        break;
                    case "Tau Ceti":
                        Console.WriteLine("Select new planet\nEarth\n" +
                                "Mining Colony\nAlpha Centari");
                        location = Console.ReadLine();
                        switch (location)
                        {
                            case "Earth":
                                travelTime.EarthtoTauCeti();
                                playerTrader.CharacterAge(travelTime.EarthtoTauCeti());

                                break;
                            case "Mining Colony":
                                travelTime.EarthtoColony();
                                playerTrader.CharacterAge(travelTime.EarthtoColony());

                                break;
                            case "Alpha Centari":
                                travelTime.EarthtoCentari();
                                playerTrader.CharacterAge(travelTime.EarthtoCentari());

                                break;
                        }
                        break;
                    case "Mining Colony":
                        Console.WriteLine("Select new planet\nTau Ceti\n" +
                                "Earth\nAlpha Centari");
                        location = Console.ReadLine();
                        switch (location)
                        {
                            case "Tau Ceti":
                                travelTime.EarthtoTauCeti();
                                playerTrader.CharacterAge(travelTime.EarthtoTauCeti());

                                break;
                            case "Earth":
                                travelTime.EarthtoColony();
                                playerTrader.CharacterAge(travelTime.EarthtoColony());

                                break;
                            case "Alpha Centari":
                                travelTime.EarthtoCentari();
                                playerTrader.CharacterAge(travelTime.EarthtoCentari());

                                break;
                        }
                        break;
                    case "Alpha Centari":
                        Console.WriteLine("Select new planet\nTau Ceti\n" +
                                "Mining Colony\nEarth");
                        location = Console.ReadLine();
                        switch (location)
                        {
                            case "Tau Ceti":
                                travelTime.EarthtoTauCeti();
                                playerTrader.CharacterAge(travelTime.EarthtoTauCeti());

                                break;
                            case "Mining Colony":
                                travelTime.EarthtoColony();
                                playerTrader.CharacterAge(travelTime.EarthtoColony());

                                break;
                            case "Earth":
                                travelTime.EarthtoCentari();
                                playerTrader.CharacterAge(travelTime.EarthtoCentari());

                                break;
                        }
                        break;
                }
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
