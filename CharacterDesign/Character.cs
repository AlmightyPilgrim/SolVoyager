using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vessel;

namespace CharacterDesign
{
    public class Character  // character's wallet is connected with the ship so is in the ship class
    {
        Ship warpAge = new Ship();
        string characterStart = "Earth";
        double age = Math.Round(20.00, 2);

        public void Gender()
        {            
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("What gender is your character?\n\t\t1 - Male\n\t\t2 - Female\n\t\tQ - Quit");
                string x = Console.ReadLine();
                switch (x)
                {
                    case "1":
                        Console.WriteLine("You are a Male, congratulations on being generic.");
                        BackgroundMale();
                        warpAge.playerWallet(10000);
                        check = true;
                        break;
                    case "2":
                        Console.WriteLine("You are a Female, yay diversity");
                        BackgroundFemale();
                        warpAge.playerWallet(10000);
                        check = true;
                        break;
                    case "Q":
                        Console.WriteLine("So I guess you didnt wanna play eh?, well thats too bad.");
                        warpAge.playerWallet(10000);
                        check = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        check = false;
                        break;
                }
            }
        }

        public string Name()
        {
            Console.WriteLine("Enter your characters name");
            string name = Console.ReadLine();
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
                Console.WriteLine("1. The Hustler | 2. The Playboy | 3. Average Guy");

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
                        Console.WriteLine("You have lived a normal life but have always had a longing to travel amongst the stars.  " +
                            "Your life is mediocre and you are an alright fellow.  Working hard all your life has presented you with many career opportunities." +
                            " You have worked diligently to get where you are in your career and have saved up enough money to buy a merchantile space ship." +
                            " With trouble at home with the wife, you now can leave to fulfill your long dream to travel in space...");
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
            bool check = false;
            do
            {
                Console.Clear();
                Console.WriteLine(" Character Origins");
                Console.WriteLine("\n------------------");

                Console.WriteLine("1.  | 2.  | 3. ");

                var select = Console.ReadLine();

                if (select == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Just a small town girl of very small stature living in a lonely world. " +
                        " Oddly, she has lived a normal and comfortable life despite her short comings. All that changed however," +
                        " when she ran away from home at the age of 15. She wandered Earth until she found her place amongst a traveling " +
                        "circus show. Now ten years later she is seeking a new dream to travel in space.  Your dream will soon become true " +
                        "as you have decided to stow away in a merchant space cargo ship. With a knife in hand you will soon be able to live your dreams.");
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
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You are just, reliable, and very level headed. This isn't too surprising considering someone in your position." +
                        "Born into a successful family in an important capital.You lived without worry until you were about 19 years old" +
                        "and had to move out of your parents' house. You have moved out and have made a lot of friends.With a great deal of determination," +
                        "You fulfilled your dreams in a large expanding world.There's nothing to stop you from climbing to the top. You have recently decided" +
                        "to try your hand in the space trading industry and have purchased a merchant ship. With a willingness to make it on your own it is now your time to explore and trade amongst the stars.");
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
                    Console.ForegroundColor = ConsoleColor.Magenta;
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
            } while (check == false);      
        }

        public void StarterGemstone()
        {
        }

        public string CharacterLocation(string input)
        {
            characterStart = input;
            return characterStart;
        }

        public double CharacterAge(double distance)
        {
            age += (distance / warpAge.WarpEquation());
            return Math.Round(age, 2);
        }
    }
}
