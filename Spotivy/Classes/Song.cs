using Spotivy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotivy.Interfaces;

namespace Spotivy.Classes
{
    class Song : iPlayable
    {
        public string Title;
        public List<Artist> Artists = new List<Artist>();
        public Genres SongGenre;
        private int Length;


        // make this in the client because only one thing can be played at a time and not every song needs to check if they are playing or not
        private Boolean Playing = false;
         
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
            Playing = false;
            Console.WriteLine($"song {Title} is gepauzeerd");
        }

        public void Play()
        {
            Playing = true;
            int i = 0;
            Console.WriteLine($"playing {Title}");
            
            while (Playing)
            {
                Console.WriteLine($"currently playing: {Title}");
                Thread.Sleep(1000); //wait for 1 second
                i++;

                if (i > Length)
                {
                    Console.WriteLine($"Song {Title} finished");
                    Playing = false;
                    i = 0;
                }
            }
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
