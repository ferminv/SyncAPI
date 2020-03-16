using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SyncAPI.Models
{
    public class Articulo
    {
        public Int32 Id { get; set; } 
        public String CodigoPereira { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public Decimal PrecioCosto { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public Decimal PrecioUltimaCompra { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public Decimal Precio01 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public Decimal Precio02 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public Decimal Precio03 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public Decimal Precio04 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public Decimal Precio05 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public Decimal Precio06 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public Decimal Precio07 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public Decimal Precio08 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public Decimal Precio09 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public Decimal Precio10 { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public Decimal PorcentajeMarcacion { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public Decimal PorcentajeMarcacionDos { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public Decimal PorcentajeMarcacionTres { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public Decimal Porcentaje4 { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public Decimal Porcentaje5 { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public Decimal Porcentaje6 { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public Decimal Porcentaje7 { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public Decimal Porcentaje8 { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public Decimal Porcentaje9 { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public Decimal Porcentaje10 { get; set; }

        [ForeignKey("SyncIdentifier")]
        public Guid IDSyncIdentifier { get; set; }
        public SyncIdentifier SyncIdentifier { get; set; }
    }
}
