using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_
{
    public class Owl : Birds ,IFlyable
    {
      
        public string FlyingMethod { get; set; } = "wings";
        public override string Type { get ; set ; } = "Bird";

        public override bool migration { get; set; } = true;
        public override string Name { get; set; } = "Owl ";
        public override bool InTheZoo { get; set; } = true;

        public override void Beak()
        {
            Console.WriteLine($"my name is {Name} and i have a beak ");
        }

        public override string Eat()
        {
            return "Owls are carnivores, and they hunt and feed on small mammals, birds, reptiles, reptiles, and even burma";
        }

        public string HowIFly()
        {
            return $"I fly with my {FlyingMethod}";
        }

        public override void Sound()
        {
            Console.WriteLine("MY sound is hooooooo, hooooooo.");
        }
        public override void DrawAvatar()
        {
           Console.WriteLine(@"  
  __________
 / ___  ___ \
/ / @ \/ @ \ \
\ \___/\___/ /\
 \____\/____/||
 /     /\\\\\//
|     |\\\\\\
 \      \\\\\\
   \______/\\\\
    _||_||_
");
        }
    }
}
