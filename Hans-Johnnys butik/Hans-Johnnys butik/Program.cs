using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Hans_Johnnys_butik
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" -----------------------------------------");
            Console.WriteLine("|Välkommen till Hans-Johnnys Film & Musik|");
            Console.WriteLine(" -----------------------------------------");

            Console.WriteLine("\nVad är du intresserad av?\nTryck [1]:Film\tTryck [2]:Musik");

            var input = Console.ReadLine();

            Movies movies = new Movies();


            List<string> movieTitleList = movies.movieTitles;
            List<int> movieReleaseList = movies.movieRelease;
            List<string> movieDirectorList = movies.movieDirector;
            List<int> movieRatingList = movies.movieRating;
            List<string> movieTimeList = movies.playTime;
            List<double> moviePriceList = movies.moviePrice;


            movieReleaseList.Sort();
            movieReleaseList.Reverse();


            Albums albums = new Albums();

            List<string> songTitleList = albums.songTitles;
            List<int> songReleaseList = albums.songRelease;


            using (var movieTitle = movieTitleList.GetEnumerator())
            using (var movieRelease = movieReleaseList.GetEnumerator())
            using (var movieDirector = movieDirectorList.GetEnumerator())
            using (var movieRating = movieRatingList.GetEnumerator())
            using (var moviePlayTime = movieTimeList.GetEnumerator())
            using (var moviePrice = moviePriceList.GetEnumerator())

            using (var songTitle = songTitleList.GetEnumerator())
            {

                if (input == "1")
                {

                    while (movieTitle.MoveNext() && movieRelease.MoveNext() && movieDirector.MoveNext() && movieRating.MoveNext() && moviePlayTime.MoveNext() && moviePrice.MoveNext())
                    {
                        var title = movieTitle.Current;
                        var release = movieRelease.Current;
                        var director = movieDirector.Current;
                        var rating = movieRating.Current;
                        var time = moviePlayTime.Current;
                        var price = moviePrice.Current;

                        var albumSongTitle = songTitle.Current;

                        Console.WriteLine($"Filmtitel: {title}\nUtgivningsdatum: {release}\nDirektör: {director}\nSnittbetyg: {rating}\nSpeltid: {time}\nPris: {price.ToString("0.00")}:-\n\n");
                    }

                    if (input == "2")
                    {

                        while (movieRating.MoveNext() && movieRelease.MoveNext())
                        {
                            var release = movieRelease.Current;
                            var director = movieDirector.Current;
                            var albumSongTitle = songTitle.Current;

                            for (int i = 1; i < 3; i++)
                            {
                                //movieDirectorList.Reverse();

                                Console.WriteLine($"Album {i}\nUtgivningsdatum: {release} Artist: {director} ");

                                    while (songTitle.MoveNext())
                                    {
                                        Console.WriteLine($"{albumSongTitle} {i}\n{release}\n");

                                    }
                            }
                        }

                    }
                    else if (input != "1")
                    {
                        Console.WriteLine("Vänligen ange antingen [1] Film \t[2] Musik");
                    }

                }


                //Console.WriteLine(" -----------------------------------------");
                //Console.WriteLine("|Välkommen till Hans-Johnnys Film & Musik|");
                //Console.WriteLine(" -----------------------------------------");

                //Console.WriteLine(" -----------------------------------------\n|Välkommen till Hans-Johnnys Film & Musik|\n -----------------------------------------");


                //string billingAdress;
                //string visitingAdress;

                //billingAdress = ("");
                //visitingAdress = ("");

                //Console.WriteLine(billingAdress);
                //Console.WriteLine(visitingAdress);


            }
        }
    }
}


// IEnumerable & arrayer 

// TimeSpan kan användas för att ge tiden till filmen / musik
// DateTime kan användas för att ge ett datum (kanske till film / musik???)

// Ange eventuell randomdata i loopar ( får ej repetera värden i sådanafall

// Eller tag ett basic-namn och multiplicera det 25 ggr med en siffra i slutet som varation (loopa, värdet ökar med +1 varje gång)

//Hans-Johnny har precis startat en butik på nätet där han säljer film och musik till en smalare publik.

//Butiken har två adresser, en för fakturering och en besöksadress.
//Butikens utbud består av 25 unika filmer och unika 25 musikalbum.

//Resultatet skall presentera följande information.

//För filmer: Namn, Regissör, Snittbetyg från användare(0 - 10), Releasedatum, Speltid(i minuter och timmar), Pris.
//För musikalbum: Namn, Artist, Snittbetyg från användare(0 - 10), Releasedatum, Speltid(i minuter och timmar), Antal låtar, Pris.

//Album innehåller även en lista med låtar som skall innehålla följande information: Låtnamn, Speltid, Ytterligare artister(featuring)

//Följande skall skrivas ut:

//Butikens information(inklusive adresser).
//Filmutbud, sorterat efter releasedatum, fallande(nyast överst).
//Albumutbud, sorterat efter snittbetyg från användare, fallande(högst överst).

//Datamodellen skall i största möjliga mån dela information där det är möjligt.

//(Fiktiv data accepteras självklart)

