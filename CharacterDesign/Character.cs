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
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("What gender is your character?\n\t\t1 - Male\n\t\t2 - Female\n\t\tQ - Quit");
                x = Console.ReadLine();
                switch (x)
                {
                    case "1":
                        Console.WriteLine("You are a Male, congratulations on being generic.");
                        check = true;
                        break;
                    case "2":
                        Console.WriteLine("You are a Female\n If you are a male IRL, you sir are weird");
                        check = true;
                        break;
                    case "Q":
                        Console.WriteLine("So I guess you didnt wanna play eh?");
                        check = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        check = false;
                        break;
                }
            }   
            return x;
        }

        public string Hair(string y)
        {
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("Character hair color:\n1 - Brown\t2 - Scarlett\n3 - Black\t4 - White");
                y = Console.ReadLine();
                switch (y)
                {
                    case "1":
                        check = true;
                        break;
                    case "2":
                        check = true;
                        break;
                    case "3":
                        check = true;
                        break;
                    case "4":
                        check = true;
                        break;
                    default:
                        Console.WriteLine("Sorry if your favorite eye color is not available");
                        check = false;
                        break;
                }
            }
            return y;
        }

        public string Eyes(string z)
        {
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("Character Eye color:\n1 - Brown\t2 - Red\n3 - Blue\t4 - Grey");
                z = Console.ReadLine();
                switch (z)
                {
                    case "1":
                        check = true;
                        break;
                    case "2":
                        check = true;
                        break;
                    case "3":
                        check = true;
                        break;
                    case "4":
                        check = true;
                        break;
                    default:
                        Console.WriteLine("Sorry if your favorite eye color is not available");
                        check = false;
                        break;
                }
            }
            return z;
        }

        public string Name(string name)
        {
            Console.WriteLine("Enter your characters name");
            name = Console.ReadLine();
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
