using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Classes
{
    class Playlist
    {
        public Person Owner;

        /**
         * this is to create a Playlist
         */
        public Playlist(Person owner)
        {
            Owner = owner;
        }

        /**
         * ??
         */
        public void Add(iPlayable iPlayable)
        {

        }

        /**
         * ??
         */
        public void Remove(iPlayable iPlayable)
        {

        }

        /**
        * this is to change how strings are printed to improve clarity
        */
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
