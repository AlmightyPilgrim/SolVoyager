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
                        Console.WriteLine("You have brown hair.");
                        check = true;
                        break;
                    case "2":
                        Console.WriteLine("You have scarlett hair.");
                        check = true;
                        break;
                    case "3":
                        Console.WriteLine("You have black hair.");
                        check = true;
                        break;
                    case "4":
                        Console.WriteLine("You have white hair.");
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
                        Console.WriteLine("You have brown eyes.");
                        check = true;
                        break;
                    case "2":
                        Console.WriteLine("You have red eyes.");
                        check = true;
                        break;
                    case "3":
                        Console.WriteLine("You have blue eyes.");
                        check = true;
                        break;
                    case "4":
                        Console.WriteLine("You have grey eyes.");
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
            bool check = false;
            do
            {
                Console.Clear();
                Console.Write(" Character Origins");
                Console.WriteLine("------------------");
                Console.WriteLine("1. The Hustler | 2. The Playboy | 3. ");

                var select = Console.ReadLine();

                if (select == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Born an orphan into the dark slums previously known as the great City of New York." +
                        "\nYou have only known pain and suffering as you struggled to survive each and every day. " +
                        "Taken in by a family destroyed by the \"Veggious Plague," + "you lived a troubled childhood" +
                        " hustling and trading whatever you could for food.  Your years of hardship have led you " +
                        "to become the most well-known hustler in the slums of NYC. " +
                        "Recently, you acquired a merchant ship to a mis-placed former client. " +
                        "Eager to escape and explore the stars you forever looked too in your youth. " +
                        "You now prepare for your journey to travel and trade amongst the stars.");
                    Console.ResetColor();

                    Console.WriteLine("\nB: Back | Enter: Select Character");
                    var selectCharacter = Console.ReadLine();

                    if (selectCharacter == "b")
                    {
                        check = false;
                    }

                    if (selectCharacter == "Enter")
                    {
                    check = true;
                    }
                }
                else if (select == "2")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Born into a priveledged merchantile-family prominently known for " +
                        "trading amongst the stars. You have lived a luxurious playboy lifestyle. However, your father" +
                        " is terminally ill and you are the sole heir to the family business. Struck by the sudden loss" +
                        " of your father and betrayal from the board, you are only left with enough money to acquire" +
                        " an old space merchantile vessel.  It is now up to you to regain your family's honor and restore" +
                        " the your name by rebuilding the empire taken from you.");
                    Console.ResetColor();
                    Console.WriteLine("\nB: Back | Enter: Select Character");
                    var selectCharacter = Console.ReadLine();

                    if (selectCharacter == "b")
                    {
                        check = false;
                    }

                    if (selectCharacter == "Enter")
                    {
                    

                        check = true;
                    }

                }

                else if (select == "3")
                {
                    Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("story");
                        Console.ResetColor();
                        Console.WriteLine("\nB: Back | Enter: Select Character");
                        var selectCharacter = Console.ReadLine();

                    if (selectCharacter == "b")
                    {
                        check = false;
                    }

                    if (selectCharacter == "Enter")
                    {
                        check = true;
                    }

                }
            }while (check == false);

        }

        public void BackgroundFemale()
        {

        }

        public void StarterGemstone()
        {
        }
    }
}
