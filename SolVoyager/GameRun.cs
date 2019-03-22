using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planets;
using Vessel;
using CharacterDesign;
using OpeningTitlePage;


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
        Title openTitle = new Title();

        // variables for the vessel hold storage
        public void Run()
        {
            string location = "Earth";
            bool check = true;
            openTitle.CenteredString();
            // Opening page, with quit or start game option
            // Run Character Creation
            // Into buying your first resource to trade to another system
            // display the base prices for resources
            // slowly increase payloads with longer play, forced to start with 1 maybe 2 crates
            playerTrader.Gender();
            playerTrader.Name();
            Console.WriteLine($"{playerTrader.CharacterAge(0)} years old, and only have a ship and 500 credits to your name.");
            Console.WriteLine("Which planet do you wish to start on?\nEarth\tTau Ceti\nMining Colony\tAlpha Centari");
            location = Console.ReadLine();
            switch (location)
            {
                case "Earth":
                    playerShip.playerWallet(0);
                    planetEarth.earthDisplay(playerShip);
                    break;
                case "Tau Ceti":
                    playerShip.playerWallet(0);
                    planetCeti.tauDisplay(playerShip);
                    break;
                case "Mining Colony":
                    planetColony.colonyDisplay(playerShip);
                    break;
                case "Alpha Centari":
                    playerShip.playerWallet(0);
                    planetCentari.alphaDisplay(playerShip);
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    // terminate program
                    break;
            }
            // problem with the inventory system, not maintaining the inventory when moving to a new planet
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
                                Console.WriteLine($"{playerTrader.CharacterAge(0)} years old");
                                break;
                            case "Mining Colony":
                                travelTime.EarthtoColony();
                                playerTrader.CharacterAge(travelTime.EarthtoColony());
                                Console.WriteLine($"{playerTrader.CharacterAge(0)} years old");
                                break;
                            case "Alpha Centari":
                                travelTime.EarthtoCentari();
                                playerTrader.CharacterAge(travelTime.EarthtoCentari());
                                Console.WriteLine($"{playerTrader.CharacterAge(0)} years old");
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
                                Console.WriteLine($"{playerTrader.CharacterAge(0)} years old");
                                break;
                            case "Mining Colony":
                                travelTime.EarthtoColony();
                                playerTrader.CharacterAge(travelTime.EarthtoColony());
                                Console.WriteLine($"{playerTrader.CharacterAge(0)} years old");
                                break;
                            case "Alpha Centari":
                                travelTime.EarthtoCentari();
                                playerTrader.CharacterAge(travelTime.EarthtoCentari());
                                Console.WriteLine($"{playerTrader.CharacterAge(0)} years old");
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
                                Console.WriteLine($"{playerTrader.CharacterAge(0)} years old");
                                break;
                            case "Earth":
                                travelTime.EarthtoColony();
                                playerTrader.CharacterAge(travelTime.EarthtoColony());
                                Console.WriteLine($"{playerTrader.CharacterAge(0)} years old");
                                break;
                            case "Alpha Centari":
                                travelTime.EarthtoCentari();
                                playerTrader.CharacterAge(travelTime.EarthtoCentari());
                                Console.WriteLine($"{playerTrader.CharacterAge(0)} years old");
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
                                Console.WriteLine($"{playerTrader.CharacterAge(0)} years old");
                                break;
                            case "Mining Colony":
                                travelTime.EarthtoColony();
                                playerTrader.CharacterAge(travelTime.EarthtoColony());
                                Console.WriteLine($"{playerTrader.CharacterAge(0)} years old");
                                break;
                            case "Earth":
                                travelTime.EarthtoCentari();
                                playerTrader.CharacterAge(travelTime.EarthtoCentari());
                                Console.WriteLine($"{playerTrader.CharacterAge(0)} years old");
                                break;
                        }
                        break;
                }
                switch (location)
                {
                    case "Earth":
                        planetEarth.earthDisplay(playerShip);
                        break;
                    case "Tau Ceti":
                        planetCeti.tauDisplay(playerShip);
                        break;
                    case "Mining Colony":
                        planetColony.colonyDisplay(playerShip);
                        break;
                    case "Alpha Centari":
                        planetCentari.alphaDisplay(playerShip);
                        break;                    
                }

                Console.WriteLine("Do you wish to go to contine? y/n");
                string answer = Console.ReadLine();
                if (answer == "y")
                {

                }
                else
                {
                    check = false;
                }
            }
        }
    }
}
