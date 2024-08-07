using TunifyPlatform.Models;

namespace TunifyPlatform.Repositories.Interfaces
{
    public interface ISongs
    {
        Task<Song> CreateSong(Song song);
        Task<List<Song>> GetAllSongs();
        Task<Song> GetSongById(int songId);

        Task<Song> UpdateSong(int id, Song song);

        Task DeleteSong(int id);

    }
}
