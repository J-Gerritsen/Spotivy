using Spotivy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy.Classes
{
    class Client
    {
        public iPlayable CurrentlyPlaying { get; set; }
        public int CurrentTime { get; set; }
        public bool Playing { get; set; }
        public bool Shuffle { get; set; }
        public bool Repeat { get; set; }
        private SuperUser ActiveUser { get; set; }
        private List<Album> AllAlbums { get; set; }
        private List<Song> AllSongs { get; set; }
        private List<Person> AllUsers { get; set; }

        /**
         * This is to create a Client
         */
        public Client(List<Person> allUsers, List<Album> allAlbums, List<Song> allSongs)
        {
            AllUsers = allUsers;
            AllAlbums = allAlbums;
            AllSongs = allSongs;
        }

        /**
         * This is to log in as a certain user
         */
        public void SetActiveUser(Person person)
        {
            if (person is SuperUser)
            {
                ActiveUser = (SuperUser)person;
            }
        }

        /**
         * This is to show a list of all albums
         */
        public void ShowAllAlbums()
        {
            throw new NotImplementedException();
        }

        /**
         * This is to select an album
         */
        public void SelectAlbum(int index)
        {
            throw new NotImplementedException();
        }

        /**
         * This is to show all songs
         */
        public void ShowAllSongs()
        {
            throw new NotImplementedException();
        }

        /**
         * This is to select a song
         */
        public void SelectSong(int index)
        {
            throw new NotImplementedException();
        }

        /**
         * This is to show all users
         */
        public void ShowAllUsers()
        {
            for (int i = 0; i < AllUsers.Count; i++)
            {
                Console.WriteLine($"{i}: {AllUsers[i].Name}");
            }
        }

        /**
         * This is to select a user
         */
        public void SelectUser(int index)
        {
            throw new NotImplementedException();
        }

        /**
         * This is to show a user's playlist
         */
        public void ShowUserPlaylists()
        {
            throw new NotImplementedException();
        }

        /**
         * This is to select a user's playlist
         */
        public void SelectUserPlaylist(int index)
        {
            throw new NotImplementedException();
        }

        /**
         * This is to play something
         */
        public void Play()
        {
            throw new NotImplementedException();
        }

        /**
         * This is to pause something
         */
        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void NextSong()
        {
            throw new NotImplementedException();
        }

        public void SetShuffle(bool shuffle)
        {
            throw new NotImplementedException();
        }

        public void SetRepeat(bool repeat)
        {
            throw new NotImplementedException();
        }

        public void CreatePlaylist(string name)
        {
            throw new NotImplementedException();
        }

        public void ShowPlaylists()
        {
            throw new NotImplementedException();
        }

        public void SelectPlaylist(int index)
        {
            throw new NotImplementedException();
        }

        public void RemovePlaylist(int index)
        {
            throw new NotImplementedException();
        }

        public void AddToPlaylist(int index)
        {
            throw new NotImplementedException();
        }

        public void ShowSongsInPlaylist()
        {
            throw new NotImplementedException();
        }

        public void RemoveFromPlaylist(int index)
        {
            throw new NotImplementedException();
        }

        public void ShowFriends()
        {
            List<Person> friends = ActiveUser.ShowFriends();

            for (int i = 0; i < friends.Count; i++)
            {
                Console.WriteLine($"{i}: {friends[i].Name}");
            }
        }

        public void SelectFriend(int index)
        {
            throw new NotImplementedException();
        }

        public void AddFriend(int index)
        {
            if (index >= 0 && index < AllUsers.Count)
            {
                Person friend = AllUsers[index];

                ActiveUser.AddFriend(friend);

                Console.WriteLine($"{friend.Name} is your friend.");
            }
        }

        public void RemoveFriend(int index)
        {
            throw new NotImplementedException();
        }
    }
}
