using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson
{
    internal class Ak47 :Gun,IGun,IFireable
    {
        public Ak47(string country):base(country)
        {

        }
        public int CurrentMagazine { get ; set ; }
        public int MagazineCapacity { get; set; }
        public void Fire()
        {
            CurrentMagazine -= 2;
        }
    }
}
