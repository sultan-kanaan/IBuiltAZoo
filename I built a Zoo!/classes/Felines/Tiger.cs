using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_
{
    public class Tiger : Felines, IHunterable


    {
        public override bool tusks { get; set; } = true;

        public override bool claws { get; set; } = true;
        public override string Name { get; set; } = "Tiger";
        public override bool InTheZoo { get; set; } = true;

        public override string Eat()
        {
            return "It depends on feeding itself on the prey of other animals, and eating their meat";
        }

        public string Hunter()
        {
          return  "I can hunt";
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
                      __,,,,_
       _ __..-;''`--/'/ /.',-`-.
   (`/' ` |  \ \ \\ / / / / .-'/`,_
  /'`\ \   |  \ | \| // // / -.,/_,'-,
 /<7' ;  \ \  | ; ||/ /| | \/    |`-/,/-.,_,/')
/  _.-, `,-\,__|  _-| / \ \/|_/  |    '-/.;.\'
`-`  f/ ;      / __/ \__ `/ |__/ |
     `-'      |  -| =|\_  \  |-' |
           __/   /_..-' `  ),'  //
          ((__.-'((___..-'' \__.'");
        }

    }
}
