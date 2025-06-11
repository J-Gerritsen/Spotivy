using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Classes
{
    class Artist
    {
        public string Name;
        private List<Album> Albums = new List<Album>();
        private List<Song> Songs = new List<Song>();

        /**
         * this is to create a artist
         */
        public Artist(string name, List<Album> albums, List<Song> songs)
        {
            Name = name;
            Albums = albums;
            Songs = songs;
        }

        /**
         * this is to add a song
         */
        public void AddSong(Song song)
        {
            throw new NotImplementedException();
        }

        /**
         * this is to add a album 
         */
        public void AddAlbum(Album album)
        {
            throw new NotImplementedException();
        }
        /**
        * this is to change how strings are printed to improve clarity
        */
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
