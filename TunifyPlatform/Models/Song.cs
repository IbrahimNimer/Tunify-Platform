namespace TunifyPlatform.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        public ICollection<PlaylistSongs> playlistSongs { get; set; }
    }
}
