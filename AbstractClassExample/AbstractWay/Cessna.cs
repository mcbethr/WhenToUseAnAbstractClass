using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.AbstractWay
{
    public class Cessna : AbstractProp
    {

        public Cessna()
        {

            this._ETOPS = 45;
            this._FuelCapacityInGallons = 20;
            this._GallonsPerMinuteInFlight = 2;
            this._GallonsPerMinuteIdle = 1;
            this._WakeTurbulenceCategory =
            General.WakeTurbulenceCategoryEnum.SMALL;
        }

    }
}
