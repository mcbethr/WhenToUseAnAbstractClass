using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    public class Route
    {
        List<int> _RouteLegs;

        public List<int> RouteLegs { get { return _RouteLegs; } }

        public int RouteDistance { get {return SumRoute(); } }

        public Route()
        {
            _RouteLegs = new List<int>();
        }

        private int SumRoute()
        {
            return _RouteLegs.Sum();
        }

        public void AddLeg(int Leg)
        {
            _RouteLegs.Add(Leg);
        }

        public bool CheckETOPSAganstRoute(int ETOPS)
        {
            ///always returns true for this example
            return true;
        }

        //return true for now.
        public bool CheckFuelAgainstRoute(int Gallons, int GallonsPerMile)
        {
            int RouteDistance = SumRoute();
            int FlightRange = Gallons / GallonsPerMile;

            if (RouteDistance < FlightRange)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
