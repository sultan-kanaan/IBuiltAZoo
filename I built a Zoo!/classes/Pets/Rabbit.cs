using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_
{
    public class Rabbit : Pets
    {
        public override bool friendlyAnimals { get; set; } = true;
        public override int Legs { get; set; } = 4;
        public override string Name { get; set; } = "Rabbit";
        public override string Type { get; set; } = "Pet";
        public override bool InTheZoo { get; set; } = true;

        public override string Eat()
        {
            return"I Eat Carrots";
        }

        public override void fur()
        {
            Console.WriteLine("I Have Fur");
        }

        public override void Sound()
        {
            Console.WriteLine("MY sound is squeak");
        }
        public override void playingWithChildren()
        {
            Console.WriteLine("I Can Play With Children ");
        }
        public override void DrawAvatar()
        {
            Console.WriteLine(@"         
                ((`\
            ___ \\ '--._
         .'`   `'    o  )
        /    \   '. __.'
       _|    /_  \ \_\_
     {_\______\-'\__\_\");

        }
    }
}
