using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Bycle:Vehicle
    {
        public override void Drive(double km)
        {
            Millage += km;
        }
    }
}
