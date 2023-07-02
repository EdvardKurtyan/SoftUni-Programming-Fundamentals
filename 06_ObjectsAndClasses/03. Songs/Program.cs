//Define a class called Song that will hold the following information about some songs:
//•	Type List
//•	Name
//•	Time
//Input / Constraints
//•	On the first line, you will receive the number of songs - N.
//•	On the next N lines, you will be receiving data in the following format:  "{typeList}_{name}_{time}".
//•	On the last line, you will receive Type List or "all".
//Output
//If you receive Type List as an input on the last line, print out only the names of the songs, which are from that Type List.
//If you receive the "all" command, print out the names of all the songs.

using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < songsCount; i++)
            {
                string[] songProperty = Console.ReadLine().Split('_');

                Song song = new Song(songProperty[0], songProperty[1], songProperty[2]);

                songs.Add(song);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (Song songName in songs)
                {
                    Console.WriteLine(songName.Name);
                }
            }
            else
            {
                foreach (var songName in songs)
                {
                    if (songName.TypeList == command)
                    {
                        Console.WriteLine(songName.Name);
                    }
                }
            }
        }
    }
    class Song
    {
        public Song(string tipeList, string name, string time)
        {
            this.TypeList = tipeList;
            this.Name = name;
            this.Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
