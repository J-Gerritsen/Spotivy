using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Classes
{
    class Song
    {
        public string Title;
        public List<Artist> Artists = new List<Artist>();
        public Genre SongGenre;
        private int Length;

        /**
         * this is to create a song 
         */
        public Song(string title, List<Artist> artists, Genre songGenre)
        {
            Title = title;
            Artists = artists;
            SongGenre = songGenre;
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
