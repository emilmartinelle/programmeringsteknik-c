using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool twoGreaterThanOne = 2 > 1;
            bool twoLessThanThree = 2 < 3;
            bool threeLessThanFour = 3 < 4;

            if (twoGreaterThanOne)
            {
                // Initierar ett nytt scope i detta kodblock
                int localVariableInSubScope = 1; // Finns bara inom if-satsen, ej tillgängliga utanför blocket
            }
            else if (twoLessThanThree) // Körs om inte föreliggande inträffar
            {

            }
            // Man kan lägga till hur många else if man vill
            else if(threeLessThanFour) // Denna kör om även förra inte inträffarS
            {

            }
            else // Körs bara om inget av det andra körs
            {

            }
            int waterTemp = 24;

            string label = waterTemp > 30 ? "hot" : "cold";


            // Samma sak som ovanstående
            if (waterTemp > 30)
            {
                label = "hot";
            }
            else
            {
                label = "cold";
            }

            // Om det skulle vara precis 24 grader
            switch (waterTemp)
            {
                case 24:label = "perfekt";break; //break; eller return;
            }
        }
    }
}
