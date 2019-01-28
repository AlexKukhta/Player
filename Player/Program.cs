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
            var player = new Player(new ColorSkin(ConsoleColor.Red));
            player.Volume = 20;

            int totalDuration = 0;

            player.Play();
            player.VolumeUp();
            Console.WriteLine(player.Volume);


            player.VolumeChange(-20);
            Console.WriteLine(player.Volume);
            Console.WriteLine(new string('-', 20));

            player.VolumeChange(400);
            Console.WriteLine(player.Volume);

            player.VolumeChange(500);
            Console.WriteLine(player.Volume);
            player.Stop()
            var songs = GenerateSongs();

            GenerateLikes(songs);
            songs = songs.SortByGenre(Genre.Rock);
            player.Songs = songs;
            player.Play();

            ListSongs(player.Songs);

            //var shuffledSongs = songs.Shuffle(3);

            //Console.WriteLine("SHUFFLE");
            //ListSongs(shuffledSongs);




            player.Stop();




            //var a = new Song[] { song1, song3 };
            Console.ReadLine();
        }

        //public static Tuple<string, TimeSpan, bool> GetSongData(Song songs)
        //{
        //    return new Tuple<string, TimeSpan, bool>(songs.name, songs.duration, false);
        //}

        public static void ListSongs(List<Song> songs)
        {
            for (var i = 0; i < songs.Count; i++)
            {
                Console.WriteLine("The song is starting play");

                for (var j = 0; j < songs.Count; j++)
                {
                    dynamic songData = GetSongData(songs[j], i == j);

                    TraceInfo(songData.title, songData.minutes, songData.seconds, songData.albumYear, songData.likeValue,
                        songData.genre, songData.isSongNext);
                }

                Console.WriteLine("The song is finishing play");
            }
        }

        public static object GetSongData(Song song, bool isSongNext)
        {
            song.Deconstruct(out LikeEnum likeValue, out TimeSpan duration, out string title, out string artistName,
                out Genre genre, out byte[] thumbnale, out string albumName, out int albumYear);

            return new
            {
                title,
                minutes = duration.Minutes,
                seconds = duration.Seconds,
                albumYear,
                likeValue,
                genre,
                isSongNext
            };
        }

        public static List<Song> FilterByGenre(List<Song> songs, Genre genre)
        {
            return songs.OrderBy(s => s.Artist.Genre).ToList();
        }

        public static void TraceInfo(string title, int minutes, int seconds, int albumYear, LikeEnum likeValue, Genre genre,
            bool isSongNext)
        {
            switch (likeValue)
            {
                case LikeEnum.NoneLike:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case LikeEnum.Like:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case LikeEnum.Dislike:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            Console.WriteLine($"Title {title}");
            Console.WriteLine($"Minutes {minutes}");
            Console.WriteLine($"Seconds {seconds}");
            Console.WriteLine($"AlbumYear {albumYear}");
            Console.WriteLine($"Genre {genre}");
            Console.WriteLine($"IsNextSong {isSongNext}");
            Console.WriteLine();
        }

        public static List<Song> GenerateSongs()
        {
            var songs = new List<Song>();
            var random = new Random();
            var songsCount = random.Next(5, 10);

            for (var i = 0; i < songsCount; i++)
            {
                var modulo = i % 3;
                var genre = Genre.Classic;

                if (modulo == 0)
                {
                    genre = Genre.HipHop;
                }
                else if (modulo == 1)
                {
                    genre = Genre.Rock;
                }

                var song = new Song(new TimeSpan(random.Next(24), random.Next(60), random.Next(60)), $"Title{i.ToString()}", new Artist($"Artist {i.ToString()}", genre), new Album());

                songs.Add(song);
            }

            return songs;
        }

        public static void GenerateLikes(List<Song> songs)
        {
            for (var i = 0; i < songs.Count(); i++)
            {
                var modulo = i % 3;

                if (modulo == 0)
                {
                    songs[i].Like();
                }
                else if (modulo == 1)
                {
                    songs[i].Dislike();
                }
            }
        }
    }
}
