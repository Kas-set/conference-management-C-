using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EntityFrameworkCoreMySQL.Data;
using EntityFrameworkCoreMySQL.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreMySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConferenceController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ConferenceController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Conference>>> GetConferences()
        {
            return await _context.Conferences.Include(c => c.Articles).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Conference>> GetConference(int id)
        {
            var conference = await _context.Conferences.Include(c => c.Articles)
                                                       .FirstOrDefaultAsync(c => c.IdConf == id);

            if (conference == null)
            {
                return NotFound();
            }

            return conference;
        }

        [HttpPost]
        public async Task<ActionResult<Conference>> PostConference(Conference conference)
        {
            _context.Conferences.Add(conference);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetConference), new { id = conference.IdConf }, conference);
        }

    }
}
