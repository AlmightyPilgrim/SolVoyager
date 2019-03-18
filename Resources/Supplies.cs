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
        public double foodBasePrice(int supplyModifier) // no mod
        {
            supplyModifier *= 1;
            return supplyCreds.FabricCreds(supplyModifier);
        }
    }
    class Water
    {
        Creds supplyCreds = new Creds(); // no mod
        public double waterBasePrice(int supplyModifier)
        {
            supplyModifier *= 1;
            return supplyCreds.FabricCreds(supplyModifier);
        }
    }
    class Alcohol
    {
        Creds supplyCreds = new Creds(); // mod of 2
        public double alcoBasePrice(int supplyModifier)
        {
            supplyModifier *= 2;
            return supplyCreds.FabricCreds(supplyModifier);
        }
    }
    class Medicine
    {
        Creds supplyCreds = new Creds();
        public double mediBasePrice(int supplyModifier) // mod of 5
        {
            supplyModifier *= 5;
            return supplyCreds.FabricCreds(supplyModifier);
        }
    }
}
