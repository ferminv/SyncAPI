using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SyncAPI.Data;
using SyncAPI.Models;

namespace SyncAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SyncIdentifiersController : ControllerBase
    {
        private readonly DBContext _context;

        public SyncIdentifiersController(DBContext context)
        {
            _context = context;
        }

        // GET: api/SyncIdentifiers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SyncIdentifier>>> GetSyncIdentifiers()
        {
            return await _context.SyncIdentifiers.ToListAsync();
        }

        // GET: api/SyncIdentifiers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SyncIdentifier>> GetSyncIdentifier(Guid id)
        {
            var syncIdentifier = await _context.SyncIdentifiers.FindAsync(id);

            if (syncIdentifier == null)
            {
                return NotFound();
            }

            return syncIdentifier;
        }

        // PUT: api/SyncIdentifiers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSyncIdentifier(Guid id, SyncIdentifier syncIdentifier)
        {
            if (id != syncIdentifier.Id)
            {
                return BadRequest();
            }

            _context.Entry(syncIdentifier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SyncIdentifierExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SyncIdentifiers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<SyncIdentifier>> PostSyncIdentifier(SyncIdentifier syncIdentifier)
        {
            _context.SyncIdentifiers.Add(syncIdentifier);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSyncIdentifier", new { id = syncIdentifier.Id }, syncIdentifier);
        }

        // DELETE: api/SyncIdentifiers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SyncIdentifier>> DeleteSyncIdentifier(Guid id)
        {
            var syncIdentifier = await _context.SyncIdentifiers.FindAsync(id);
            if (syncIdentifier == null)
            {
                return NotFound();
            }

            _context.SyncIdentifiers.Remove(syncIdentifier);
            await _context.SaveChangesAsync();

            return syncIdentifier;
        }

        private bool SyncIdentifierExists(Guid id)
        {
            return _context.SyncIdentifiers.Any(e => e.Id == id);
        }
    }
}
