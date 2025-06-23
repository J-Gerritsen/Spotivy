using Spotivy.Classes;

namespace Spotivy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Album> artist1Albums = [];
            List<Song> artist1Songs = [];

            Artist artist1 = new("artist1", artist1Albums, artist1Songs);

            List<Artist> songArtists = [artist1];

            Song song1 = new("song1", songArtists, Genres.Rock);

            List<Song> albumSongs = [song1];

            List<Artist> albumArtists = [artist1];
            
            Album album1 = new(albumArtists, albumSongs, "album1");

            artist1.AddSong(song1);
        }
    }
}
