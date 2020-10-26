using System;
using System.Collections.Generic;
using System.Text;

namespace Hans_Johnnys_butik
{
    public class Albums
    {

        public List<string> songTitles = new List<string>()
        {
            "The Shawshark Redemmption", "The Godfather", "Citizen Kane", "Angry Men"        };

        public List<int> songRelease = new List<int>()
        {
            1994, 1972, 1941, 1957
        };

        public List<string> songArtist = new List<string>()
        {
            "Frank Darabont", "Francis Ford Coppola", "Orson Welles","Sidney Lumet", 
        };

        public List<string> songPlayTime = new List<string>()
        {
            "2h:22m", "2h:55m", "1h:59m", "1h:36m", 
        };

    }
}

