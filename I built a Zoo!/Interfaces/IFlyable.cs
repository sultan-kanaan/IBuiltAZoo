using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_
{
    interface IFlyable
    {
        string FlyingMethod { get; set; }

        string HowIFly();
    }
}
