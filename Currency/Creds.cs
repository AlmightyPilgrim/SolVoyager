using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources;

namespace Currency
{
    public class Creds
    {

        int crate = 100; 
        public void MetalCreds() //metal gets a base modifier of 2
        {
            int metal = crate * 2;
        }

        public void FabricCreds() // fabrics gets a base modifier of 1.5
        {
            double fabric = crate * 1.5;
        }

        public void GemstoneCreds() // gemstones get a base modifier of 6
        {
            int gemstone = crate * 6;
        }

        public void Supplies() // supplies gets a base modifier of 1
        {
            int supplies = crate * 1;
        }
    }
}
