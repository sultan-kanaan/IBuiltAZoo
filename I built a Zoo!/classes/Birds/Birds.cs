using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_
{
    public abstract class Birds : Animal
    {
        public abstract bool migration { get; set; }
        public abstract void Beak();
        public virtual void Feathers()
        {

        }




    }
}
