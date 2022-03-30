using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_.classes
{
    public abstract class Animal
    {

        public virtual string Name { get; set; }


        
        

        public virtual bool canFly()
        {
            Console.WriteLine("I can Fly");
            return true;
        }

        public abstract string Sound();
        

        public abstract string Eat();
    }
}
