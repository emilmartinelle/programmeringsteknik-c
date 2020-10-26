using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
   public class Program
    {
        static void Main(string[] args)
        {
            Movies movies = new Movies();


            List<string> movieList = movies.myMovies;




            Console.WriteLine();
            foreach (string movie in movieList)
            {
                Console.WriteLine(movie);
            }

        }
    }
}
