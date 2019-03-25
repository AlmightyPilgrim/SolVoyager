using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vessel;

namespace RandomEvents
{

    public class Events
    {
        Ship vesselhold;
        public double RandomEvents(int y, Ship playerShip)  // x and y are just holder type values to make code work
        {
            //Random event generator that chooses event and returns result
            vesselhold = playerShip;
            string repair1 = "Space raiders board and damage ship (repair cost -250 creds)";
            string repair2 = "Asteroid hits ship(-250 creds to repair ship)";
            string repair3 = "Warp speed engine gives out(repair cost -500 creds)";
            string repair4 = "Solar flare knocks out power(-300 creds to repair ship)";
            string goodsTaken = "Raided-take half goods";
            string recoverGoods = "Find abandoned trade vessel(500 creds)";
            string foundPalladium1 = "Find space wreckage (Recover 1 crate of Palladium)";
            string foundPalladium2 = "Found 1 crate of Palladium hidden in cargo area (+1 Palladium)";
            string hireMate = "Find abondoned ship. One of your shipmates is killed searching the wreckage. You must hire another shipmate(Cost 500 creds)";

            Random rnd = new Random();
            Console.WriteLine("You are traveling");

            string[] events = new string[] {"Go straight to planet", $"{repair1}", $"{goodsTaken}", $"{repair2}",
            $"{repair3}", $"{repair4}", $"{recoverGoods}", "Rescue ship members, proceed to destination",
            "Eat a bad space burrito. You have a bad night. Proceed to destination.", "Find space wreckage. Nothing recovered :(", $"{foundPalladium1}",
            $"{hireMate}", "Proceed to destination", "Keep on trucking",
            "Safe Travels", "You're on your way to greatness", "You took a wrong turn...Check the coordinates next time", $"{foundPalladium2}",
            "Can't seem to find your lucky socks...hmmm must be space gnomes", "Space twister in zero gravity = family fun night...Continue to destination"};


            Console.WriteLine(events[rnd.Next(0, events.Length)]);
            var result = Console.ReadLine();

            if (result.Contains(repair1))
            {
                //-250 creds to wallet
                Console.WriteLine($"{repair1}");
                double x = vesselhold.playerWallet(-250);
                return x;
            }

            else if (result.Contains(repair2))
            {
                //-250 creds to wallet
                Console.WriteLine($"{repair2}");
                double x = vesselhold.playerWallet(-250);
                return x;
            }
            else if (result.Contains(repair3))
            {
                //-500 creds to wallet
                Console.WriteLine($"{repair3}");
                double x = vesselhold.playerWallet(-500);
                return x;
            }
            else if (result.Contains(repair4))
            {
                //-300 creds wallet
                Console.WriteLine($"{repair4}");
                double x = vesselhold.playerWallet(-300);
                return x;
            }

            else if (result.Contains(goodsTaken))
            {
                // half goods taken
                Console.WriteLine($"{goodsTaken}");
                double x = vesselhold.Capacity(-10);
                return x;
            }
            else if (result.Contains(recoverGoods))
            {
                // +500 creds to wallet
                Console.WriteLine($"{recoverGoods}");
                double x = vesselhold.playerWallet(500);
                return x;
            }
            else if (result.Contains(foundPalladium1))
            {
                // +1 palladium crate
                Console.WriteLine($"{foundPalladium1}");
                int x = vesselhold.palladCrate(1);
                return x;
            }
            else if (result.Contains(foundPalladium2))
            {
                //+1 palladium crate
                Console.WriteLine($"{foundPalladium2}");
                int x = vesselhold.palladCrate(1);
                return x;
            }
            else if (result.Contains(hireMate))
            {
                // -500 creds wallet
                Console.WriteLine($"{hireMate}");
                double x = vesselhold.playerWallet(-500);
                return x;
            }
            return y;
        }
    }  
}

