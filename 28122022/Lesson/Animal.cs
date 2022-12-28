using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal abstract class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }
        public string Name;
        public byte Age;

        public abstract void MakeSound();
    }
}
