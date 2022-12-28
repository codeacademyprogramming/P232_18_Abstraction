using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson
{
    internal class Makarov :Gun, IGun,IFireable
    {
        public Makarov(string country):base(country)
        {

        }
        public int CurrentMagazine { get ; set; }
        public int MagazineCapacity { get ; set; }

        public void Fire()
        {
            CurrentMagazine--;
        }
    }
}
