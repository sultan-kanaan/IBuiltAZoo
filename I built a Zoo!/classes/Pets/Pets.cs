using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_
{
    public abstract class Pets : Animal
    {
        public static string kraken { get; set; }
        public static void Kraken() 
        {
            Console.WriteLine( @"
                  ,'''`.
                 / _  _ \
                 |(@)(@)|
                 )  __  (
                /,'))((`.\
               (( ((  )) ))        
                `\ `)(' /'
                  ");
        }
    }
}
