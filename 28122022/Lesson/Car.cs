using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Car:Vehicle
    {
        public double CurrentFuel;
        public double FuelForKm;

        public override void Drive(double km)
        {
            double neededFuel = km * FuelForKm;
            if (CurrentFuel >= neededFuel)
            {
                CurrentFuel -= neededFuel;
                Millage += km;
            }
        }
    }
}
