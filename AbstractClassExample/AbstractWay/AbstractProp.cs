using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.AbstractWay
{
    /// <summary>
    /// No multiple inheratance but you can do this
    /// </summary>
    public abstract class AbstractProp : AbstractAircraft
    {

        public bool CheckPropellerEngine()
        {
            //Fake.  Just for the demo
            return true;
        }

    }
}
