using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Dog:Animal
    {
        public Dog(string name):base(name)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("hav hav");
        }
    }

}
