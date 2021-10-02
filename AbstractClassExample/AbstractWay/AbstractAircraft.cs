using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.AbstractWay
{
    public abstract class AbstractAircraft
    {
      
            protected int _ETOPS;
            protected int _FuelCapacityInGallons;
            protected int _GallonsPerMinuteInFlight;
            protected int _GallonsPerMinuteIdle;
            protected General.WakeTurbulenceCategoryEnum _WakeTurbulenceCategory;

            public int ETOPS { get { return _ETOPS; } }
            public int FuelCapacity { get { return _FuelCapacityInGallons; } }

            public int GallonsPerMinuteInFlight { get { return _GallonsPerMinuteInFlight; } }

            public int GallonsPerMinuteIdle { get { return _GallonsPerMinuteIdle; } }

            public General.WakeTurbulenceCategoryEnum WakeTurbulenceCategory
            { get { return _WakeTurbulenceCategory; } }

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

            public TimeSpan CalculateFlightTimeWithIdle(DateTime TakeOffTime, DateTime LandingTime,
                    General.WakeTurbulenceCategoryEnum PreceedingAircraft)
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
                        return new TimeSpan(0, 4, 0);
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

}
