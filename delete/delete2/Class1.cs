using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace delete2
{
    class Movies
    {
        public string title, director, releaseDate, playtime;
        public int averageRating;
        public double price;


        // Default Constructor

        public Movies
            (string movieTitle,
            string movieDirector,
            int avarageMovieRating,
            string movieReleaseDate,
            string moviePlaytime,
            double moviePrice)
            

        {

            //title = movieTitle;

            //director = movieDirector;

            //averageRating = avarageMovieRating;

            //releaseDate = movieReleaseDate;

            //playtime = moviePlaytime; // Slumpad???

            //price = moviePrice; // Slumpad??? ( Måste vara permanent värde)

            string[] titles = { "test" };
            int arrayLenght = titles.Length;

            for (int i = 0; i < arrayLenght; i++) 
            {
                Console.WriteLine(titles[i + 1]);
            }
        }
    }

}