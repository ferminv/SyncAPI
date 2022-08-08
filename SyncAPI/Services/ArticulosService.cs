using Microsoft.EntityFrameworkCore;
using SyncAPI.Data;
using SyncAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncAPI.Services
{

    public class ArticulosService
    {
        private readonly DBContext _context;

        public ArticulosService(DBContext context)
        {
            _context = context;
        }

        public async Task<Articulo> Get(Int32 id)
        {
            return await _context.Articulos.FindAsync(id);
        }

        public async Task Add(Articulo articulo)
        {
            _context.Articulos.Add(articulo);
            await _context.SaveChangesAsync();
        }

        public async Task AddCollection(IEnumerable<Articulo> articulos)
        {
            var subListasArticulos = HelpFuncs.DividirLista<Articulo>(articulos.ToList(), 1000);
            foreach (var lista in subListasArticulos)
            {
                _context.Articulos.AddRange(lista);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Update(Articulo articulo)
        {
            _context.Entry(articulo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Articulo articulo)
        {
            _context.Articulos.Remove(articulo);
            await _context.SaveChangesAsync();
        }

        public Boolean Exists(Int32 id)
        {
            return _context.Articulos.Any(e => e.Id == id);
        }

        public async Task<List<String>> GetCodigos(Guid idSyncIdentifier)
        {
            var codigos = await _context.Articulos.Where(x => x.IDSyncIdentifier == idSyncIdentifier).Select(x => x.CodigoPereira).ToListAsync();

            return codigos;
        }

        public async Task<List<Articulo>> GetByCodes(Guid idSyncIdentifier, IEnumerable<String> codigos)
        {
            var articulos = new List<Articulo>();
            var articuloSubList = new List<Articulo>();
            var subListasCodigos = HelpFuncs.DividirLista<string>(codigos.ToList(), 2000); //POR SI SON MAS DE 2K POR EL CONTAINS
            foreach (var subLista in subListasCodigos)
            {
                articuloSubList = await _context.Articulos.Where(x => (x.IDSyncIdentifier == idSyncIdentifier) && (subLista.Contains(x.CodigoPereira))).ToListAsync();

                articulos.AddRange(articuloSubList);
            }
            return articulos;
        }


        //--------->SYNC INICIAL<------------
        public async Task<List<ArticuloSyncInicial>> GetParcialSyncInicial(Guid idSyncIdentifier, Int32 iteracion, Int32 cantidad)
        {
            var articulos = await _context.ArticulosSyncInicial.Where(x => (x.IDSyncIdentifier == idSyncIdentifier))
                                    .Skip(iteracion * cantidad)
                                    .Take(cantidad).ToListAsync();
            return articulos;
        }

        public async Task AddCollectionSyncInicial(IEnumerable<ArticuloSyncInicial> articulosSyncInicial)
        {
            var subListasArticulos = HelpFuncs.DividirLista<ArticuloSyncInicial>(articulosSyncInicial.ToList(), 1000);
            foreach (var lista in subListasArticulos)
            {
                _context.ArticulosSyncInicial.AddRange(lista);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Int32> CountSyncInicial(Guid idSyncIdentifier)
        {
            var count = await _context.ArticulosSyncInicial.Where(x => x.IDSyncIdentifier == idSyncIdentifier).CountAsync();
            return count;
        }

        public async Task EliminarArticulosSyncInicial(Guid idSyncIdentifier)
        {
            _context.Database.ExecuteSqlRaw("DELETE TOP(100) PERCENT FROM [ArticulosSyncInicial] WHERE IDSyncIdentifier = {0}", idSyncIdentifier);
            await _context.SaveChangesAsync();
        }
    }
}
