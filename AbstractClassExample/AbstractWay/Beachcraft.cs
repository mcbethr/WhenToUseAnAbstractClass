using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.AbstractWay
{
    public class Beachcraft : AbstractAircraft
    {

        public Beachcraft()
        {
            this._ETOPS = 60;
            this._FuelCapacityInGallons = 200;
            this._GallonsPerMinuteInFlight = 2;
            this._GallonsPerMinuteIdle = 1;

            this._WakeTurbulenceCategory =
                General.WakeTurbulenceCategoryEnum.SMALL;
        }


        public bool CheckPropellerEngine()
        {
            //Fake.  Just for the demo
            return true;
        }


    }
}
