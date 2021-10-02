using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.AbstractWay
{
    public class Aircraft757 :AbstractAircraft
    {
        public Aircraft757()
        {

        this._ETOPS = 180;
        this._FuelCapacityInGallons = 11276;
        this._GallonsPerMinuteInFlight = 18;
        this._GallonsPerMinuteIdle = 3;
        this._WakeTurbulenceCategory =
        General.WakeTurbulenceCategoryEnum.HEAVY;
       }


        public bool JetEngineCheck()
        {
            //Fake- This is a placeholder
            return true;
        }
    }
}
