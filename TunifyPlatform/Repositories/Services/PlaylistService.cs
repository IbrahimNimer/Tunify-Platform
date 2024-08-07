using Microsoft.EntityFrameworkCore;
using TunifyPlatform.Data;
using TunifyPlatform.Models;
using TunifyPlatform.Repositories.Interfaces;

namespace TunifyPlatform.Repositories.Services
{
    public class PlaylistService : IPlaylist
    {
        private readonly TunifyDbContext _context;

        public PlaylistService(TunifyDbContext context)
        {
            _context = context;
        }


        public async Task<Playlist> CreatePlaylist(Playlist playlist)
        {
            try
            {
                _context.Playlist.Add(playlist);
                await _context.SaveChangesAsync();

            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);

            }
            return playlist;
        }

        public async Task DeletePlaylist(int id)
        {
            try
            {
                var playlist = await GetPlaylistById(id);
                _context.Playlist.Remove(playlist);
                await _context.SaveChangesAsync();
            }


            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

        public async Task<List<Playlist>> GetAllPlaylist()
        {
            List<Playlist> allPlaylists = new List<Playlist>();
            try
            {
                allPlaylists = await _context.Playlist.ToListAsync();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return allPlaylists;
        }

        public async Task<Playlist> GetPlaylistById(int playlistId)
        {
            try
            {
                var playlist = await _context.Playlist.FindAsync(playlistId);
                return playlist;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Playlist> UpdatePlaylist(int id, Playlist playlist)
        {
            try
            {
                var exsitingPlaylist = await _context.Playlist.FindAsync(id);
                exsitingPlaylist = playlist;
                await _context.SaveChangesAsync();
                return exsitingPlaylist;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
