using Microsoft.EntityFrameworkCore;
using TunifyPlatform.Data;
using TunifyPlatform.Models;
using TunifyPlatform.Repositories.Interfaces;

namespace TunifyPlatform.Repositories.Services
{
    public class SongService : ISongs
    {
        private readonly TunifyDbContext _context;

        public SongService(TunifyDbContext context)
        {
            _context = context;
        }

        public async Task<Song> CreateSong(Song song)
        {
            try
            {
                _context.Song.Add(song);
                await _context.SaveChangesAsync();

            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);

            }
            return song;
        }

        public async Task DeleteSong(int id)
        {
            try
            {
                var song = await GetSongById(id);
                _context.Song.Remove(song);
                await _context.SaveChangesAsync();
            }


            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

        public async Task<List<Song>> GetAllSongs()
        {
            List<Song> allSongs = new List<Song>();
            try
            {
                allSongs = await _context.Song.ToListAsync();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return allSongs;
        }

        public async Task<Song> GetSongById(int songId)
        {
            try
            {
                var song = await _context.Song.FindAsync(songId);
                return song;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Song> UpdateSong(int id, Song song)
        {
            try
            {
                var exsitingSong = await _context.Song.FindAsync(id);
                exsitingSong = song;
                await _context.SaveChangesAsync();
                return exsitingSong;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
