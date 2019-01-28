using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Player
{
    class Song
    {
        public LikeEnum LikeValue { get; private set; }
        public TimeSpan Duration { get; }
        public string Title { get; }
        public Artist Artist { get; }
        public Album Album { get; }

        public Song(TimeSpan duration, string title, Artist artist, Album album)
        {
            Duration = duration;
            Title = title;
            Artist = artist;
            Album = album;
            LikeValue = LikeEnum.NoneLike;
        }

        public void Like()
        {
            LikeValue = LikeEnum.Like;
        }

        public void Dislike()
        {
            LikeValue = LikeEnum.Dislike;
        }

        public void Deconstruct(out LikeEnum likeValue, out TimeSpan duration, out string title, out string artistName,
            out Genre genre, out byte[] thumbnale, out string albumName, out int albumYear)
        {
            likeValue = LikeValue;
            duration = Duration;
            title = Title;
            artistName = string.Empty;
            genre = Artist.Genre;
            thumbnale = new byte[0];
            albumName = string.Empty;
            albumYear = Album.Year;
        }
    }
}
