using System;
using System.Collections.Generic;
using System.Linq;

namespace JustTesting
{
    class Program : Movies
    {
        public static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.White;
            

            Console.WriteLine(" ----------------------------------------");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Välkommen till Hans-Johnnys Film & Musik");
            Console.ResetColor();
            Console.WriteLine("|\n ----------------------------------------");

            Movies myMovies = new Movies();
            for (int i = 1; i <=24 ; i++)
            {

           ////   Console.WriteLine($"Title: {myMovies.movieTitle}{i}\nDirector: {myMovies.movieDirector}{i}\nRating:{i}\nRelease date:{myMovies.movieRelease +i*4}\nSpeltid: {myMovies.playtimeH}h {myMovies.playtimeM +i*5}m\nPris: {myMovies.moviePrice + i * 20}:-\n-----------------------------------");
           //     Console.WriteLine(($"___________________________________"));          
           //     Console.Write(($"Title: {myMovies.movieTitle}{i}\n"));
           //     Console.Write(($"Director: {myMovies.movieDirector}{i}\n"));
           //     Console.Write(($"Rating: {i}\n"));
           ////   Console.Write(($"Release Date: {myMovies.movieRelease + i * 4}\n"));
           //     Console.Write(($"Speltid: {myMovies.playtimeH}h {myMovies.playtimeM + i * 5}m\n"));
           //     Console.Write(($"Pris: {myMovies.moviePrice + i * 20}:-\n"));
           //     Console.Write(($"___________________________________\n"));

                Array.Sort(myMovies.movieRelease);


                myMovies.movieRating.ToString();

                foreach (int release in myMovies.movieRelease)
                {
                    Console.WriteLine(($"___________________________________"));
                     Console.Write(($"Title: {myMovies.movieTitle} {i++}\n"));

                    Console.Write(($"Director: {myMovies.movieDirector}\n"));
                   

                  // Console.Write(($"Rating: {myMovies.movieRating}{i}\n"));

                    Console.Write(($"Release Date: {release}\n"));

                  //  Console.Write(($"Speltid: {myMovies.playtimeH}h {(myMovies.playtimeM + i * 4)/3}m\n"));

                   // Console.Write(($"Pris: {myMovies.moviePrice + i * 21}:-\n"));
                    Console.Write(($"___________________________________\n"));
                }
                foreach (int rating in myMovies.movieRating)
                {
                    Console.WriteLine(($"Rating: {rating}\n"));
                }
            }
           

            //Console.WriteLine($"Title: {movieTitle}{i}\nDirector: {movieDirector}{i}\nRating:{i}\n{movieRelease}\n");

            //for (int i = 1; i < 3; i++)
            //{


            //    Console.WriteLine($"Title: {movieTitle}{i}\nDirector: {movieDirector}{i}\nRating:{i}\n");
            //    //avarageMovieRating = avarageMovieRating + plusValue;
            //}

            //string[] titles = { "test", "try" };
            //int arrayLenght = titles.Length;

            //foreach(string title in titles)
            //{
            //    titles++;
            //    Console.WriteLine(title+1);
            //}

        }
    }
}