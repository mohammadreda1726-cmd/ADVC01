using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal
    {
    }
    class Test<T> where T : Animal
    {
        public void Show(T animal)
        {
            animal.Eat();
        }
    }
}
