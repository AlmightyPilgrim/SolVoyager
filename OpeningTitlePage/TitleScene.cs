using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeningTitlePage
{
    public class Title
    {

        int x, X, y, index, k, l;
        string s;
        ConsoleColor[] cl;
        ConsoleColor cl1, cl2;
        Random r;
        int iColor, nColor;
        public Title(string s, int x, int y)
        {
            this.x = x;
            this.y = y;
            X = x;
            k = 0;
            this.s = s;
            l = s.Length;
            index = l - 1;
            cl = new ConsoleColor[] { ConsoleColor.Magenta, ConsoleColor.Yellow, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Black, ConsoleColor.Green };
            nColor = cl.Length;
            cl1 = ConsoleColor.Black;
            cl2 = ConsoleColor.Green;
            r = new Random();
            iColor = 0;
        }
        public void ve()
        {

            Console.SetCursorPosition(X, y);
            for (int i = k; i < l; i++)
            {
                Console.ForegroundColor = cl1;
                if (i == index)
                {
                    Console.ForegroundColor = cl2;
                }

                Console.Write(s[i]);

            }

            if (index == k)
            {
                k++;
                X++;
                index = l;
            }
            if (k == l - 1)
            {
                k = 0;
                X = x;
                cl1 = cl2;
                cl2 = cl[iColor];
                iColor++;
                if (iColor == nColor)
                {
                    iColor = 0;
                }
            }
            index--;

        }

    }
}

     









        //public string Title(string x)
        //{ 
        //    bool check = false;
        //    while (check == false)
        //    {
        //        Console.Clear();
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        string text = " Sol Voyager";
        //        foreach (char c in text)
        //        {
        //            Console.Write(c);
        //            Thread.Sleep(50);
        //        }
        //        Console.WriteLine("What gender is your character?\n\t\t1 - Male\n\t\t2 - Female\n\t\tQ - Quit");
        //        x = Console.ReadLine();
        //        switch (x)
        //        {
        //            case "1":
        //                Console.WriteLine("You are a Male, congratulations on being generic.");
        //                check = true;
        //                break;
        //            case "2":
        //                Console.WriteLine("You are a Female\n If you are a male IRL, you sir are weird");
        //                check = true;
        //                break;
        //            case "Q":
        //                Console.WriteLine("So I guess you didnt wanna play eh?");
        //                check = true;
        //                break;
        //            default:
        //                Console.WriteLine("Invalid Selection");
        //                check = false;
        //                break;
        //        }
        //    }
        //    return x;
        }
    }
}
