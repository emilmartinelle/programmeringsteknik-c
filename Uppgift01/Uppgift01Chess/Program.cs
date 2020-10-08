using System;

namespace Uppgift01Chess
{
    class Program
    {
        static void Main(string[] args)
        {


            for (var y = 0; y < 8; y++)
            {
                for (var x = 0; x < 16; x++)

                {
                    int squareIndex = ((x / 2) + y) % 2;
                    char square = squareIndex == 0 ? '░' : '▓';

                    Console.Write(square);
                }
                Console.Write('\n');
            }
            Console.ReadKey();


            // Använd Chess-koden som bas
            // Rita ett schackbräde med hjälp av två tecken
            // Man behöver använda % (modulo) 'restprodukten när man delar'
        }
}
}
//  ░  ▓

//static void Main(string[] args)
//{


//    for (var y = 0; y < 8; y++)
//    {
//        for (var x = 0; x < 16; x++)

//        {
//            int characterIndex = ((x / 2) + y) % 2;
//            char character = characterIndex == 0 ? '░' : '▓';

//            Console.Write(character);
//        }
//        Console.Write('\n');
//    }
//    Console.ReadKey();