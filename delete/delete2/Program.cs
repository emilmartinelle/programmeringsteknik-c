using System;

namespace delete2
{
    class Program
    {
        static void Main(string[] args)
        {

            Movies movie01 = new Movies("Test", "abc", 3, "01-01-1999", "3h 33m", 99.95);
            Console.WriteLine($"Titel: {movie01.title} \nRegisör: {movie01.director}\nSnittbetyg: {movie01.averageRating}\nUtgivningsdatum: {movie01.releaseDate}\nSpeltid: {movie01.playtime}\nPris:{movie01.price}\n");

            Movies movie02 = new Movies("Test 2", "def", 1, "03-18-2005", "1h 05m", 49);
            Console.WriteLine($"Titel: {movie02.title} \nRegisör: {movie02.director}\nSnittbetyg: {movie02.averageRating}\nUtgivningsdatum: {movie02.releaseDate}\nSpeltid: {movie02.playtime}\nPris:{movie02.price}\n");

            Movies movie03 = new Movies("Test 3", "ghi", 5, "10-22-2018", "2h 30m",195.49);
            Console.WriteLine($"Titel: {movie03.title} \nRegisör: {movie03.director}\nSnittbetyg: {movie03.averageRating}\nUtgivningsdatum: {movie03.releaseDate}\nSpeltid: {movie03.playtime}\nPris:{movie03.price}\n");


            //Movies movie01 = new Movies();

            // Console.WriteLine("Filmtitel: " + $"{ movie01.movieTitle}");

            // Console.WriteLine("Regisör: " + $"{movie01.director}");

            // Console.WriteLine("Snittbetyg: " + $"{movie01.averageRating}");

            // Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();
        }
    }
}