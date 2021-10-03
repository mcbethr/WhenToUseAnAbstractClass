using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.OldWay
{
    public class Utility
    {
        public static TimeSpan CalculateFlightTimeWithIdle(DateTime TakeOffTime, DateTime LandingTime,
                General.WakeTurbulenceCategoryEnum PreceedingAircraft)
        {


            TimeSpan FlightTime = LandingTime - TakeOffTime;
            FlightTime = FlightTime + CalculateWakeTurbulenceWait(PreceedingAircraft);

            return FlightTime;
        }

        private static TimeSpan CalculateWakeTurbulenceWait(General.WakeTurbulenceCategoryEnum Preceeding)
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

        public static bool CalculateFlightTimeWithIdleReginal(DateTime TakeOffTime, DateTime LandingTime,
        General.WakeTurbulenceCategoryEnum PreceedingAircraft)
        { 

            return true;
        }

        public static bool CalculateFlightTimeWithIdleGlobal(DateTime TakeOffTime, DateTime LandingTime,
General.WakeTurbulenceCategoryEnum PreceedingAircraft)
        {

            return true;
        }

        public static bool CalculateFlightTimeWithIdleGlobal3(DateTime TakeOffTime, DateTime LandingTime,
General.WakeTurbulenceCategoryEnum PreceedingAircraft)
        {

            return true;
        }
    }
}
