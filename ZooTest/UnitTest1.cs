using System;
using Xunit;
using I_built_a_Zoo_;

namespace ZooTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestFalcon()
        {
            Falcon falcon = new Falcon();
            Assert.True(falcon.migration);
            Assert.Equal("I fly with my wings", falcon.HowIFly()) ;

        }
        [Fact]
        public void TestOwl()
        {
            Owl owl = new Owl();
            Assert.True(owl.InTheZoo);
            Assert.Equal("Owls are carnivores, and they hunt and feed on small mammals, birds, reptiles, reptiles, and even burma",owl.Eat());
        }

        [Fact]
        public void TestCat()
        {
            Cat cat = new Cat();
            Assert.True(cat.friendlyAnimals);
            Assert.Equal("I Drink Milk",cat.Eat());
        }
        [Fact]
        public void TestRabbit()
        {
            Rabbit rabbit = new Rabbit();
            Assert.True(rabbit.InTheZoo);
            Assert.Equal("I Eat Carrots",rabbit.Eat());
        }
        [Fact]
        public void TestLion()
        {
            Lion lion = new Lion();
            Assert.True(lion.claws);
            Assert.Equal("The lion eats about 7 kilograms of meat per day, while the lioness or female lion eats about 5 kilograms of meat on a daily basis.",lion.Eat());
        }
        [Fact]
        public void TestTiger()
        {
            Tiger tiger = new Tiger();
            Assert.True(tiger.tusks);
            Assert.Equal("It depends on feeding itself on the prey of other animals, and eating their meat",tiger.Eat());
        }

        // Test that the classes that implement the interface actually implement it

        [Fact]
        public void TestInterface()
        {
            Falcon falcon = new Falcon();
            Assert.Equal("I fly with my wings", falcon.HowIFly());
            Assert.Equal("I can hunt", falcon.Hunter());
            
        }

        // Test inheritance
        [Fact]
        public void TestInheritance()
        {
            Lion lion = new Lion();
            Assert.True(lion is Felines);
        }

        // Prove methods have been overridden
        [Fact]
        public void ProvingMethodHasBeenOverridden()
        {
            Tiger tiger = new Tiger();
            Assert.NotEqual("roar", tiger.Eat());
        }


        // Prove that one of your concrete animals is an Animal
        [Fact]
        public void ProvingConcreteAnimalIsAnAnimal()
        {
            Lion lion = new Lion();

            Assert.True(lion is Animal);
            Assert.True(lion is Felines);
        }
    }
}
