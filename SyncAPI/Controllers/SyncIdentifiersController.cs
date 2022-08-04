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
        private readonly ISyncDataService _svc;

        public SyncIdentifiersController(DBContext context, ISyncDataService svc)
        {
            _context = context;
            _svc = svc;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SyncIdentifier>>> GetSyncIdentifiers()
        {
            return await _context.SyncIdentifiers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SyncIdentifier>> GetSyncIdentifier(Guid id)
        {
            var syncIdentifier = await _svc.GetSyncIdentifier(id);

            if (syncIdentifier == null)
                return NotFound();

            return syncIdentifier;
        }

        // PUT: api/SyncIdentifiers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSyncIdentifier(Guid id, SyncIdentifier syncIdentifier)
        {
            if (id != syncIdentifier.Id)
                return BadRequest();

            try
            {
                await _svc.UpdateSyncIdentifier(syncIdentifier);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SyncIdentifierExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<SyncIdentifier>> PostSyncIdentifier(SyncIdentifier syncIdentifier) //SI SE USA, TENER EN CUENTA QUE YA TIENE QUE VENIR CON UN GUID DE ID, SE PENSO PARA CREARLOS POR DB
        {
            await _svc.AddSyncIdentifier(syncIdentifier);

            return CreatedAtAction("GetSyncIdentifier", new { id = syncIdentifier.Id }, syncIdentifier);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SyncIdentifier>> DeleteSyncIdentifier(Guid id)
        {
            var syncIdentifier = await _svc.GetSyncIdentifier(id);

            if (syncIdentifier == null)
                return NotFound();

            await _svc.RemoveSyncIdentifier(syncIdentifier);

            return syncIdentifier;
        }

        private bool SyncIdentifierExists(Guid id)
        {
            return _svc.SyncIdentifierExists(id);
        }
    }
}
