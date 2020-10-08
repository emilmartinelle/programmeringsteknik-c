using System;
using System.Collections.Generic;
using System.Text;

namespace Grunder
{
    public class Vehicle // Gör klasserna public för att få dem tillgängliga
    {
        // Fält
        public int VINNumber;
        public int PassengerSeats;
        public int Wheels;
        public string RegistrationNumber;

        // Metoder
        public bool IsVINValid()
        {
            return VINNumber > 0; // Är värdet större än 0 blir det true
        }
    }
}
