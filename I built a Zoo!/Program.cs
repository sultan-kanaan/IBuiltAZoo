using System;
using static System.Console;

namespace I_built_a_Zoo_
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.DarkMagenta ;
            WriteLine("Code By Sultan Kanaan");
            WriteLine("=============Welcome To My ZOOOOOOOOO=============");
            
            
            Falcon falcon = new Falcon();
            WriteLine("=============FALCON=============");
            falcon.Sound();
            WriteLine( falcon.HowIFly());
            falcon.DrawAvatar();
            falcon.Beak();
            WriteLine(falcon.Eat());
            WriteLine(falcon.Hunter());


            Owl owl = new Owl();
            WriteLine("=============OWL=============");
            owl.DrawAvatar();
            WriteLine(owl.Eat());
            WriteLine(owl.InTheZoo);
            owl.Sound();


            Cat cat = new Cat();
            WriteLine("=============CAT=============");
            WriteLine( cat.Eat());
            cat.Sound();
            cat.DrawAvatar();
            cat.fur();


            Rabbit rabbit = new Rabbit();
            WriteLine("=============RABBIT=============");
            rabbit.DrawAvatar();
            rabbit.Sound();
            rabbit.canSleep();
            WriteLine(rabbit.Eat());


            Tiger tiger = new Tiger();
            WriteLine("=============TIGER=============");
            tiger.DrawAvatar();
            tiger.Sound();
            WriteLine( tiger.Hunter());

            
            Felines lion = new Lion();
            WriteLine("=============LION=============");
            lion.DrawAvatar();
            lion.KIngOfTheJungle();

            ForegroundColor = ConsoleColor.Black;

        }
    }


}
