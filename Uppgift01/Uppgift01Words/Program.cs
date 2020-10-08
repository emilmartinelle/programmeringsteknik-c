﻿using System;
using System.Linq;
using System.Linq.Expressions;

// Konvertera det inmatade värdena från strängar till siffror
// Resultatet skall presentera:
// Lägsta värdet
// Högsta värdet
// Medelvärde (snitt)
// Programmet skall vara felhanterat
// Felaktiga värden får inte påverka medelvärde, lägsta eller högsta

namespace Uppgift01Words
{
    class Program

    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Skriv in fem siffror:");


            for (int i = 0; i < 5; i++)
            {
                try
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du kan ej ange bokstäver");
                }
                

               

            }


                int lowest = array[0];
            int highest = array[4];
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                if (array[i] < lowest)
                {
                    lowest = array[i];
                }
                if (array[i] > highest)
                {
                    highest = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }


            int median = (sum / 5);


            Console.WriteLine("Den lägsta siffran är {0}", lowest);
            Console.WriteLine("Den högsta siffran är {0}", highest);
            Console.WriteLine("Medianen är {0}", median);

            
            
        }
    }
}

//catch(System.FormatException)

//catch (System.FormatException ex)
//{
//    Console.WriteLine("Du kan ej ange bokstäver");
//}

//try
//{
//    return array[i];
//}
//catch (System.FormatException)
//{
//    Console.WriteLine("Du kan ej ange bokstäver");

//}