using System;
using System.Collections;

namespace Tutorial
{

    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Player(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public class Team : IEnumerable
        {
            private Player[] playerArray = new Player[4];

            public Team()
            {
                playerArray[0] = new Player("Kenny", 28);
                playerArray[1] = new Player("Anders", 35);
                playerArray[2] = new Player("Peter", 29);
                playerArray[3] = new Player("Lars", 34);
            }

            public IEnumerator GetEnumerator()
            {
                return playerArray.GetEnumerator();
            }
        }
        public class Program
        {
            static void Main(string[] args)
            {

                Team obj = new Team();

                foreach (var player in obj)
                {
                    //Console.WriteLine($"Name is {player.name} and Age is {player.age}");
                }
            }
        }
    }
}
