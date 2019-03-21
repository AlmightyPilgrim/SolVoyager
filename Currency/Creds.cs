using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    public class Creds
    {
        int box = 10;

        public int MetalCreds(int chosenMetal) //metal gets a base modifier of 2
        {
            // crateNumber *= crate; --- This is or when number of crates are more than 1 (MIGHT NOT BE NECESSARY)
            int metal = box * 2;
            chosenMetal *= metal;
            return chosenMetal;
        }

        public double FabricCreds(double chosenFabric) // fabrics gets a base modifier of 1.5
        {
            double fabric = box * 1.5;
            chosenFabric *= fabric;
            return chosenFabric;
        }

        public int GemstoneCreds(int chosenGemstone) // gemstones get a base modifier of 6
        {
            int gemstone = box * 6;
            chosenGemstone *= gemstone;
            return chosenGemstone;
        }

        public double Supplies(double chosenSupply) // supplies gets a base modifier of 1
        {
            int supplies = box * 1;
            chosenSupply *= supplies;
            return chosenSupply;
        }

        public int Crates(int x) //method for number of crates to track amount then multiple amount before buying/ selling
        {
            int box = x;
            return x;
        }
    }
}
