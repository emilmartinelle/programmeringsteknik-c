using System;

namespace Grunder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Man kan tilldela alla datatyper som ärver från Vehicle i denna variabel, som t.ex. 'Car'
            // Generellt används Car som datatyp
            Vehicle myVehicle = new Car();
            // Exempel på boxing, vi packar ner datatypen i en låda var innehåll glöms bort


            // Tilldela värde 121 på fältet VINNumber
            myVehicle.VINNumber = 121;
            myVehicle.Wheels = 4;
            myVehicle.RegistrationNumber = "ABC123";

            // Värdekonvertering som orsakar fel
            Car myCar = (Car)myVehicle;
            // Exempel på unboxing, vi packar upp data ur en låda

            // Värdekonvertering som blir null
            Car myNullableCar = myVehicle as Car;

            // Sätta det specifika fältet CarColor till ett värde
            myCar.CarColor = "Brown";
            myCar.PassengerSeats = 4;
            // Kommer ej åt på generella datatypen
            // myVehicle.CarColor
            
        }
    }
}
