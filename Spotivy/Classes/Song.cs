using Spotivy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Classes
{
    class Song : iPlayable
    {
        public string Title;
        public List<Artist> Artists = new List<Artist>();
        public Genres SongGenre;
        private int Length;

        /**
         * this is to create a song 
         */
        public Song(string title, List<Artist> artists, Genres songGenre)
        {
            Title = title;
            Artists = artists;
            SongGenre = songGenre;
        }

        int iPlayable.Length => throw new NotImplementedException();

        public void Next()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Stop()
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
