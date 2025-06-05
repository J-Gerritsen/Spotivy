using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Classes
{
    class SongCollection
    {
        public string Title;
        private List<iPlayable> Playables = new List<iPlayable>();

        /**
         * this is to create a SongCollection
         */
        public SongCollection(string title)
        {
            this.Title = title;
        }

        /**
         * this is to show the playables
         */
        public List<iPlayable> ShowPlayables()
        {
            return new List<iPlayable>();
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
