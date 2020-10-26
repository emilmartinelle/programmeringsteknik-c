using System;
using System.Collections.Generic;
using System.Text;

namespace Hans_Johnnys_butik
{
    public class Movies
    {
        public List<string> movieTitles = new List<string>()
        {
            "The Shawshark Redemmption", "The Godfather", "Citizen Kane", "Angry Men", "Schindler's List", "The Good, the Bad and The Ugly", "Star Wars: Episode V - The Empire Strikes Back", "The Lord of the Rings: The Return of the King", "The Dark Knight", "The Godfather: Part II","Pulp Fiction", "Fight Club","Psycho","2001: A Space Odyssey", "Metropolis", "Star Wars: Episode IV - A New Hope", "The Lord of the Rings: The Fellowship of the Ring","Terminator 2: Judment Day", "The Matrix","Raiders of the Lost Ark", "Casablanca", "The Wizad of Oz", "Seven Samurai", "Forrest Gump", "Inception"
        };

        public List<int> movieRelease = new List<int>()
        {
            1994, 1972, 1941, 1957, 1993, 1966, 1980, 2003, 2008, 1974, 1994, 1999, 1960, 1968, 1927, 1977, 2001, 1991, 1999, 1981, 1942, 1939, 1954, 1994, 2010
        };

        public List<string> movieDirector = new List<string>()
        {
            "Frank Darabont", "Francis Ford Coppola", "Orson Welles","Sidney Lumet", "Steven Spielberg", "Sergio Leone","Irvin Kershner","Peter Jackson","Christopher Nolan","Francis Ford Coppola","Quentin Tarantino","David Fincher","Alfred Hitchcock", "Stanley Kubrick", "Fritz Lang", "George Lucas", "Peter Jackon","James Cameron", "Lana Wachowski, Lilly Wachowski", "Steven Spielberg", "Michael Curtiz","Victor Fleming etc...", "Akira Kurosawa","Robert Zemeckis","Christopher Nolan"
        };

        public List<string> playTime = new List<string>()
        {
            "2h:22m", "2h:55m", "1h:59m", "1h:36m", "3h:15m","2h:58m", "2h:4m","3h:21m", "2h:32m", "3h:25m","2h:34m","2h:19m","1h:49m", "2h:29m", "2h:33m", "2h:1m", "2h:58m","2h:17m","2h:16m","1h:55m","1h:42m","1h,42m","3h:27m", "2h:22m","2h:28m"
        };

        public List<double> moviePrice = new List<double>()
        {
            49.90, 19.39, 150.00, 45.50,79.90,12.50,119.50, 65.50,99.90, 95.90,139.90,25.50,89.90,99.90, 125.50, 39.50,27.50,49.90,80.00,45.00,139.90,49.50,19.90,75.50,119.90
        };

        public List<int> movieRating = new List<int>()
        {
            9,5,7,2,6,6,5,8,2,8,3,9,10,4,7,10,8,5,1,1,4,9,4,7,3
        };
    }
}