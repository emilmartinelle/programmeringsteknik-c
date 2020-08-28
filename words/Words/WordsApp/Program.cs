using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string, preferrably containing a sentence");

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö', };

            string enteredString = Console.ReadLine();
            string lowercaseString = enteredString.ToLower();



            string myTestString = "this is a test";
            string myLowercaseString = myTestString.ToLower();

            string[] words = myTestString.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var character in myTestString);
            {
             //var normalizedCharacter =char.ToLower(character)
             if (vowels.Contains(character))
                {

                }
            }

            for (var i = 0; i < myTestString.Length, i++);
            {
                var character = myTestString[i];
            }

            Console.WriteLine("Word count: " + wordCount);
            Console.WriteLine("Vowel count: " + VowelCount);
            Console.WriteLine("Word count: " + longestWord + ", " +  );
        }
    }
}


//Skriv en konsollapplikation som tar emot skriven text

/*/ Vi vill ha följande:
 * Antal ord?
 * Antal vokaler?
 * Vilket är det längsta ordet?
 * 
 * Word count 
 * Vowel count
 * Longest word/*/
