using System;

namespace AnimalAndInterfaceEdible
{
    public class Chicken:Animal, Edible
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cuc ta cuc tac");
        }
        public void HowToEat()
        {
            Console.WriteLine("Co the ran hoac chien");
        }
    }
}