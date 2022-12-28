using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson
{
    internal class Gun
    {
        public Gun(string country)
        {
            Country = country;
        }
        public string Country;

        public void ShowInfo()
        {
            Console.WriteLine($"{Country}");
        }
    }
}
