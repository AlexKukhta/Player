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

            int totalDuration = 0;
            
            player.Songs = GetSongsData(ref totalDuration,out int minDuration, out int maxDuration );
            Console.WriteLine($"Total: {totalDuration}, Min: {minDuration}, MAX {maxDuration}");

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


            var song1= CreateSong();

            player.Songs = new Songs[] { song1 };

            //var song2 = CreateNamedSongs("AcDc", 100);

            var song3 = CreateSong("Acdc", 200);

            player.Songs = new Songs[] { song1, song3 };
            player.Play();
            Console.ReadLine();
        }

        public static Songs[] GetSongsData(ref int totalDuration, out int minDuration, out int maxDuration)
        {
            minDuration = 1000;
            maxDuration = 0;

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

            var songs = new Songs[10];
            var random = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                var Songs = new Songs()
                {

                    duration = random.Next(1000),
                    name = $"Lajki{i}",
                    Album = album,
                    Artist = artist
                };
                songs[i] = Songs;

                totalDuration += Songs.duration;

                if (Songs.duration<minDuration)
                {
                    minDuration = Songs.duration;
                }
                maxDuration = Math.Max(maxDuration, Songs.duration);
            }

            return songs;
        }

        public static void TraceInfo(Player player)
        {
            Console.WriteLine(player.Songs[0].Artist.Name);
            Console.WriteLine(player.Songs[0].duration);
            Console.WriteLine(player.Songs.Length);
            Console.WriteLine(player.Volume);
        }

        public static Songs CreateSong()
        {
            return new Songs { name = "Uknown", duration=120};
        }


        //public static Songs CreateSong(Name=name, duration=100)
        //{
        //  return CreateSong(name, 120);
        //}

        public static Songs CreateSong(string name, int duration)
        {
            return new Songs { name = name, duration = duration };
        }


    }
}
