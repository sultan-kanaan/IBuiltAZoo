using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_
{
    public abstract class Pets : Animal
    {
        public abstract bool friendlyAnimals { get; set; }
        public abstract void fur();
        public virtual void playingWithChildren()
        {

        }
    }
}
