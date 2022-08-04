using Microsoft.EntityFrameworkCore;
using SyncAPI.Data;
using SyncAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncAPI.Services
{
    public class MonedasService
    {
        private readonly DBContext _context;

        public MonedasService(DBContext context)
        {
            _context = context; 
        }

        public async Task<List<Moneda>> GetAll(Guid idSyncIdentifier)
        {
            var monedas = await _context.Monedas.Where(x => (x.IDSyncIdentifier == idSyncIdentifier)).ToListAsync();
            return monedas;
        }

        public async Task AddCollection(IEnumerable<Moneda> monedas)
        {
            _context.Monedas.AddRange(monedas);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAll(Guid idSyncIdentifier)
        {
            _context.Database.ExecuteSqlRaw("DELETE TOP(100) PERCENT FROM [Monedas] WHERE IDSyncIdentifier = {0}", idSyncIdentifier);
            await _context.SaveChangesAsync();
        }
    }
}
