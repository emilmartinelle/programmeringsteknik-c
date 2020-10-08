using System;

namespace Uppgift01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            ConsoleColor background = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("");
            //ConsoleColor cross = Console.BackgroundColor;
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.ReadLine();
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