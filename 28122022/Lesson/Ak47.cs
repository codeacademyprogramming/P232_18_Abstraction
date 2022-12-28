using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Ak47:Gun
    {
        public override void Fire()
        {
            this.CurrentMagazine-= 2;
        }
    }
}
