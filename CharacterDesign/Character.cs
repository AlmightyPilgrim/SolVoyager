using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesign
{
    public class Character
    {
        public string Gender(string x)
        {
            Console.WriteLine("What gender is your character?\n\t\t1 - Male\n\t\t2 - Female\n\t\tQ - Quit");
            x = Console.ReadLine();
            switch (x)
            {
                case "1":
                    Console.WriteLine("You are a Male, congratulations on being generic.");
                    break;
                case "2":
                    Console.WriteLine("You are a Female\n If you are a male IRL, you sir are weird");
                    break;
                case "Q":
                    Console.WriteLine("So I guess you didnt wanna play eh?");
                    break;
                default:
                    Console.WriteLine("Invalid Selection");               
                    break;
            }
                
            return x;
        }

        public string Hair(string y)
        {
            return y;
        }

        public string Eyes(string z)
        {
            return z;
        }

        public string Name(string name)
        {
            return name;
        }

        public void BackgroundMale()
        {

        }

        public void BackgroundFemale()
        {

        }

        public void StarterGemstone()
        {
        }
    }
}
