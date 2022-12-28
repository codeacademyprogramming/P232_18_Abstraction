using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("artur");

            Cat cat1 = new Cat("mestan");

            dog1.MakeSound();
            cat1.MakeSound();
        }
    }
}
