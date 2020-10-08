using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {

        static void Main(string[] args)
        {
            // Skriv en konsolapplikation som tar emot en skriven text.
            Console.WriteLine("Skriv en mening: ");

            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'å', 'ä', 'ö', };

            string enteredString = Console.ReadLine();
            string lowercaseString = enteredString.ToLower();

            string[] words = lowercaseString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int letterCount = 0;
            int wordCount = words.Length;

            int letterPerWords = (wordCount);


            foreach (var word in words)
            {
                foreach (var character in word)
                {
                    if (letters.Contains(character))
                    {
                        letterCount++;
                    }
                }

                // Console.WriteLine("Longest word: " + longestWord + ", " + longestWord.Length + " characters.");

            
            }
            Console.WriteLine("Word count: " + wordCount);
            Console.WriteLine("Letter count: " + letterCount);

            Console.WriteLine("Letter Per Words: " + letterPerWords);
            //Console.WriteLine("Letter per words: " + letterPerWords);
        }
    }
}