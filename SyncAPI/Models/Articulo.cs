﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SyncAPI.Models
{
    public class Articulo
    {
        public Int32 Id { get; set; }
        public Int32 IDRubro { get; set; }
        public Boolean Activo { get; set; }
        [Column(TypeName = "varchar(20)")]
        public String CodigoPereira { get; set; }
        [Column(TypeName = "varchar(20)")]
        public String CodigoBarras { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal PrecioCosto { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal? PrecioUltimaCompra { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal Precio01 { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal Precio02 { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal Precio03 { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal Precio04 { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal Precio05 { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal Precio06 { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal Precio07 { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal Precio08 { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal Precio09 { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal Precio10 { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public Decimal PorcentajeMarcacion { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public Decimal? PorcentajeMarcacionDos { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public Decimal? PorcentajeMarcacionTres { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public Decimal? Porcentaje4 { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public Decimal? Porcentaje5 { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public Decimal? Porcentaje6 { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public Decimal? Porcentaje7 { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public Decimal? Porcentaje8 { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public Decimal? Porcentaje9 { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public Decimal? Porcentaje10 { get; set; }
        [Column(TypeName = "varchar(35)")]
        public String Codigo01 { get; set; }
        [Column(TypeName = "varchar(35)")]
        public String Codigo02 { get; set; }
        [Column(TypeName = "varchar(35)")]
        public String Codigo03 { get; set; }
        [Column(TypeName = "varchar(35)")]
        public String Codigo04 { get; set; }
        [Column(TypeName = "varchar(35)")]
        public String Codigo05 { get; set; }
        [Column(TypeName = "varchar(35)")]
        public String Codigo06 { get; set; }
        [Column(TypeName = "varchar(35)")]
        public String Codigo07 { get; set; }
        [Column(TypeName = "varchar(35)")]
        public String Codigo08 { get; set; }
        [Column(TypeName = "varchar(35)")]
        public String Codigo09 { get; set; }
        [Column(TypeName = "varchar(35)")]
        public String Codigo10 { get; set; }
        [Column(TypeName = "varchar(300)")]
        public String Descripcion { get; set; }
        [Column(TypeName = "decimal(10, 4)")]

        public Decimal PorcentajeIVA { get; set; }
        public DateTime? FechaUltimaCompra { get; set; }
        public DateTime? FechaExistenciaInicial { get; set; }
        public Int16? IDProveedorUltimaCompra { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal? ExistenciaInicial { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal? ExistenciaMinima { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal? ExistenciaActual { get; set; }
        public String Observaciones { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal? UltimoPrecio { get; set; }
        public Boolean? IsLista4 { get; set; }
        public Boolean isSubido { get; set; }
        public Boolean isDestacado { get; set; }
        public Int16? IDMoneda { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal? PrecioEnOtraMoneda { get; set; }
        public Boolean isRetornable { get; set; }
        public Boolean isGenerico { get; set; }
        public Int16? IDVendedor { get; set; }
        public String DescripcionWeb { get; set; }
        public Int32? idTipoUnidad { get; set; }
        public Boolean isMateriaPrima { get; set; }
        public Boolean isContenedor { get; set; }
        public Int16? IDMonedaOriginal { get; set; }
        [Column(TypeName = "varchar(500)")]
        public String ObservacionesComponentes { get; set; }
        public String DescripcionComponentes { get; set; }
        public Int32? IdTipoTicket { get; set; }
        public Int32? fechaServicioDesde { get; set; }
        public Int32? fechaServicioHasta { get; set; }
        public Int32? IdArticuloTransformado { get; set; }
        [Column(TypeName = "varchar(300)")]
        public String DescripcionFranquicia { get; set; }
        public Int32? IdArticuloTransformadoCC { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public Decimal PrecioFranquicia { get; set; }
        public Boolean isIntermedio { get; set; }
        public Int32? IdDeposito { get; set; }
        public Boolean IsAVentaFinal { get; set; }
        public Boolean IsVentaFranquicia { get; set; }
        public Decimal PesoEspecifico { get; set; }
        public Decimal CantidadPromocionFranquicia { get; set; }
        public Decimal PrecioPromocionFranquicia { get; set; }
        public Boolean isHayQueCorrerFormula { get; set; }
        public Boolean isProduccion { get; set; }
        public Int32? IDRubroFranquicia { get; set; }
        public Int32? IdFamiliaItemsOrigen { get; set; }
        public Int32? idMedida { get; set; }
        [Column(TypeName = "varchar(500)")]
        public String ReporteDefault { get; set; }
        public Int32 diasVencimiento { get; set; }
        public Boolean? isSeguirStock { get; set; }
        public Decimal Peso { get; set; }
        public Decimal Volumen { get; set; }
        [Column(TypeName = "varchar(300)")]
        public String Ubicacion { get; set; }
        [Column(TypeName = "varchar(100)")]
        public String CertificadoMunicipal { get; set; }
        [Column(TypeName = "varchar(100)")]
        public String PAMS { get; set; }
        public Boolean IsTrasable { get; set; }
        [Column(TypeName = "varchar(100)")]
        public String Grados { get; set; }
        [Column(TypeName = "varchar(250)")]
        public String NombreLegal { get; set; }
        [Column(TypeName = "varchar(450)")]
        public String PreNombreLegal { get; set; }
        public Boolean IsObligaVencimientoLote { get; set; }
        public Boolean? isServicio { get; set; }
        public String DESCRIPCIONRubro { get; set; }
        public String DESCRIPCIONSeccion { get; set; }
        public String DESCRIPCIONTipoUnidad { get; set; }
        public String DESCRIPCIONMoneda { get; set; }

        [ForeignKey("SyncIdentifier")]
        public Guid IDSyncIdentifier { get; set; }
        public SyncIdentifier SyncIdentifier { get; set; }
    }
}
