using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TunifyPlatform.Data;
using TunifyPlatform.Models;
using TunifyPlatform.Repositories.Interfaces;

namespace TunifyPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtist _context;

        public ArtistsController(IArtist context)
        {
            _context = context;
        }

        // GET: api/Artists
        [Route("/GetAllArtists")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artist>>> GetArtist()
        {
            return await _context.GetAllArtists();
        }

        // GET: api/Artists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Artist>> GetArtist(int id)
        {
            return await _context.GetArtistById(id);
        }

        // PUT: api/Artists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtist(int id, Artist artist)
        {
            var update = _context.UpdateArtist(id, artist);
            return Ok(update);
        }

        // POST: api/Artists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Artist>> PostArtist(Artist artist)
        {
            var add = _context.CreateArtist(artist);
            return Ok(add);
        }

        // DELETE: api/Artists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtist(int id)
        {
            var delete = _context.DeleteArtist(id);
            return Ok(delete);
        }

       
    }
}
