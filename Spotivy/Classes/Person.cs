using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Classes
{
    class Person
    {
        public string Naam { get; set; }
        private List<Person> Friends = new();
        private List<Playlist> Playlists = new();
        
        /**
         * This is to create a Person
         */
        public Person(string naam, List<Person> friends, List<Playlist> playlists)
        {
            Naam = naam;
            Friends = friends;
            Playlists = playlists;
        }

        /**
         * This is to show a list of all your friends
         */
        public List<Person> ShowFriends()
        {
            throw new NotImplementedException();
        }

        /**
         * This is to show a list of all playlists you have
         */
        public List<Playlist> ShowPlaylists()
        {
            throw new NotImplementedException();
        }

        /**
         * This is for selecting a playlist
         */
        public int SelectPlaylist(Playlist playlist)
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