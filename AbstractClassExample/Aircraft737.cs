using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.OldWay
{
    public class Aircraft737
    {
        private int _ETOPS = 120;
        private int _FuelCapacityInGallons = 10707;
        private int _GallonsPerMinuteInFlight = 12;
        private int _GallonsPerMiunteIdle= 3;
        public int ETOPS { get { return _ETOPS; } }
        public int FuelCapacity { get { return _FuelCapacityInGallons; } }

        public int GallonsPerMinuteInFlight {  get { return _GallonsPerMinuteInFlight; } }

        public int WeightCapacityCheck()
        {
            //Fake - This is a placeholder
            return 0;
        }

        public bool CrewCheck()
        {
            //Fake - This is a placeholder
            return true;
        }

        public bool ManifestCheck()
        {
            //Fake - This is a placeholder
            return true;
        }

        /// <summary>
        /// Check to see if you have enough fuel to complete the route 
        /// Plus diversion, Reserve, contingincy and Taxi fuel.
        /// </summary>
        /// <param name="FlightRoute"></param>
        /// <returns></returns>
        public bool PerformFuelCheck(Route FlightRoute)
        {
            
            return true;
        }

        //Checks ETOPS rules against flight route and makes sure that
        // the trip confirms to ETOPS rules
        //  Extended-range Twin-engine Operations Performance Standards
        public bool CheckETOPSRules(Route FlightRoute)
        {

            return FlightRoute.CheckETOPSAganstRoute(ETOPS);

        }

        public TimeSpan CalculateFlightTime(DateTime TakeOffTime, DateTime LandingTime)
        {
            ///Note that planes burn about 2.64 gallons per minute of fuel while idling
            ///With a fuel cost of 4.77 gallons, you want them idling as litte as possible.

            TimeSpan FlightTime = LandingTime - TakeOffTime;

            return FlightTime;
        }

    }
}
