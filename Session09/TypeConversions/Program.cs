using System;
using System.Globalization;
using System.Linq.Expressions;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // .Convert är snabbt och enkelt men lite mer prestandakrävande och inte lika finkänsligt
            int integer = Convert.ToInt32("1"); // Konvertering av en int

            int integerConversion = (int)1.0; // (int)"1"; går ej att konvertera

            // .Parse konverterar också men tar hänsyn till flera specifika saker så som t.ex. språk och inställningar
            int integerByParsing = int.Parse("1");

            // Ett sätt att se om det gick igenom genom att visa en boolean (true/false)
            // Felhanterad parsing av stränkonvertering 
            int integerByTryingToParse;
            bool integerWasParsed = int.TryParse("1", out integerByParsing);


            try
            {
                int integerByParse = int.Parse("q");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Parsingmetoderna "1,2" Windows på Svenska => 1.2
            // Parsingmetoderna "1.2" Windows på Svenska => 12

            // Parsingmetoderna "1,2" Windows på Engelska => 12
            // Parsingmetoderna "1.2" Windows på Engelska => 1.2

            // Tvinga parsemetoderna att använda ett specifikt språk
            int.Parse("1.2", CultureInfo.InvariantCulture);

            // Definera kulturobjekt
            new CultureInfo("sv-SE");
            new CultureInfo("sv"); // Landsneutral


            // Ger möjlighet att köra logik om parsingen lyckades
            if (integerWasParsed)
            {

            }

            else
            {

            }

            Console.WriteLine(integer);
        }
    }
}
