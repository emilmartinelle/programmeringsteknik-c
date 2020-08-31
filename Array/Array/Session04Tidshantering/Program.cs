using System;
using System.Diagnostics;
using System.Threading;

namespace Session04Tidshantering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vad klockan är
            DateTime currentDateTime = DateTime.Now;
            DateTime currentTimeZoneNeutralDateTime = DateTime.UtcNow;
            
            // Mximala
            DateTime maxValue = DateTime.MaxValue;
            DateTime minValue = DateTime.MinValue;
            
            var parsedDate = DateTime.Parse("2020-01-01");
            //DateTime failedParseDate = DateTime.Parse("asdf");

            // Out-parameter sätter alltid värdet, parsedDate är ändrat
            // DateTime.TryParse fungerar på samma sätt som int.TryParse
            bool dateWasParsed = DateTime.TryParse("asdf", out parsedDate);

            // Tiden
            TimeSpan currentTime = currentDateTime.TimeOfDay;
            // Baseras på ticks
            //currentTime.Ticks;

            // Hur många ticks som går på en sekund
            //TimeSpan.TicksPerSecond;

            TimeSpan createdTimeSpan = new TimeSpan(1, 2, 3); // Timme, minuter, sekunder

            Stopwatch timer = new Stopwatch();
            timer.Start();


            // Pausa programmet manuellet
            Thread.Sleep(1000);

            timer.Stop();

            DateTime today = DateTime.Today;
            DateTime yesterday = DateTime.Today.AddDays(-1); // Kan forsätta kedjas med mera 
                                                             //.AddHours(-1).AddSeconds(-1); Med mera

            TimeSpan resultOfTwoTimes = today - yesterday;
            TimeSpan negativeResultOfTwoTimes = yesterday - today;

            // Formattera, skriva ut tid
            Console.WriteLine(resultOfTwoTimes);
            
            // Slumpa värden
            Random randomizer = new Random();
            int randomNumber = randomizer.Next(0,100);
            int randomNumber2 = randomizer.Next(0, 100);

            // Gör inte så här, detta leder till att ni får duplicerade värden
            // Detta på grund av att slumpade värden
            randomNumber = new Random().Next(0, 100);
            randomNumber2 = new Random().Next(0, 100);
        }
    }
}
