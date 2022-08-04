using Microsoft.EntityFrameworkCore;
using SyncAPI.Data;
using SyncAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncAPI.Services
{
    public class UnidadesService
    {
        private readonly DBContext _context;

        public UnidadesService(DBContext context)
        {
            _context = context; 
        }

        public async Task<List<TipoUnidad>> GetAll(Guid idSyncIdentifier)
        {
            var unidades = await _context.TiposUnidad.Where(x => (x.IDSyncIdentifier == idSyncIdentifier)).ToListAsync();

            return unidades;
        }

        public async Task AddCollection(IEnumerable<TipoUnidad> unidades)
        {
            _context.TiposUnidad.AddRange(unidades);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAll(Guid idSyncIdentifier)
        {
            _context.Database.ExecuteSqlRaw("DELETE TOP(100) PERCENT FROM [TiposUnidad] WHERE IDSyncIdentifier = {0}", idSyncIdentifier);
            await _context.SaveChangesAsync();
        }

    }
}
