using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample.AbstractWay
{
    /// <summary>
    /// You can't do this.  No multiple inheratance.
    /// </summary>
    public abstract class AbstractJet : AbstractAircraft
    {

        public bool JetEngineCheck()
        {
            //Fake- This is a placeholder
            return true;
        }

    }
}
