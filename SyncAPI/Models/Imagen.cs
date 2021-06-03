using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SyncAPI.Models
{
    public class Imagen
    {
        public Int32 Id { get; set; }
        public String CodigoPereira { get; set; }
        public Byte[] Image { get; set; }

        [ForeignKey("SyncIdentifier")]
        public Guid IDSyncIdentifier { get; set; }
        public SyncIdentifier SyncIdentifier { get; set; }
    }
}
