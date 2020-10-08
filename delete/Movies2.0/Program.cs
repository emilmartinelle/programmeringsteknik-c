using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Movies2._0
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.BackgroundColor = ConsoleColor.White;


            Console.WriteLine(" ----------------------------------------");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Välkommen till Hans-Johnnys Film & Musik");
            Console.ResetColor();
            Console.WriteLine("|\n ----------------------------------------");

            Movies myMovies = new Movies();
            
                Console.WriteLine($"Title: {myMovies.movieTitle} \n Release: {myMovies.MovieRelease}");
            
            ////   Console.WriteLine($"Title: {myMovies.movieTitle}{i}\nDirector: {myMovies.movieDirector}{i}\nRating:{i}\nRelease date:{myMovies.movieRelease +i*4}\nSpeltid: {myMovies.playtimeH}h {myMovies.playtimeM +i*5}m\nPris: {myMovies.moviePrice + i * 20}:-\n-----------------------------------");
            //     Console.WriteLine(($"___________________________________"));          
            //     Console.Write(($"Title: {myMovies.movieTitle}{i}\n"));
            //     Console.Write(($"Director: {myMovies.movieDirector}{i}\n"));
            //     Console.Write(($"Rating: {i}\n"));
            ////   Console.Write(($"Release Date: {myMovies.movieRelease + i * 4}\n"));
            //     Console.Write(($"Speltid: {myMovies.playtimeH}h {myMovies.playtimeM + i * 5}m\n"));
            //     Console.Write(($"Pris: {myMovies.moviePrice + i * 20}:-\n"));
            //     Console.Write(($"___________________________________\n"));

            //var zip = myInfo.names.Zip(myInfo.places, (n, p) => new { n, p }).Zip(myInfo.colors, (t, c) => new { Name = t.n, Place = t.p, Color = c });
            //Array.Sort(myInfo.places);  n=title   p=release     t=t     c=director 


            //List<Movies> movies = new List<Movies>();

            //// Sortera en lista med en egen comparer
            //// movies.Sort(new ProductNameComparer());

            //// Sortera en lista med egen comparer via LINQ
            //var productsSortedByName = 0;

            //// Sortera en lista via LINQ helt och hållet
            //productsSortedByName = movies.OrderBy(myMovies => myMovies.movieTitle)
            //                                .ThenBy(myMovies => myMovies.movieRelease)
            //                                .ThenBy(myMovies => myMovies.movieDirector)
            //                                .ToList(); // <- För att genomföra sorteringen till en variabel,
            //                                           // Annars körs sorteringen varje gång man loopar innehållet i variabeln.


            //var zip = myMovies.movieTitle.Zip(myMovies.movieRelease, (title, release) => new { title, release }).Zip(myMovies.movieDirector, (t, director) => new { Title = t.title, Release = t.release, Director = t.director }); ;
            //foreach (var z in zip)
            //{
            //    Console.WriteLine(string.Join("\n", new[] { (object)z.Title, z.Release, z.Director }));
            //}



        //    public static class Extension
        //{
        //    public static IEnumerable<Movies> ZipThree<T1, T2, T3, TResult>(
        //        this IEnumerable<T1> source,
        //        IEnumerable<T2> second,
        //        IEnumerable<T3> third,
        //        Func<T1, T2, T3, TResult> func)
        //    {
        //        using (var e1 = source.GetEnumerator())
        //        using (var e2 = second.GetEnumerator())
        //        using (var e3 = third.GetEnumerator()) 
        //        {
        //            while (e1.MoveNext() && e2.MoveNext() && e3.MoveNext())
        //                yield return func
        //        }
        //    }
        //}


        //    Array.Sort(myMovies.movieRelease);

        //    var list = myMovies.movieTitle.Zip(myMovies.movieRelease, myMovies.movieDirector, (title, release, director) => title + "\n" + release + "\n" + director);
            
        //        foreach(var l in list)
        //        {
        //        Console.WriteLine(l);
        //        }
            



            //foreach (var z in zip)
            //{
            //    Console.WriteLine(string.Join("\n", new[] { (object)z.Name, z.Place, z.Color }));
            //}


            //Console.WriteLine(($"___________________________________"));
            //Console.Write(($"Title: {myMovies.movieTitle}\n"));

            //Console.Write(($"Director: {myMovies.movieDirector}\n"));


            // Console.Write(($"Rating: {myMovies.movieRating}{i}\n"));

            //     Console.Write(($"Release Date: {release}\n"));

            //  Console.Write(($"Speltid: {myMovies.playtimeH}h {(myMovies.playtimeM + i * 4)/3}m\n"));

            // Console.Write(($"Pris: {myMovies.moviePrice + i * 21}:-\n"));
            Console.Write(($"___________________________________\n"));

        }
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