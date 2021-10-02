using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.OldWay
{
    public class Aircraft
    {
        private int _ETOPS = 120;
        private int _FuelCapacityInGallons = 10707;
        private int _GallonsPerMinuteInFlight = 12;
        private int _GallonsPerMinuteIdle = 3;
        private General.WakeTurbulenceCategoryEnum _WakeTurbulenceCategory = 
                General.WakeTurbulenceCategoryEnum.MEDIUM;

        public int ETOPS { get { return _ETOPS; } }
        public int FuelCapacity { get { return _FuelCapacityInGallons; } }

        public int GallonsPerMinuteInFlight { get { return _GallonsPerMinuteInFlight; } }

        public int GallonsPerMinuteIdle { get { return _GallonsPerMinuteIdle; } }

        public General.WakeTurbulenceCategoryEnum WakeTurbulenceCategory 
            {get {return _WakeTurbulenceCategory;} }

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

        public bool JetEngineCheck()
        {
            //Fake- This is a placeholder
            return true;
        }

        public bool TrimWheelCheck()
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

        public TimeSpan CalculateFlightTimeWithIdle(DateTime TakeOffTime, DateTime LandingTime, 
                General.WakeTurbulenceCategoryEnum PreceedingAircraft )
        {
   

            TimeSpan FlightTime = LandingTime - TakeOffTime;
            FlightTime = FlightTime + CalculateWakeTurbulenceWait(PreceedingAircraft);

            return FlightTime;
        }

        private TimeSpan CalculateWakeTurbulenceWait(General.WakeTurbulenceCategoryEnum Preceeding)
        {
            switch (Preceeding) 
            {
                case General.WakeTurbulenceCategoryEnum.SUPER:
                        return new TimeSpan(0,4,0);
                case General.WakeTurbulenceCategoryEnum.HEAVY:
                    return new TimeSpan(0, 4, 0);
                case General.WakeTurbulenceCategoryEnum.MEDIUM:
                    return new TimeSpan(0, 3, 0);
                case General.WakeTurbulenceCategoryEnum.SMALL:
                    return new TimeSpan(0, 2, 0);
                default:
                    return new TimeSpan(0, 2, 0); 
            }
        }

    }

    public class Aircraft757
    {
        private int _ETOPS = 180;
        private int _FuelCapacityInGallons = 11276;
        private int _GallonsPerMinuteInFlight = 18;
        private int _GallonsPerMinuteIdle = 3;
        private General.WakeTurbulenceCategoryEnum _WakeTurbulenceCategory =
        General.WakeTurbulenceCategoryEnum.HEAVY;

        public General.WakeTurbulenceCategoryEnum WakeTurbulenceCategory
        { get { return _WakeTurbulenceCategory; } }
        public int ETOPS { get { return _ETOPS; } }
        public int FuelCapacity { get { return _FuelCapacityInGallons; } }

        public int GallonsPerMinuteInFlight { get { return _GallonsPerMinuteInFlight; } }
        public int GallonsPerMinuteIdle { get { return _GallonsPerMinuteIdle; } }
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

        ///WE don't need this in a 757
        public bool TrimWheelCheck()
        {
            //Fake - This is a placeholder
            return true;
        }

        public bool JetEngineCheck()
        {
            //Fake- This is a placeholder
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

    public class BeachCraft
    {
        private int _ETOPS = 60;
        private int _FuelCapacityInGallons = 200;
        private int _GallonsPerMinuteInFlight = 2;
        private int _GallonsPerMinuteIdle = 1;

        private General.WakeTurbulenceCategoryEnum _WakeTurbulenceCategory =
            General.WakeTurbulenceCategoryEnum.SMALL;

        public General.WakeTurbulenceCategoryEnum WakeTurbulenceCategory
        { get { return _WakeTurbulenceCategory; } }
        public int ETOPS { get { return _ETOPS; } }
        public int FuelCapacity { get { return _FuelCapacityInGallons; } }

        public int GallonsPerMinuteInFlight { get { return _GallonsPerMinuteInFlight; } }

        public int GallonsPerMinuteIdle { get { return _GallonsPerMinuteIdle; } }

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

        ///WE don't need this in a Beachcraft
        public bool TrimWheelCheck()
        {
            //Fake - This is a placeholder
            return true;
        }

        /// <summary>
        /// Beachcraft has a prop engine This shouldn't be here.
        /// </summary>
        /// <returns></returns>
        public bool JetEngineCheck()
        {
            //Fake- This is a placeholder
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
