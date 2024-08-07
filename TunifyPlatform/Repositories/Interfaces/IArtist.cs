using TunifyPlatform.Models;

namespace TunifyPlatform.Repositories.Interfaces
{
    public interface IArtist
    {

        Task<Artist> CreateArtist(Artist artist);
        Task<List<Artist>> GetAllArtists();
        Task<Artist> GetArtistById(int artistId);

        Task<Artist> UpdateArtist(int id, Artist Artist);

        Task DeleteArtist(int id);
    }
}
