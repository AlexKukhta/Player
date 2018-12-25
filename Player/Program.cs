using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
           // player.Volume = 20;

            player.Songs = GetSongsData();

            //TraceInfo(player)

            player.Play();
            player.VolumeUp();
            Console.WriteLine(player.Volume);


            player.VolumeChange(-20);
            Console.WriteLine(player.Volume);
            Console.WriteLine(new string('-',20));

            player.VolumeChange(400);
            Console.WriteLine(player.Volume);

            player.VolumeChange(500);
            Console.WriteLine(player.Volume);
            player.Stop();

            Console.ReadLine();
        }

        public static Songs[] GetSongsData()
        {
            var artist = new Artist();
            artist.Genre = "rock";
            artist.Name = "Bi2";
            Console.WriteLine(artist.Genre);
            Console.WriteLine(artist.Name);

            var artist2 = new Artist("metall");
            Console.WriteLine(artist2.Genre);
            Console.WriteLine(artist2.Name);

            var artist3 = new Artist("AcDc", "rock-n-roll");
            Console.WriteLine(artist3.Name);
            Console.WriteLine(artist3.Genre);

            var album = new Album();
            album.name = "Rock";
            album.year = 2000;

            var songs = new Songs()
            {
                duration = 10,
                name = "Lajki",
                Album = album,
                Artist = artist
            };

            return new Songs[] { songs };
        }

        public static void TraceInfo(Player player)
        {
            Console.WriteLine(player.Songs[0].Artist.Name);
            Console.WriteLine(player.Songs[0].duration);
            Console.WriteLine(player.Songs.Length);
            Console.WriteLine(player.Volume);
        }
    }
}
