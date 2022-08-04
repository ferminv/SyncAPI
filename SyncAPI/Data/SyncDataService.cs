using Microsoft.EntityFrameworkCore;
using SyncAPI.Models;
using SyncAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncAPI.Data
{
    public class SyncDataService : ISyncDataService
    {
        private readonly DBContext _context;
        public ArticulosService Articulos { get; set; }
        public PreciosService Precios { get; set; }
        public ImagenesService Imagenes { get; set; }
        public MonedasService Monedas { get; set; }
        public UnidadesService Unidades { get; set; }

        public SyncDataService(DBContext context)
        {
            this._context = context;
            this.Articulos = new ArticulosService(context);
            this.Precios = new PreciosService(context);
            this.Imagenes = new ImagenesService(context);
            this.Monedas = new MonedasService(context);
            this.Unidades = new UnidadesService(context);
        }

        public async Task<SyncIdentifier> GetSyncIdentifier(Guid id)
        {
            return await _context.SyncIdentifiers.FindAsync(id);
        }

        public async Task<List<SyncIdentifier>> GetAllSyncIdentifier()
        {
            return await _context.SyncIdentifiers.ToListAsync();
        }

        public async Task AddSyncIdentifier(SyncIdentifier syncIdentifier)
        {
             _context.Add(syncIdentifier);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSyncIdentifier(SyncIdentifier syncIdentifier)
        {
            _context.Entry(syncIdentifier).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task RemoveSyncIdentifier(SyncIdentifier syncIdentifier)
        {
            _context.SyncIdentifiers.Remove(syncIdentifier);
            await _context.SaveChangesAsync();
        }

        public Boolean SyncIdentifierExists(Guid id)
        {
            return _context.SyncIdentifiers.Any(e => e.Id == id);
        }
    }
}
