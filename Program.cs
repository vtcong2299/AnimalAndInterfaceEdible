using System;

namespace AnimalAndInterfaceEdible
{
    class Program
    {
        static void Main(string[]args)
        {
            // Chicken chicken = new Chicken();
            // chicken.MakeSound();
            // Tiger tiger = new Tiger();
            // tiger.MakeSound();
            Animal[] animals = new Animal[]{new Tiger(), new Chicken()};
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
                if (animal is Chicken)
                {
                    Edible edibler = (Chicken)animal;
                    edibler.HowToEat();
                }
            }
            Fruit[] fruits = new Fruit[]{new Orange(),new Apple()};
            foreach (Fruit fruit in fruits)
            {
                fruit.HowToEat();                
            }
        }
    }
}