using System;

namespace Session04Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int? nullableInteger = null; // '?' Måste vara där för att det är en värdetyp
            double? nullableDouble = null;
            char?[] nullableCharArray = new char?[] { 'a', null, 'b' };

            //nullableInteger.HasValue;
            //nullableInteger.Value;

            for (var i = 0; i < nullableCharArray.Length; i++)
            {
                char? currentChar = nullableCharArray[i];

                // För att kontrollera om värdet är null kan man:
                if (currentChar.HasValue == false) continue;
                // eller
                if (currentChar == null) continue;

                // För att komma åt ett värde kan man
                char currentCharValue = currentChar.Value;
                // eller
                currentCharValue = (char)currentChar;

            }

            string defaltString = null;

            // Olika typer av konstanter
            int minValue = int.MinValue;
            double maxValue = double.MaxValue;
            double nanValue = double.NaN;
            double infinity = double.PositiveInfinity;


            checked // För att kolla om koden som är skriven 'fungerar'
            {
                byte byteValue = 255;
                byteValue += 1;
            }
        }
    }
}
