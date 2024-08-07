using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TunifyPlatform.Data;
using TunifyPlatform.Models;
using TunifyPlatform.Repositories.Interfaces;

namespace TunifyPlatform.Repositories.Services
{
    public class ArtistService : IArtist
    {


        private readonly TunifyDbContext _context;

        public ArtistService(TunifyDbContext context)
        {
            _context = context;
        }

        public async Task<Artist> CreateArtist(Artist artist)
        {
            try
            {
                _context.Artist.Add(artist);
                await _context.SaveChangesAsync();

            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);

            }
            return artist;
        }

        public async Task DeleteArtist(int id)
        {
            try
            {
                var artist = await GetArtistById(id);
                _context.Artist.Remove(artist);
                await _context.SaveChangesAsync();
            }


            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

        public async Task<List<Artist>> GetAllArtists()
        {
            List<Artist> allArtists = new List<Artist>();
            try
            {
                allArtists = await _context.Artist.ToListAsync();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return allArtists;
        }

        public async Task<Artist> GetArtistById(int artistId)
        {
            try
            {
                var artist = await _context.Artist.FindAsync(artistId);
                return artist;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Artist> UpdateArtist(int id, Artist Artist)
        {
            try
            {
                var exsitingArtist = await _context.Artist.FindAsync(id);
                exsitingArtist = Artist;
                await _context.SaveChangesAsync();
                return exsitingArtist;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}


