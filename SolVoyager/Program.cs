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
            int y = 1;
            Character testCharacter = new Character();
            testCharacter.BackgroundMale();
            Metals testMetals = new Metals();
            testMetals.Platinium();
            
            testCharacter.Gender(x);
            testCharacter.Eyes(x);
            testCharacter.Name(x);
        }
    }
}
