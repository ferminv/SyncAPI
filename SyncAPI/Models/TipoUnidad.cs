using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SyncAPI.Models
{
    public class TipoUnidad
    {
        public Int32 Id { get; set; }
        [Column(TypeName = "varchar(100)")]
        public String Nombre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal? Unidades { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal EquivalenteKG { get; set; }


        [ForeignKey("SyncIdentifier")]
        public Guid IDSyncIdentifier { get; set; }
        public SyncIdentifier SyncIdentifier { get; set; }
    }
}
