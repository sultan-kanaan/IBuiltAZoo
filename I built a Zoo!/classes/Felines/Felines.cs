using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_
{
    public abstract class Felines : Animal
    {
        public virtual bool tusks { get; set; }

        public abstract bool claws { get; set; }
        public abstract void run();
        public virtual void KIngOfTheJungle()
        {

        }
    }
}
