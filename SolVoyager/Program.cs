using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency;
using Resources;
using Planets;
using Warp;
using Vessel;
using CharacterDesign;

namespace SolVoyager
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "blah";
            var y = 1;
            Character testCharacter = new Character();
            testCharacter.BackgroundMale();
            testCharacter.Gender(x);
            testCharacter.Eyes(x);
            testCharacter.Name(x);
        }
    }
}
