﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SyncAPI.Data;

namespace SyncAPI.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20210921205500_ArticuloSyncInicialTable")]
    partial class ArticuloSyncInicialTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SyncAPI.Models.Articulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<decimal>("CantidadPromocionFranquicia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CertificadoMunicipal")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Codigo01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo03")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo04")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo05")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo06")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo07")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo08")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo09")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoBarras")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoPereira")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESCRIPCIONMoneda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESCRIPCIONRubro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESCRIPCIONSeccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESCRIPCIONTipoUnidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionComponentes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionFranquicia")
                        .HasColumnType("varchar(300)");

                    b.Property<string>("DescripcionWeb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ExistenciaActual")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ExistenciaInicial")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ExistenciaMinima")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("FechaExistenciaInicial")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaUltimaCompra")
                        .HasColumnType("datetime2");

                    b.Property<string>("Grados")
                        .HasColumnType("varchar(100)");

                    b.Property<short?>("IDMoneda")
                        .HasColumnType("smallint");

                    b.Property<short?>("IDMonedaOriginal")
                        .HasColumnType("smallint");

                    b.Property<short?>("IDProveedorUltimaCompra")
                        .HasColumnType("smallint");

                    b.Property<int>("IDRubro")
                        .HasColumnType("int");

                    b.Property<int?>("IDRubroFranquicia")
                        .HasColumnType("int");

                    b.Property<Guid>("IDSyncIdentifier")
                        .HasColumnType("uniqueidentifier");

                    b.Property<short?>("IDVendedor")
                        .HasColumnType("smallint");

                    b.Property<int?>("IdArticuloTransformado")
                        .HasColumnType("int");

                    b.Property<int?>("IdArticuloTransformadoCC")
                        .HasColumnType("int");

                    b.Property<int?>("IdDeposito")
                        .HasColumnType("int");

                    b.Property<int?>("IdFamiliaItemsOrigen")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoTicket")
                        .HasColumnType("int");

                    b.Property<bool>("IsAVentaFinal")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsLista4")
                        .HasColumnType("bit");

                    b.Property<bool>("IsObligaVencimientoLote")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTrasable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVentaFranquicia")
                        .HasColumnType("bit");

                    b.Property<string>("NombreLegal")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObservacionesComponentes")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("PAMS")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Peso")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PesoEspecifico")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porcentaje10")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porcentaje4")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porcentaje5")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porcentaje6")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porcentaje7")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porcentaje8")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porcentaje9")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PorcentajeIVA")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<decimal>("PorcentajeMarcacion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PorcentajeMarcacionDos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PorcentajeMarcacionTres")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PreNombreLegal")
                        .HasColumnType("varchar(450)");

                    b.Property<decimal>("Precio01")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio02")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio03")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio04")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio05")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio06")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio07")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio08")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio09")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio10")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecioCosto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PrecioEnOtraMoneda")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("PrecioFranquicia")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("PrecioPromocionFranquicia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PrecioUltimaCompra")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ReporteDefault")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Ubicacion")
                        .HasColumnType("varchar(300)");

                    b.Property<decimal?>("UltimoPrecio")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("Volumen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("diasVencimiento")
                        .HasColumnType("int");

                    b.Property<int?>("fechaServicioDesde")
                        .HasColumnType("int");

                    b.Property<int?>("fechaServicioHasta")
                        .HasColumnType("int");

                    b.Property<int?>("idMedida")
                        .HasColumnType("int");

                    b.Property<int?>("idTipoUnidad")
                        .HasColumnType("int");

                    b.Property<bool>("isContenedor")
                        .HasColumnType("bit");

                    b.Property<bool>("isDestacado")
                        .HasColumnType("bit");

                    b.Property<bool>("isGenerico")
                        .HasColumnType("bit");

                    b.Property<bool>("isHayQueCorrerFormula")
                        .HasColumnType("bit");

                    b.Property<bool>("isIntermedio")
                        .HasColumnType("bit");

                    b.Property<bool>("isMateriaPrima")
                        .HasColumnType("bit");

                    b.Property<bool>("isProduccion")
                        .HasColumnType("bit");

                    b.Property<bool>("isRetornable")
                        .HasColumnType("bit");

                    b.Property<bool?>("isSeguirStock")
                        .HasColumnType("bit");

                    b.Property<bool?>("isServicio")
                        .HasColumnType("bit");

                    b.Property<bool>("isSubido")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IDSyncIdentifier");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("SyncAPI.Models.ArticuloSyncInicial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<decimal>("CantidadPromocionFranquicia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CertificadoMunicipal")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Codigo01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo03")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo04")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo05")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo06")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo07")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo08")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo09")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoBarras")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoPereira")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESCRIPCIONMoneda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESCRIPCIONRubro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESCRIPCIONSeccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESCRIPCIONTipoUnidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionComponentes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionFranquicia")
                        .HasColumnType("varchar(300)");

                    b.Property<string>("DescripcionWeb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ExistenciaActual")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ExistenciaInicial")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ExistenciaMinima")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("FechaExistenciaInicial")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaUltimaCompra")
                        .HasColumnType("datetime2");

                    b.Property<string>("Grados")
                        .HasColumnType("varchar(100)");

                    b.Property<short?>("IDMoneda")
                        .HasColumnType("smallint");

                    b.Property<short?>("IDMonedaOriginal")
                        .HasColumnType("smallint");

                    b.Property<short?>("IDProveedorUltimaCompra")
                        .HasColumnType("smallint");

                    b.Property<int>("IDRubro")
                        .HasColumnType("int");

                    b.Property<int?>("IDRubroFranquicia")
                        .HasColumnType("int");

                    b.Property<Guid>("IDSyncIdentifier")
                        .HasColumnType("uniqueidentifier");

                    b.Property<short?>("IDVendedor")
                        .HasColumnType("smallint");

                    b.Property<int?>("IdArticuloTransformado")
                        .HasColumnType("int");

                    b.Property<int?>("IdArticuloTransformadoCC")
                        .HasColumnType("int");

                    b.Property<int?>("IdDeposito")
                        .HasColumnType("int");

                    b.Property<int?>("IdFamiliaItemsOrigen")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoTicket")
                        .HasColumnType("int");

                    b.Property<bool>("IsAVentaFinal")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsLista4")
                        .HasColumnType("bit");

                    b.Property<bool>("IsObligaVencimientoLote")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTrasable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVentaFranquicia")
                        .HasColumnType("bit");

                    b.Property<string>("NombreLegal")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObservacionesComponentes")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("PAMS")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Peso")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PesoEspecifico")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porcentaje10")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porcentaje4")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porcentaje5")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porcentaje6")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porcentaje7")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porcentaje8")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porcentaje9")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PorcentajeIVA")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<decimal>("PorcentajeMarcacion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PorcentajeMarcacionDos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PorcentajeMarcacionTres")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PreNombreLegal")
                        .HasColumnType("varchar(450)");

                    b.Property<decimal>("Precio01")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio02")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio03")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio04")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio05")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio06")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio07")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio08")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio09")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Precio10")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecioCosto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PrecioEnOtraMoneda")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("PrecioFranquicia")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("PrecioPromocionFranquicia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PrecioUltimaCompra")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ReporteDefault")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Ubicacion")
                        .HasColumnType("varchar(300)");

                    b.Property<decimal?>("UltimoPrecio")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("Volumen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("diasVencimiento")
                        .HasColumnType("int");

                    b.Property<int?>("fechaServicioDesde")
                        .HasColumnType("int");

                    b.Property<int?>("fechaServicioHasta")
                        .HasColumnType("int");

                    b.Property<int?>("idMedida")
                        .HasColumnType("int");

                    b.Property<int?>("idTipoUnidad")
                        .HasColumnType("int");

                    b.Property<bool>("isContenedor")
                        .HasColumnType("bit");

                    b.Property<bool>("isDestacado")
                        .HasColumnType("bit");

                    b.Property<bool>("isGenerico")
                        .HasColumnType("bit");

                    b.Property<bool>("isHayQueCorrerFormula")
                        .HasColumnType("bit");

                    b.Property<bool>("isIntermedio")
                        .HasColumnType("bit");

                    b.Property<bool>("isMateriaPrima")
                        .HasColumnType("bit");

                    b.Property<bool>("isProduccion")
                        .HasColumnType("bit");

                    b.Property<bool>("isRetornable")
                        .HasColumnType("bit");

                    b.Property<bool?>("isSeguirStock")
                        .HasColumnType("bit");

                    b.Property<bool?>("isServicio")
                        .HasColumnType("bit");

                    b.Property<bool>("isSubido")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IDSyncIdentifier");

                    b.ToTable("ArticulosSyncInicial");
                });

            modelBuilder.Entity("SyncAPI.Models.Imagen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoPereira")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IDSyncIdentifier")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("IDSyncIdentifier");

                    b.ToTable("Imagenes");
                });

            modelBuilder.Entity("SyncAPI.Models.Precio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("CodigoPereira")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IDSyncIdentifier")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Porcentaje10")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<decimal>("Porcentaje4")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<decimal>("Porcentaje5")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<decimal>("Porcentaje6")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<decimal>("Porcentaje7")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<decimal>("Porcentaje8")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<decimal>("Porcentaje9")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<decimal>("PorcentajeMarcacion")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<decimal>("PorcentajeMarcacionDos")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<decimal>("PorcentajeMarcacionTres")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<decimal>("Precio01")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("Precio02")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("Precio03")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("Precio04")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("Precio05")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("Precio06")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("Precio07")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("Precio08")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("Precio09")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("Precio10")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("PrecioCosto")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("PrecioUltimaCompra")
                        .HasColumnType("decimal(18, 4)");

                    b.HasKey("Id");

                    b.HasIndex("IDSyncIdentifier");

                    b.ToTable("Precios");
                });

            modelBuilder.Entity("SyncAPI.Models.SyncIdentifier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UltimaFechaActualizacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SyncIdentifiers");
                });

            modelBuilder.Entity("SyncAPI.Models.Articulo", b =>
                {
                    b.HasOne("SyncAPI.Models.SyncIdentifier", "SyncIdentifier")
                        .WithMany("Articulos")
                        .HasForeignKey("IDSyncIdentifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SyncAPI.Models.ArticuloSyncInicial", b =>
                {
                    b.HasOne("SyncAPI.Models.SyncIdentifier", "SyncIdentifier")
                        .WithMany("ArticulosSyncInicial")
                        .HasForeignKey("IDSyncIdentifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SyncAPI.Models.Imagen", b =>
                {
                    b.HasOne("SyncAPI.Models.SyncIdentifier", "SyncIdentifier")
                        .WithMany("Imagenes")
                        .HasForeignKey("IDSyncIdentifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SyncAPI.Models.Precio", b =>
                {
                    b.HasOne("SyncAPI.Models.SyncIdentifier", "SyncIdentifier")
                        .WithMany("Precios")
                        .HasForeignKey("IDSyncIdentifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
