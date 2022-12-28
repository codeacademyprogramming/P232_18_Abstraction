using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Cat : Animal
    {
        public Cat(string name):base(name)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("meow meow");
        }
    }
}
