using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SyncAPI.Models
{
    public class Moneda
    {
        public Int32 Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public String Nombre { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal ValorActual { get; set; }
        [Column(TypeName = "varchar(5)")]
        public String Signo { get; set; }
        [Column(TypeName = "varchar(3)")]
        public String CodigoAfip { get; set; }

        [ForeignKey("SyncIdentifier")]
        public Guid IDSyncIdentifier { get; set; }
        public SyncIdentifier SyncIdentifier { get; set; }
    }
}
