using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Makarov:Gun
    {
        public override void Fire()
        {
            this.CurrentMagazine--;
        }
    }
}
