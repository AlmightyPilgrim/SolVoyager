using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeningTitlePage
{
    public class Title
    {
        void CenteredString(string s)
        {
            s = "00000  000000  0"+
               " 0     0    0   0"+
               " 00000 0    0  0"+
               "     0 0    0  0"+
               "00000  000000  000000"+
                 "0   0 00000 0   0  0    00000  00000  00000"+
                 "0   0 0   0 0   0 0  0  0      0      0    0"+
                 "0   0 0   0   0  000000 0  000 00000  00000"+
                  "0 0  0   0   0  0    0 0    0 0      0    0"+
                   "0   00000   0  0    0 000000 00000  0     0";
            if (s.Length <= Console.WindowWidth)
            {
                Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                Console.WriteLine(s);
            }
            else
            {
                throw new Exception("Oversided String");
            }
        }


    }
}





//public void Opener()
//{
//    bool check = false;
//    do
//    {
//        Console.WriteLine("00000  000000  0",
//                         " 0     0    0   0",
//                         " 00000 0    0  0",
//                         "     0 0    0  0",
//                         "00000  000000  000000",
//                          "0   0 00000 0   0  0    00000  00000  00000",
//                          "0   0 0   0 0   0 0  0  0      0      0    0",
//                          "0   0 0   0   0  000000 0  000 00000  00000",
//                           "0 0  0   0   0  0    0 0    0 0      0    0",
//                            "0   00000   0  0    0 000000 00000  0     0");
//        Console.WriteLine("Press Enter to continue...");
//        var x = Console.ReadLine();

//        if (x == "Enter")
//        {
//            check = true;
//        }

//    } while (check == false);
//}





