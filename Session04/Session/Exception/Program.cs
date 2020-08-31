using System;
using System.Globalization;

namespace Session04Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            //int buildError = "stringvalue";
            try
            {
                // För att undvika fel avslutar körning måste man hantera eventuella körtidsfel med try catch
                string word = "12a"; // Kan ej läsa av 'a'
                int integer = int.Parse(word);
            }
            catch (Exception ex)
            {
                // Denna del är till för att hantera felet, visa fel för användaren eller för att skriva till logg
                Console.WriteLine(ex.Message);
                // Går att använda till throw; för att kasta om felet
            }
            finally
            {
                // Körs alltid, är till för att städa upp körningen
                // Körs även om try-satsen inehåller return
            }


        }
    }
}