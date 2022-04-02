using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_ 
{
    public class Lion : Felines, IHunterable
    {
        public override bool claws { get; set; } = true;
        public override string Name { get ; set; } = "Lion";
        public override bool InTheZoo { get; set; } = true;

        public override string Eat()
        {
            return "The lion eats about 7 kilograms of meat per day, while the lioness or female lion eats about 5 kilograms of meat on a daily basis.";
        }

        public string Hunter()
        {
            return"I can hunt";
        }

        public override void run()
        {
            Console.WriteLine("Yes, I can run");
        }

        public override void Sound()
        {
            Console.WriteLine("MY sound is roar");
        }

        public override void DrawAvatar()
        {
            Console.WriteLine(@"      
        @|\@@
       -  @@@@
      /7   @@@@
     /    @@@@@@
     \-' @@@@@@@@`-_______________
      -@@@@@@@@@             /    \
 _______/    /_       ______/      |__________-
/,__________/  `-.___/,_____________----------_)");
        }

        public override void KIngOfTheJungle()
        {
            Console.WriteLine("i Am The KIng Of The Jungle");
        }
    }

}
