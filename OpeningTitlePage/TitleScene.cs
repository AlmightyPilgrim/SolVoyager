using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;


namespace OpeningTitlePage
{
    public class Title
    {
       public void OpeningTitle()
        {
            Console.WriteLine(FiggleFonts.Graffiti.Render("Sol Voyager"));
          
        }
    }
}


//if (s.Length <= Console.WindowWidth)
//          {
//              Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
//              Console.WriteLine(s);
//          }

//          else
//          {
//              throw new Exception();
//          }

