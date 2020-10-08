using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesToLoop = 3;
            int timesLooped = 0;

            while (timesToLoop > 0)
            {
                timesLooped++;


                Console.WriteLine("This loop has executed " + timesLooped + " times");
                timesToLoop--;
                
            }
            Console.WriteLine("\n");

            timesLooped = 0;

            // Samma sak fast med do / while loop
            do
            {
                timesLooped++;

                Console.WriteLine("This second loop has executed " + timesLooped + " times");
            }
            while (timesLooped < 3);

            Console.WriteLine("\n");


            int[] values = new int[] { 10, 20, 30 };


            int externalIndex = 0;
            foreach (int value in values)
            {
                Console.WriteLine("Looping value " + value);

                values[externalIndex] = value + 1;

                externalIndex++;
            }


            // Beroende av listinehållet
            // Till för när man inte vet
            foreach (int value in values)
            {
                Console.WriteLine("Looping value " + value);
            }
            
            for (int i = 0; i < values.Length; i++)
            {
                int value = values[i];
                Console.WriteLine("Looping for loop " + value);
            }
        }
    }
}
