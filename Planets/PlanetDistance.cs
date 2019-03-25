using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomEvents;

namespace Planets
{
    public class PlanetDistance
    {
        Earth earthLocation = new Earth();
        TauCeti tauLocation = new TauCeti();
        MiningColony colonyLocation = new MiningColony();
        AlphaCentari centariLocation = new AlphaCentari();
        Events randomEvent = new Events();

        public double EarthtoTauCeti()
        {
            double distance = tauLocation.TauCetiLocation() - earthLocation.EarthLocation();
            return distance;
        }

        public double EarthtoColony()
        {
            double distance = colonyLocation.ColonyLocation() - earthLocation.EarthLocation();
            return distance;
        }

        public double EarthtoCentari()
        {
            double distance = centariLocation.AlphaLocation() - earthLocation.EarthLocation();
            return distance;
        }

        public double TauCetitoColony()
        {
            double distance = tauLocation.TauCetiLocation() - colonyLocation.ColonyLocation();
            return distance;
        }

        public double TauCetitoCentari()
        {
            double distance = tauLocation.TauCetiLocation() - centariLocation.AlphaLocation();
            return distance;
        }

        public double ColonytoCentari()
        {
            double distance = colonyLocation.ColonyLocation() - centariLocation.AlphaLocation();
            return distance;
        }
    }
}
