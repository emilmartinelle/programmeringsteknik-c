using System;

namespace Session04Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is a sentence of text, it contains many words.  ";
            string inputData = "   ";

            // Kontrollera om strängen är tilldelad ett värde
            bool inputIsNull = inputData == null;
            bool inputIsEmpty = inputData == ""; // inputData== string.Empty (string.Empty är samma sak som " ";

            // Snabbmetoder för att kontrollera innehållet i en sträng
            bool inputIsNullOrEmpty = string.IsNullOrEmpty(inputData);

            // Ytterligare kontroller om att strängen innehåller vettig data
            bool inputIsNullOrWhitespace = string.IsNullOrWhiteSpace(inputData);



            //  string sentence = "This is a sentence of text, it contains many words.  ";


            // Trimma bort mellanslag och  andra whitespace-tecken från början och slutet, som t.ex. onödiga mellanslag eller dylikt
            string trimmedSentence = sentence.Trim();

            // Trimma bort mellanslag och andra whitespace-tecken i slutet av texten
            // .TrimStart() finns även 
            string endTrimmedSentence = sentence.TrimEnd();

            // Det går att ange ett speciellt tecken som skall tags bort
            string punctuationTrimmedSentence = sentence.TrimEnd('.');

            string searchForWord = "text";
            int indexOfText = trimmedSentence.IndexOf(searchForWord);


            // Hämta bara området som letas efter
            string hitSubString = trimmedSentence.Substring(indexOfText,searchForWord.Length);
            string beforeHirSubString = trimmedSentence.Substring(0, indexOfText);

            // Stora, små bokstäver 
            string uppercaseString = trimmedSentence.ToUpper();

            string lowercaseString = trimmedSentence.ToLower();

            // Struntar i språkinställningar
            string uppercaseInvariantString = trimmedSentence.ToUpperInvariant();

            // Komma åt ett enskilt tecken
            char oneCharacter = trimmedSentence[0];

            for (int i = 0; i < trimmedSentence.Length; i++)
            {
                // Loopa igenom en sträng, tecken för tecken
                char currentCharacter = trimmedSentence[i];
            }

            foreach (var currentCharacter in trimmedSentence)
            {
                // Loopa igenom en sträng, tecken för tecken
                // Här har man inte ett index
            }

            char[] trimmedSentenceCharArray = trimmedSentence.ToCharArray();

            // Modifiera datat;

            trimmedSentence = new string(trimmedSentenceCharArray);

            trimmedSentence = trimmedSentence + "...";
            //trimmedSentence += "..."; - Samma sak som ovan

            // 1
            //123
            //3
            //23
            //3

            //001
            //002
            //003
            //023
            //123

            var numberInString = "12";
            var paddedNumberInString = numberInString.PadLeft(3, '0');

            Console.WriteLine(inputIsNullOrEmpty);

        }
    }
}
