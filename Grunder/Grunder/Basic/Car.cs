using System;
using System.Collections.Generic;
using System.Text;

namespace Grunder
{
    public class Car : Vehicle // Car ärver alla fält, egenkaper och metoder. Typ som att copy/pastea koden ':' från Vehicle
    {
        // Fält
        public string CarColor;


        // Metoder
        public bool HasValidCarColor()
        {
            return string.IsNullOrEmpty(CarColor) == false; // Om en sträng är null eller tom, då blir boolean false, annars true om den är inte är det
        }
    }
}
