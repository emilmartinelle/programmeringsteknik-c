using System;
using System.Drawing;
using System.Linq;

namespace Nestling_foreach
{
    class Program : Info
    {
        public static void Main(string[] args)
        {

            //var names = new[] { "John", "Bill", "Joel" };
            //var places = new[] { 1, 2, 3 };
            //var colors = new[] { Color.AliceBlue, Color.BlueViolet, Color.DarkMagenta };

            Info myInfo = new Info();

            var zip = myInfo.names.Zip(myInfo.places, (n, p) => new { n, p }).Zip(myInfo.colors, (t, c) => new { Name = t.n, Place = t.p, Color = c });
            Array.Sort(myInfo.places);

            foreach (var z in zip)
            {
                Console.WriteLine(string.Join("\n", new[] { (object)z.Name, z.Place, z.Color }));
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);


            //foreach (var z in myInfo.names.ZipSeveral(myInfo.places, myInfo.colors))
            //{
            //    Console.WriteLine(string.Join(", ", new[] { (object)z.Item1, z.Item2, z.Item3 }));
            //}
        }
    }
}