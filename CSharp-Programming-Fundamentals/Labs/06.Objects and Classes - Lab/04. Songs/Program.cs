using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                var songInfo = Console.ReadLine()
                    .Split("_", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Song song = new Song(songInfo[0], songInfo[1], songInfo[2]);
                songs.Add(song);
                
            }
            string currentType = Console.ReadLine();
            if (currentType=="all")
            {
                Console.WriteLine(string.Join(Environment.NewLine,songs));
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, songs.Where(x => x.TypeSong==currentType)));
            }
        }
        public class Song
        {
            public string TypeSong;
            public string Name;
            public string Time;
            public Song(string typeSong, string name , string time)
            {
                this.TypeSong = typeSong;
                this.Name = name;
                this.Time = time;
            }
            public Song()
            {

            }
            public override string ToString()
            {
                return Name;
            }
        }
    }
}
