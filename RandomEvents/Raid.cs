using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomEvents
{

    public class Events
    {
        public string RandomEvents()
        {
            Random rnd = new Random();
            Console.WriteLine("You are traveling");

            string[] events = new string[] {"Go straight to planet", "Space raiders-take all your goods, ship damaged(repair cost)", "Raided-take half goods", "Asteroid hits ship(repair ship)",
            "Warp speed engine gives out(lose one year)", "Solar flare knocks out power(.5 year to repair ship)", "Find abandoned trade vessel(500 creds)", "Rescue ship members, proceed to destination",
            "Eat a bad space burrito. You have a bad night. Proceed to destination.", "Find space wreckage. Nothing recovered :(", "Find space wreckage (Recover 1 crate of Palladium)",
            "Find abondoned ship. One of your shipmates is killed searching the wreckage. You must hire another shipmate(Cost 500 creds)", "Proceed to destination", "Keep on trucking",
            "Safe Travels", "You're on your way to greatness", "You took a wrong turn. Return back to previous destination...Check the coordinates next time", "Entered the wrong coordinates (Lose .5 a year)",
            "Can't seem to find your lucky socks...hmmm must be space gnomes", "Space twister in zero gravity = family fun night...Continue to destination"};
          

            return events[rnd.Next(0, events.Length)];

            
        }
    }  
}

