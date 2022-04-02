using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_
{
    public class Cat : Pets
    {
        public override bool friendlyAnimals { get; set; } = true;
        public override int Legs { get; set; } = 4;
        public override string Name { get; set; } = "Cat";
        public override bool InTheZoo { get; set; } = false;

        public override string Eat()
        {
            return "I Drink Milk";
        }

        public override void fur()
        {
            Console.WriteLine("I Have Fur");       
        }

        public override void Sound()
        {
            Console.WriteLine("MY sound is mew.meow");
        }
        public override void DrawAvatar()
        {
            Console.WriteLine(@" ,_     _
 |\\_,-~/
 / _  _ |    ,--.
(  @  @ )   / ,-'
 \  _T_/-._( (
 /         `. \
|         _  \ |
 \ \ ,  /      |
  || |-_\__   /
 ((_/`(____,-'");
  
        }
        public override bool canSleep()
        {
            return true;
        }
    }
}
