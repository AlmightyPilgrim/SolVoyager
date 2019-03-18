using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency;

namespace Resources
{
    class Food
    {
        Creds supplyCreds = new Creds();
        public int foodBasePrice(int supplyModifier)
        {
            return supplyModifier;
        }
    }
    class Water
    {
        Creds supplyCreds = new Creds();
        public int waterBasePrice(int supplyModifier)
        {
            return supplyModifier;
        }
    }
    class Alcohol
    {
        Creds supplyCreds = new Creds();
        public int alcoBasePrice(int supplyModifier)
        {
            return supplyModifier;
        }
    }
    class Medicine
    {
        Creds supplyCreds = new Creds();
        public int mediBasePrice(int supplyModifier)
        {
            return supplyModifier;
        }
    }
}
