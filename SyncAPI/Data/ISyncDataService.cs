using SyncAPI.Models;
using SyncAPI.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SyncAPI.Data
{
    public interface ISyncDataService
    {
        public ArticulosService Articulos { get; set; }

        public PreciosService Precios { get; set; }

        public ImagenesService Imagenes { get; set; }

        public MonedasService Monedas { get; set; }

        public UnidadesService Unidades { get; set; }

        public Task<SyncIdentifier> GetSyncIdentifier(Guid id);
        public Task<List<SyncIdentifier>> GetAllSyncIdentifier();
        public Task AddSyncIdentifier(SyncIdentifier syncIdentifier);
        public Task UpdateSyncIdentifier(SyncIdentifier syncIdentifier);
        public Task RemoveSyncIdentifier(SyncIdentifier syncIdentifier);
        public Boolean SyncIdentifierExists(Guid id);
    }
}
