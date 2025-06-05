using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Classes
{
    class Album
    {
        private List<Artist> Artists = new List<Artist>();

        /**
         * this is to create a album
         */
        public Album(List<Artist> artists)
        {
            Artists = artists;
        }

        /**
         * this is to show the artists of the album
         */
        public List<Artist> ShowArtist()
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
