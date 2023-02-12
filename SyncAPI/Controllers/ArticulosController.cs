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

        private readonly ISyncDataService _svc;

        private List<string> _codigosNuevos = new List<string>();

        public ArticulosController(DBContext context, ISyncDataService svc)
        {
            _context = context;
            this._svc = svc;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Articulo>> GetArticulo(int id)
        {
            var articulo = await _svc.Articulos.Get(id);

            if (articulo is null)
                return NotFound();

            return articulo;
        }

        [HttpPost]
        public async Task<ActionResult<Articulo>> PostArticulo(Articulo articulo)
        {
            await _svc.Articulos.Add(articulo);

            return CreatedAtAction(nameof(GetArticulo), new { id = articulo.Id }, articulo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticulo(int id, Articulo articulo)
        {
            if (id != articulo.Id)
            {
                return BadRequest();
            }

            try
            {
                await _svc.Articulos.Update(articulo);
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

        [HttpDelete("{id}")]
        public async Task<ActionResult<Articulo>> DeleteArticulo(int id)
        {
            var articulo = await _svc.Articulos.Get(id);
            if (articulo is null)
                return NotFound();

            await _svc.Articulos.Remove(articulo);

            return articulo;
        }

        private bool ArticuloExists(int id)
        {
            return _svc.Articulos.Exists(id);
        }

        // DEPRECATED, WILL BE REMOVED
        [HttpGet]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<IEnumerable<Articulo>>> MultiplesArticulos(Guid idSyncIdentifier, [FromQuery(Name = "codigos")] List<string> codigos)
        {
            var articulos = await _context.Articulos.Where(x => (x.IDSyncIdentifier == idSyncIdentifier) && (codigos.Contains(x.CodigoPereira))).ToListAsync();
            return Ok(articulos); //devolvemos los articulos que el cliente no tiene en su bd (los nuevos)
        }

        [HttpPost]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<IEnumerable<Articulo>>> GetMultiplesArticulos(Guid idSyncIdentifier, [FromBody]IEnumerable<String> codigos)
        {
            var articulos = await _svc.Articulos.GetByCodes(idSyncIdentifier, codigos);

            return Ok(articulos); //devolvemos los articulos que el cliente no tiene en su bd (los nuevos)
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Articulo>> MultiplesArticulos(IEnumerable<Articulo> articulos)
        {
            var idSyncIdentifier = articulos.FirstOrDefault()?.IDSyncIdentifier;

            if (idSyncIdentifier is null)
                return BadRequest();

            var syncIdentifier = await _svc.GetSyncIdentifier((Guid)idSyncIdentifier);
            syncIdentifier.UltimaFechaActualizacion = DateTime.Today.Date;

            await _svc.UpdateSyncIdentifier(syncIdentifier);

            await _svc.Articulos.AddCollection(articulos);

            return Ok();
        }

        [HttpGet]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<IEnumerable<String>>> Codigos(Guid idSyncIdentifier)
        {
            var codigosPrecios = await _svc.Precios.GetCodigos(idSyncIdentifier);
            return Ok(codigosPrecios);
        }

        [HttpPost]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<IEnumerable<String>>> Codigos(Guid idSyncIdentifier, [FromBody]IEnumerable<String> codigos) 
        {
            var codigosArticulos = await _svc.Articulos.GetCodigos(idSyncIdentifier);

            var codigosNuevos = codigosArticulos.Except(codigos, StringComparer.OrdinalIgnoreCase); //obtenemos los codigos que no estan en la lista "codigos"

            return Ok(codigosNuevos); //Retorna codigos de los articulos que no tiene localmente el cliente
        }

        //--------PRECIOS------------------

        [HttpGet]
        [Route("[action]/{idSyncIdentifier}/{ultimaFechaSincronizacionLocal}")]
        public async Task<ActionResult<IEnumerable<Precio>>> Precios(Guid idSyncIdentifier, DateTime ultimaFechaSincronizacionLocal)
        {
            var precios = await _svc.Precios.GetByLastSyncDate(idSyncIdentifier, ultimaFechaSincronizacionLocal);

            return Ok(precios);
        }

        [HttpPost]                                        
        [Route("[action]/{borrarPrevios}")]
        public async Task<ActionResult<Precio>> Precios(IEnumerable<Precio> precios, Boolean borrarPrevios) 
        {
            var idSyncIdentifier = precios.FirstOrDefault()?.IDSyncIdentifier;

            if (idSyncIdentifier is null)
                return BadRequest();

            //BORRO Y VUELVO A AGREGAR EN LUGAR DE MODIFICAR (PUT) PORQUE LA TABLA NO ESTA RELACIONADA CON OTRA, POR LO CUAL ES LO MISMO Y MAS RAPIDO
            //if (borrarPrevios)
            await _svc.Precios.RemoveCollection((Guid)idSyncIdentifier, precios);

            await _svc.Precios.AddCollection(precios);

            var syncIdentifier = await _svc.GetSyncIdentifier((Guid)idSyncIdentifier);
            syncIdentifier.UltimaFechaActualizacion = DateTime.Today;
            await _svc.UpdateSyncIdentifier(syncIdentifier);

            return Ok();
        }

        [HttpGet]
        [Route("[action]/{idSyncIdentifier}/{ultimaFechaSincronizacionLocal}/{iteracion}/{cantidad}")]
        public async Task<ActionResult<IEnumerable<Precio>>> PreciosParcial(Guid idSyncIdentifier, DateTime ultimaFechaSincronizacionLocal, Int32 iteracion, Int32 cantidad)
        {
            var precios = await _svc.Precios.GetByLastSyncDateParcial(idSyncIdentifier, ultimaFechaSincronizacionLocal, iteracion, cantidad);

            return Ok(precios);
        }

        [HttpGet]
        [Route("[action]/{idSyncIdentifier}/{ultimaFechaSincronizacionLocal}")]
        public async Task<ActionResult<Int32>> CantidadPrecios(Guid idSyncIdentifier, DateTime ultimaFechaSincronizacionLocal)
        {
            //CANTIDAD PRECIOS ACTUALIZADOS
            var cantidadPrecios = await _svc.Precios.GetUpdatedCount(idSyncIdentifier, ultimaFechaSincronizacionLocal);

            return Ok(cantidadPrecios);
        }

        //SINCRONIZACION DE IMAGENES
        [DisableRequestSizeLimit]
        [HttpGet]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<IEnumerable<Imagen>>> Imagenes(Guid idSyncIdentifier)
        {
            var imagenes = await _svc.Imagenes.GetAll(idSyncIdentifier);

            return Ok(imagenes);
        }

        [DisableRequestSizeLimit]
        [HttpPost]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<Imagen>> Imagenes(Guid idSyncIdentifier, IEnumerable<Imagen> imagenes)
        {
            await _svc.Imagenes.RemoveAll(idSyncIdentifier);

            await _svc.Imagenes.AddCollection(imagenes);

            return Ok();
        }

        //SYNC INICIAL

        [HttpGet]
        [Route("[action]/{idSyncIdentifier}/{iteracion}/{cantidad}/{ultimoGet}")]
        public async Task<ActionResult<IEnumerable<Articulo>>> MultiplesArticulosSyncInicial(Guid idSyncIdentifier, Int32 iteracion, Int32 cantidad, Boolean ultimoGet)
        {
            var articulos = await _svc.Articulos.GetParcialSyncInicial(idSyncIdentifier, iteracion, cantidad);
            //SI ES EL ULTIMO GET ELIMINAMOS TODOS PARA LIMPIAR LA BASE
            if (ultimoGet)
                await _svc.Articulos.EliminarArticulosSyncInicial(idSyncIdentifier); 

            return Ok(articulos);
        }

        [DisableRequestSizeLimit]
        [HttpPost]
        [Route("[action]/{primerPost}")]
        public async Task<ActionResult<ArticuloSyncInicial>> MultiplesArticulosSyncInicial(IEnumerable<ArticuloSyncInicial> articulosSyncInicial, Boolean primerPost)
        {
            var idSyncIdentifier = articulosSyncInicial.FirstOrDefault()?.IDSyncIdentifier;

            if (idSyncIdentifier is null)
                return BadRequest();

            //SI ES EL PRIMER POST ELIMINAMOS LOS QUE HABIA PARA CARGAR TODOS DE VUELTA
            if (primerPost)
                await _svc.Articulos.EliminarArticulosSyncInicial((Guid)idSyncIdentifier); 

            await _svc.Articulos.AddCollectionSyncInicial(articulosSyncInicial);

            return Ok();
        }

        [HttpGet]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<Int32>> CantidadArticulosInicial(Guid idSyncIdentifier)
        {
            var cantidadArticulos = await _svc.Articulos.CountSyncInicial(idSyncIdentifier);
            return Ok(cantidadArticulos);
        }

        [HttpGet]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<IEnumerable<TipoUnidad>>> Unidades(Guid idSyncIdentifier)
        {
            var unidades = await _svc.Unidades.GetAll(idSyncIdentifier);

            await _svc.Unidades.RemoveAll(idSyncIdentifier);

            return Ok(unidades);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<TipoUnidad>> Unidades(IEnumerable<TipoUnidad> unidadesSyncInicial)
        {
            var idSyncIdentifier = unidadesSyncInicial.FirstOrDefault()?.IDSyncIdentifier;

            if (idSyncIdentifier is null)
                return BadRequest();

            await _svc.Unidades.RemoveAll((Guid)idSyncIdentifier);

            await _svc.Unidades.AddCollection(unidadesSyncInicial);

            return Ok();
        }

        [HttpGet]
        [Route("[action]/{idSyncIdentifier}")]
        public async Task<ActionResult<IEnumerable<Moneda>>> Monedas(Guid idSyncIdentifier)
        {
            var monedas = await _svc.Monedas.GetAll(idSyncIdentifier);

            await _svc.Monedas.RemoveAll(idSyncIdentifier);

            return Ok(monedas);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Moneda>> Monedas(IEnumerable<Moneda> monedasSyncInicial)
        {
            var idSyncIdentifier = monedasSyncInicial.FirstOrDefault()?.IDSyncIdentifier;

            if (idSyncIdentifier is null)
                return BadRequest();

            await _svc.Monedas.RemoveAll((Guid)idSyncIdentifier);

            await _svc.Monedas.AddCollection(monedasSyncInicial);

            return Ok();
        }
    }
}
