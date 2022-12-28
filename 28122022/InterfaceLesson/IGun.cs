using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson
{
    internal interface IGun
    {
        int CurrentMagazine { get; set; }
        int MagazineCapacity { get; set; }

        
    }
}
