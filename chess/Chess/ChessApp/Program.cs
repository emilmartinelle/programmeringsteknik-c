using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {


            for (var y = 0; y < 8; y++)
            {
                for (var x = 0; x < 16; x++)

                {
                    int characterIndex = ((x / 2) + y) % 2;
                    char character = characterIndex == 0 ? '░' : '▓';

                    Console.Write(character);
                }
                    Console.Write('\n');
                }
                Console.ReadKey();

            // string x = " 1 2 ";
            
            //foreach (char c in x)
            //{
            //    Console.Write(c);
            //}
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(x[i]);





                //Console.Write("▓");
                //Console.Write("░");
                //Console.ReadKey();
            }
        }
    }
