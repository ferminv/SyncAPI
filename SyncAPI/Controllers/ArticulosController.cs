using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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

        private List<string> _codigosNuevos = new List<string>();

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

        // POST: api/Articulos
        [HttpPost]
        public async Task<ActionResult<Articulo>> PostArticulo(Articulo articulo)
        {
            _context.Articulos.Add(articulo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetArticulo), new { id = articulo.Id }, articulo);
        }

        // PUT: api/Articulos/5
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

        // GET: api/Articulos/MultiplesArticulos/[Guid]idSyncIdentifier
        [HttpGet]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<IEnumerable<Articulo>>> MultiplesArticulos(Guid idSyncIdentifier, [FromQuery(Name = "codigos")] List<string> codigos)
        {
            var articulos = await _context.Articulos.Where(x => (x.IDSyncIdentifier == idSyncIdentifier) && (codigos.Contains(x.CodigoPereira))).ToListAsync();
            return Ok(articulos); //devolvemos los articulos que el cliente no tiene en su bd (los nuevos)
        }

        // POST: api/Articulos/MultiplesArticulos
        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Articulo>> MultiplesArticulos(IEnumerable<Articulo> articulos)
        {
            var idSyncIdentifier = articulos.FirstOrDefault().IDSyncIdentifier;

            //EliminarArticulos(idSyncIdentifier);

            var syncIdentifier = _context.SyncIdentifiers.Find(idSyncIdentifier);
            syncIdentifier.UltimaFechaActualizacion = DateTime.Today.Date;

            _context.Articulos.AddRange(articulos);

            await _context.SaveChangesAsync();

            return Ok();
        }

        private void EliminarArticulos(Guid idSyncIdentifier)
        {
            _context.Database.ExecuteSqlRaw("DELETE TOP(100) PERCENT FROM [Articulos] WHERE IDSyncIdentifier = {0}", idSyncIdentifier);
            _context.SaveChangesAsync();
        }

        private void EliminarArticulosSyncInicial(Guid idSyncIdentifier)
        {
            _context.Database.ExecuteSqlRaw("DELETE TOP(100) PERCENT FROM [ArticulosSyncInicial] WHERE IDSyncIdentifier = {0}", idSyncIdentifier);
            _context.SaveChangesAsync();
        }

        // GET: api/Articulos/Codigos/[Guid]idSyncIdentifier
        [HttpGet]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<IEnumerable<String>>> Codigos(Guid idSyncIdentifier)
        {
            var codigos = await _context.Precios.Where(x => x.IDSyncIdentifier == idSyncIdentifier).Select(x => x.CodigoPereira).ToListAsync();
            return Ok(codigos);
        }

        // POST: api/Articulos/Codigos/[Guid]idSyncIdentifier
        [HttpPost]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<IEnumerable<String>>> Codigos(Guid idSyncIdentifier, [FromBody]IEnumerable<String> codigos) 
        {
            var codigosArticulos = await _context.Articulos.Where(x => x.IDSyncIdentifier == idSyncIdentifier).Select(x => x.CodigoPereira).ToListAsync();

            var codigosNuevos = new List<string>();

            foreach (var codigoArti in codigosArticulos)
            {
                if (!codigos.Contains(codigoArti))
                    codigosNuevos.Add(codigoArti);
            }

            return Ok(codigosNuevos); //Retorna codigos de los articulos que no tiene localmente el cliente
        }

        //--------PRECIOS-------------------

        // GET: api/Articulos/Precios/[Guid]idSyncIdentifier
        [HttpGet]
        [Route("[action]/{idSyncIdentifier}/{ultimaFechaSincronizacionLocal}")]
        public async Task<ActionResult<IEnumerable<Precio>>> Precios(Guid idSyncIdentifier, DateTime ultimaFechaSincronizacionLocal)
        {
            var precios = await _context.Precios.Where(x => x.IDSyncIdentifier == idSyncIdentifier && x.FechaActualizacion >= ultimaFechaSincronizacionLocal).ToListAsync();
            return Ok(precios);
        }

        // POST: api/Articulos/Precios/true-or-false
        //BORRO Y VUELVO A AGREGAR EN LUGAR DE MODIFICAR (PUT) PORQUE LA TABLA NO ESTA RELACIONADA CON OTRA, POR LO CUAL ES LO MISMO Y MAS RAPIDO
        [HttpPost]                                        
        [Route("[action]/{borrarPrevios}")]
        public async Task<ActionResult<Precio>> Precios(IEnumerable<Precio> precios, Boolean borrarPrevios) 
        {
            var idSyncIdentifier = precios.FirstOrDefault().IDSyncIdentifier;

            if (borrarPrevios)
            {
                //EliminarPrecios(idSyncIdentifier, codigos);
                var codigos = precios.Select(x => x.CodigoPereira).ToList();
                var subListasCodigos = DividirLista<string>(codigos, 2000);
                foreach (var listaCodigos in subListasCodigos)
                {
                    var preciosABorrar = _context.Precios.Where(x => listaCodigos.Contains(x.CodigoPereira));
                    _context.Precios.RemoveRange(preciosABorrar);
                }
            }

            var syncIdentifier = _context.SyncIdentifiers.Find(idSyncIdentifier);
            syncIdentifier.UltimaFechaActualizacion = DateTime.Today.Date;

            _context.Precios.AddRange(precios);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private void EliminarPrecios(Guid idSyncIdentifier, List<String> codigos)
        {
            _context.Database.ExecuteSqlRaw("DELETE TOP(100) PERCENT FROM dbo.Precios WHERE IDSyncIdentifier = {0}", idSyncIdentifier);
            _context.SaveChangesAsync();
        }

        public static IEnumerable<List<T>> DividirLista<T>(List<T> lista, int tamañoSubListas)
        {
            for (int i = 0; i < lista.Count; i += tamañoSubListas)
                yield return lista.GetRange(i, Math.Min(tamañoSubListas, lista.Count - i));
        }

        //SINCRONIZACION DE IMAGENES
        // POST: api/Articulos/MultiplesArticulos
        [DisableRequestSizeLimit]
        [HttpPost]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<Imagen>> Imagenes(Guid idSyncIdentifier, IEnumerable<Imagen> imagenes)
        {
            EliminarImagenes(idSyncIdentifier);

            _context.Imagenes.AddRange(imagenes);

            await _context.SaveChangesAsync();

            return Ok();
        }

        private void EliminarImagenes(Guid idSyncIdentifier)
        {
            _context.Database.ExecuteSqlRaw("DELETE TOP(100) PERCENT FROM dbo.Imagenes WHERE IDSyncIdentifier = {0}", idSyncIdentifier);
            _context.SaveChangesAsync();
        }

        [DisableRequestSizeLimit]
        [HttpGet]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<IEnumerable<Imagen>>> Imagenes(Guid idSyncIdentifier)
        {
            var imagenes = await _context.Imagenes.Where(x => x.IDSyncIdentifier == idSyncIdentifier).ToListAsync();

            return Ok(imagenes);
        }


        //SYNC INICIAL

        // POST: api/Articulos/MultiplesArticulosSyncInicial
        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<ArticuloSyncInicial>> MultiplesArticulosSyncInicial(IEnumerable<ArticuloSyncInicial> articulosSyncInicial)
        {
            _context.ArticulosSyncInicial.AddRange(articulosSyncInicial);

            await _context.SaveChangesAsync();

            return Ok();
        }

        // GET: api/Articulos/MultiplesArticulosSyncInicial/[Guid]idSyncIdentifier
        [HttpGet]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<IEnumerable<Articulo>>> MultiplesArticulosSyncInicial(Guid idSyncIdentifier)
        {
            var articulos = await _context.ArticulosSyncInicial.Where(x => (x.IDSyncIdentifier == idSyncIdentifier)).ToListAsync();
            EliminarArticulosSyncInicial(idSyncIdentifier);
            return Ok(articulos); 
        }
    }
}
