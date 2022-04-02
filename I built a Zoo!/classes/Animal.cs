using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_
{
    public abstract class Animal
    {

        public abstract string Name { get; set; }

        public abstract bool InTheZoo { get; set; }
        public virtual int Legs { get; set; }
        public virtual string Type { get; set; }



        public virtual void DrawAvatar()
        { 
        
        }

        public virtual bool canSleep()
        {
            Console.WriteLine("I can Sleep");
            return true;
        }

        public abstract void Sound();
        

        public abstract string Eat();
    }
}
