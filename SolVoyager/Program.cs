﻿using System;
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
using RandomEvents;

namespace SolVoyager
{
    class Program
    {
        static void Main(string[] args)
        {
            Events testEvents = new Events();
            testEvents.RandomNumber();
            WarpSpeed testWarp = new WarpSpeed();
            testWarp.WarpEquation(5);
            string x = "blah";
            int y = 1;
            Character testCharacter = new Character();
            testCharacter.BackgroundMale();
            Metals testMetals = new Metals();
            testMetals.Platinium();
            y+=1;
            testCharacter.Gender(x);
            testCharacter.Eyes(x);
            testCharacter.Name(x);
        }
    }
}
