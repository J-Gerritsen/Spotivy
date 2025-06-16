using Spotivy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Classes
{
    class Album : SongCollection
    {
        private List<Artist> Artists = new();

        /**
         * this is to create a album
         */
        public Album(List<Artist> artists, List<Song> songs, string title) : base(title)
        {
            Artists = artists;
        }

        /**
         * this is to show the artists of the album
         */
        public List<Artist> ShowArtists()
        {
            return Artists;
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
