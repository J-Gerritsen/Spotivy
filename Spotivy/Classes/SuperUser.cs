using Spotivy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Classes
{
    class SuperUser : Person
    {
        public SuperUser(string naam, List<Person> friends, List<Playlist> playlists) : base(naam, friends, playlists)
        {
        }

        /**
        * This is to add a friend
        */
        public void AddFriend(Person person)
        {
            Friends.Add(person);
        }

        /**
         * This is to remove a friend
         */
        private void RemoveFriend(Person person)
        {
            throw new NotImplementedException();
        }

        /**
         * This is to create a playlist
         */
        private Playlist CreatePlayList(string name)
        {
            throw new NotImplementedException();
        }

        /**
         * This is to remove a playlist
         */
        private void RemovePlaylist(int index)
        {
            throw new NotImplementedException();
        }

        /**
         * This is to add a song to a playlist
         */
        private void AddToPlayList(iPlayable iPlayable) 
        {
            throw new NotImplementedException();
        }

        /**
         * This is to remove a song from a playlist
         */
        private void RemoveFromPlayList(iPlayable iPlayable)
        {
            throw new NotImplementedException();
        }
    }
}
