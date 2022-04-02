using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_built_a_Zoo_
{
    public class Falcon : Birds, IFlyable , IHunterable
    {
        public string FlyingMethod { get; set; } = "wings";
        public override bool migration { get; set; } = true;
        public override string Name { get; set; } = "Falcon";
        public override bool InTheZoo { get; set; } = false;

        public override void Beak()
        {
            Console.WriteLine($"my name is {Name} and i have a beak " );
        }

        public override string Eat()
        {
            return "The falcon feeds on all kinds of animals such as rabbits," +
                " mice, squirrels, snakes, bird eggs, grasshoppers, fish, bats, frogs, toads, lizards, " +
                "small and medium-sized birds, mole, fly, and waterfowl, in addition to large animals such as dogs, A small beauty.";
        }

        public string HowIFly()
        {
            return $"I fly with my {FlyingMethod}";
        }
        public string Hunter()
        {
            return"I can hunt";
        }

        public override void Sound()
        {
           Console.WriteLine("MY sound is kak, kak, kak.");
        }
        public override void DrawAvatar()
        {
            Console.WriteLine(@"          
             _.-.
        .-.  `) |  .-. 
    _.'`. .~./  \.~. .`'._
.-'`.'-'.'.-:    ;-.'.'-'.`'-.
 `'`'`'`'`   \  /   `'`'`'`'`
             /||\
            / ^^ \
            `'``'`
                                ");
        }
    }
}
