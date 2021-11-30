using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncAPI.Models
{
    public class SyncIdentifier
    {
        public Guid Id { get; set; }
        public String Nombre { get; set; }
        public DateTime UltimaFechaActualizacion { get; set; }

        public ICollection<Precio> Precios { get; set; }
        public ICollection<Articulo> Articulos { get; set; }
        public ICollection<Imagen> Imagenes { get; set; }
        public ICollection<ArticuloSyncInicial> ArticulosSyncInicial { get; set; }
        public ICollection<TipoUnidad> TiposUnidad { get; set; }
        public ICollection<Moneda> Monedas { get; set; }


    }
}
