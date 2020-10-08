using System;
using System.Linq;

namespace ConsoleApp1
{
   
   
    
        class Program
        {
            static void Main(string[] args)
            {

                Console.Write("Skriv en mening: ");

                char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'å', 'ä', 'ö', };

                string enteredString = Console.ReadLine(); // Inskrivna meningen
                string lowercaseString = enteredString.ToLower(); // Gör om strängen till små bokstäver

                string[] words = lowercaseString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int letterCount = 0;

                foreach (var word in words)
                {
                    foreach (var character in word)
                    {
                        if (letters.Contains(character))
                        {
                            letterCount++;
                        }
                    }
                }
                Console.WriteLine("Antal bokstäver är: " + letterCount);



                // Skriv en konsolapplikation som tar emot en skriven text.
                //Console.WriteLine("Enter a string, preferrably containing a sentence.");

                // char[] vowels = new char[] { 'a', 'o', 'i', 'e', 'u', 'y', 'å', 'ä', 'ö' };

                // string enteredString = Console.ReadLine();
                // string lowercaseString = enteredString.ToLower();

                // string[] words = lowercaseString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                // int vowelCount = 0;
                // int wordCount = words.Length;
                // string longestWord = string.Empty;


                // Dubbel foreach-loop
                // foreach (var word in words)
                //     {
                //         foreach (var character in word)
                //         {
                //             if (vowels.Contains(character))
                //             {
                //                 vowelCount++;
                //             }
                //         }

                //         if (word.Length > longestWord.Length)
                //         {
                //             longestWord = word;
                //         }
                //     }

                // Man kan även loopa strängar på detta sätt
                // for (var i = 0; i < enteredString.Length; i++)
                // {
                //     var character = enteredString[i];
                // }

                // Vi vill ha ut följande:
                // Antal ord?
                //  Antal vokaler?
                //  Vilket är det längsta ordet?

                // Console.WriteLine("Word count: " + wordCount);
                // Console.WriteLine("Vowel count: " + vowelCount);
                // Console.WriteLine("Longest word: " + longestWord + ", " + longestWord.Length + " characters.");
            }
        }
    }


