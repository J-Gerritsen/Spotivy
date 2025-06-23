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
        public Client(List<Person> persons, List<Album> albums, List<Song> songs)
        {
            throw new NotImplementedException();
        }

        /**
         * This is to log in as a certain user
         */
        public void SetActiveUser(Person person)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
        public void Play(Song song)
        {
            Playing = true;
            int i = 0;
            Console.WriteLine($"playing {song.Play}");

            while (Playing)
            {
                Console.WriteLine($"currently playing: {song.Play}");
                Thread.Sleep(1000); //wait for 1 second
                i++;

                if (i > song.length)
                {
                    Console.WriteLine($"Song {song.Play} finished");
                    Playing = false;
                    i = 0;
                }
            }

        }

        /**
         * This is to pause something
         */
        public void Pause()
        {
            
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
            throw new NotImplementedException();
        }

        public void SelectFriend(int index)
        {
            throw new NotImplementedException();
        }

        public void AddFriend(int index)
        {
            throw new NotImplementedException();
        }

        public void RemoveFriend(int index)
        {
            throw new NotImplementedException();
        }
    }
}
