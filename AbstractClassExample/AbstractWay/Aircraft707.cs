using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.AbstractWay
{
    public class Aircraft707 : AbstractJet
    {
        public Aircraft707()
        {

            this._ETOPS = 180;
            this._FuelCapacityInGallons = 100000;
            this._GallonsPerMinuteInFlight = 25;
            this._GallonsPerMinuteIdle = 5;
            this._WakeTurbulenceCategory =
            General.WakeTurbulenceCategoryEnum.MEDIUM;
        }

        public void CanYouDoThis()
        {

            this.JetEngineCheck();
            this.WeightCapacityCheck();
        }
    }
}
