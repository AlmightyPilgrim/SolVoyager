using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    public class Creds
    {
        int crate = 100; 
        public int MetalCreds(int chosenMetal) //metal gets a base modifier of 2
        {
            int metal = crate * 2;
            chosenMetal *= metal;
            return chosenMetal;
        }

        public double FabricCreds(double chosenFabric) // fabrics gets a base modifier of 1.5
        {
            double fabric = crate * 1.5;
            chosenFabric *= fabric;
            return chosenFabric;
        }

        public int GemstoneCreds(int chosenGemstone) // gemstones get a base modifier of 6
        {
            int gemstone = crate * 6;
            chosenGemstone *= gemstone;
            return chosenGemstone;
        }

        public double Supplies(double chosenSupply) // supplies gets a base modifier of 1
        {
            int supplies = crate * 1;
            chosenSupply *= supplies;
            return chosenSupply;
        }
    }
}
