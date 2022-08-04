using Microsoft.EntityFrameworkCore;
using SyncAPI.Data;
using SyncAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncAPI.Services
{
    public class PreciosService
    {
        private readonly DBContext _context;

        public PreciosService(DBContext context)
        {
            _context = context; 
        }

        public async Task<List<Precio>> GetByLastSyncDate(Guid idSyncIdentifier, DateTime lastSyncDate)
        {
            var precios = await _context.Precios.Where(x => x.IDSyncIdentifier == idSyncIdentifier && x.FechaActualizacion >= lastSyncDate).ToListAsync();
            return precios; 
        }

        public async Task<List<Precio>> GetByLastSyncDateParcial(Guid idSyncIdentifier, DateTime lastSyncDate, Int32 iteracion, Int32 cantidad)
        {
            var precios = await _context.Precios.Where(x => x.IDSyncIdentifier == idSyncIdentifier && x.FechaActualizacion >= lastSyncDate)
                                    .Skip(iteracion * cantidad)
                                    .Take(cantidad).ToListAsync();

            return precios;
        }

        public async Task<List<String>> GetCodigos(Guid idSyncIdentifier)
        {
            var codigos = await _context.Precios.Where(x => x.IDSyncIdentifier == idSyncIdentifier).Select(x => x.CodigoPereira).ToListAsync();
            return codigos;
        }

        public async Task AddCollection(IEnumerable<Precio> precios)
        {
            var subListasPrecios = HelpFuncs.DividirLista<Precio>(precios.ToList(), 1000);
            foreach (var lista in subListasPrecios)
                _context.Precios.AddRange(lista);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveCollection(Guid idSyncIdentifier, IEnumerable<Precio> precios)
        {
            //_context.Database.ExecuteSqlRaw("DELETE TOP(100) PERCENT FROM dbo.Precios WHERE IDSyncIdentifier = {0} and CodigoPereira in {1}", idSyncIdentifier, codigos);
            var codigos = precios.Select(x => x.CodigoPereira).ToList();
            var subListasCodigos = HelpFuncs.DividirLista<string>(codigos, 2000);
            foreach (var listaCodigos in subListasCodigos)
            {
                var preciosABorrar = _context.Precios.Where(x => listaCodigos.Contains(x.CodigoPereira) && x.IDSyncIdentifier == idSyncIdentifier);
                _context.Precios.RemoveRange(preciosABorrar);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Int32> GetUpdatedCount(Guid idSyncIdentifier, DateTime lastSyncDate)
        {
            var cantidadPrecios = await _context.Precios.Where(x => x.IDSyncIdentifier == idSyncIdentifier && x.FechaActualizacion >= lastSyncDate).CountAsync();

            return cantidadPrecios;
        }
    }
}
