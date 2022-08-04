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
    public class ImagenesService
    {
        private readonly DBContext _context;

        public ImagenesService(DBContext context)
        {
            _context = context;
        }

        public async Task<List<Imagen>> GetAll(Guid idSyncIdentifier)
        {
            var imagenes = await _context.Imagenes.Where(x => x.IDSyncIdentifier == idSyncIdentifier).ToListAsync();
            return imagenes;
        }

        public async Task AddCollection(IEnumerable<Imagen> imagenes)
        {
            var subListasImagenes = HelpFuncs.DividirLista<Imagen>(imagenes.ToList(), 1000);
            foreach (var lista in subListasImagenes)
            {
                _context.Imagenes.AddRange(lista);
                await _context.SaveChangesAsync();
            }
        }

        public async Task RemoveAll(Guid idSyncIdentifier)
        {
            _context.Database.ExecuteSqlRaw("DELETE TOP(100) PERCENT FROM dbo.Imagenes WHERE IDSyncIdentifier = {0}", idSyncIdentifier);
            await _context.SaveChangesAsync();
        }
    }
}
