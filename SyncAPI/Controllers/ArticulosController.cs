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
    public class ArticulosController : ControllerBase
    {
        private readonly DBContext _context;

        public ArticulosController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Articulos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Articulo>> GetArticulo(int id)
        {
            var articulo = await _context.Articulos.FindAsync(id);

            if (articulo == null)
            {
                return NotFound();
            }

            return articulo;
        }

        // GET: api/Articulos/MultiplesArticulos/[Guid]idSyncIdentifier
        [HttpGet]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<IEnumerable<Articulo>>> MultiplesArticulos(Guid idSyncIdentifier)
        {
            var articulos = await _context.Articulos.Where(x => x.IDSyncIdentifier == idSyncIdentifier).ToListAsync();
            return Ok(articulos);
        }

        // PUT: api/Articulos/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticulo(int id, Articulo articulo)
        {
            if (id != articulo.Id)
            {
                return BadRequest();
            }

            _context.Entry(articulo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticuloExists(id))
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

        // POST: api/Articulos/MultiplesArticulos
        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Articulo>> MultiplesArticulos(IEnumerable<Articulo> articulos)
        {
            var idSyncIdentifier = articulos.FirstOrDefault().IDSyncIdentifier;

            EliminarArticulos(idSyncIdentifier);

            var syncIdentifier = _context.SyncIdentifiers.Find(idSyncIdentifier);
            syncIdentifier.UltimaFechaActualizacion = DateTime.Today.Date;

            _context.Articulos.AddRange(articulos);

            await _context.SaveChangesAsync();

            return Ok();
        }

        // POST: api/Articulos
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Articulo>> PostArticulo(Articulo articulo)
        {
            _context.Articulos.Add(articulo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetArticulo), new { id = articulo.Id }, articulo);
        }

        // DELETE: api/Articulos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Articulo>> DeleteArticulo(int id)
        {
            var articulo = await _context.Articulos.FindAsync(id);
            if (articulo == null)
            {
                return NotFound();
            }

            _context.Articulos.Remove(articulo);
            await _context.SaveChangesAsync();

            return articulo;
        }

        private bool ArticuloExists(int id)
        {
            return _context.Articulos.Any(e => e.Id == id);
        }

        private void EliminarArticulos(Guid idSyncIdentifier)
        {
            _context.Database.ExecuteSqlRaw("DELETE TOP(100) PERCENT FROM [Articulos] WHERE IDSyncIdentifier = {0}", idSyncIdentifier);
            _context.SaveChangesAsync();
        }
    }
}
