using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SyncAPI.Migrations
{
    public partial class ArticuloSyncInicialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticulosSyncInicial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDRubro = table.Column<int>(nullable: false),
                    Activo = table.Column<bool>(nullable: false),
                    CodigoPereira = table.Column<string>(nullable: true),
                    CodigoBarras = table.Column<string>(nullable: true),
                    PrecioCosto = table.Column<decimal>(nullable: false),
                    PrecioUltimaCompra = table.Column<decimal>(nullable: true),
                    Precio01 = table.Column<decimal>(nullable: false),
                    Precio02 = table.Column<decimal>(nullable: false),
                    Precio03 = table.Column<decimal>(nullable: false),
                    Precio04 = table.Column<decimal>(nullable: false),
                    Precio05 = table.Column<decimal>(nullable: false),
                    Precio06 = table.Column<decimal>(nullable: false),
                    Precio07 = table.Column<decimal>(nullable: false),
                    Precio08 = table.Column<decimal>(nullable: false),
                    Precio09 = table.Column<decimal>(nullable: false),
                    Precio10 = table.Column<decimal>(nullable: false),
                    PorcentajeMarcacion = table.Column<decimal>(nullable: false),
                    PorcentajeMarcacionDos = table.Column<decimal>(nullable: true),
                    PorcentajeMarcacionTres = table.Column<decimal>(nullable: true),
                    Porcentaje4 = table.Column<decimal>(nullable: true),
                    Porcentaje5 = table.Column<decimal>(nullable: true),
                    Porcentaje6 = table.Column<decimal>(nullable: true),
                    Porcentaje7 = table.Column<decimal>(nullable: true),
                    Porcentaje8 = table.Column<decimal>(nullable: true),
                    Porcentaje9 = table.Column<decimal>(nullable: true),
                    Porcentaje10 = table.Column<decimal>(nullable: true),
                    Codigo01 = table.Column<string>(nullable: true),
                    Codigo02 = table.Column<string>(nullable: true),
                    Codigo03 = table.Column<string>(nullable: true),
                    Codigo04 = table.Column<string>(nullable: true),
                    Codigo05 = table.Column<string>(nullable: true),
                    Codigo06 = table.Column<string>(nullable: true),
                    Codigo07 = table.Column<string>(nullable: true),
                    Codigo08 = table.Column<string>(nullable: true),
                    Codigo09 = table.Column<string>(nullable: true),
                    Codigo10 = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    PorcentajeIVA = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    FechaUltimaCompra = table.Column<DateTime>(nullable: true),
                    FechaExistenciaInicial = table.Column<DateTime>(nullable: true),
                    IDProveedorUltimaCompra = table.Column<short>(nullable: true),
                    ExistenciaInicial = table.Column<decimal>(nullable: true),
                    ExistenciaMinima = table.Column<decimal>(nullable: true),
                    ExistenciaActual = table.Column<decimal>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true),
                    UltimoPrecio = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    IsLista4 = table.Column<bool>(nullable: true),
                    isSubido = table.Column<bool>(nullable: false),
                    isDestacado = table.Column<bool>(nullable: false),
                    IDMoneda = table.Column<short>(nullable: true),
                    PrecioEnOtraMoneda = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    isRetornable = table.Column<bool>(nullable: false),
                    isGenerico = table.Column<bool>(nullable: false),
                    IDVendedor = table.Column<short>(nullable: true),
                    DescripcionWeb = table.Column<string>(nullable: true),
                    idTipoUnidad = table.Column<int>(nullable: true),
                    isMateriaPrima = table.Column<bool>(nullable: false),
                    isContenedor = table.Column<bool>(nullable: false),
                    IDMonedaOriginal = table.Column<short>(nullable: true),
                    ObservacionesComponentes = table.Column<string>(type: "varchar(500)", nullable: true),
                    DescripcionComponentes = table.Column<string>(nullable: true),
                    IdTipoTicket = table.Column<int>(nullable: true),
                    fechaServicioDesde = table.Column<int>(nullable: true),
                    fechaServicioHasta = table.Column<int>(nullable: true),
                    IdArticuloTransformado = table.Column<int>(nullable: true),
                    DescripcionFranquicia = table.Column<string>(type: "varchar(300)", nullable: true),
                    IdArticuloTransformadoCC = table.Column<int>(nullable: true),
                    PrecioFranquicia = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    isIntermedio = table.Column<bool>(nullable: false),
                    IdDeposito = table.Column<int>(nullable: true),
                    IsAVentaFinal = table.Column<bool>(nullable: false),
                    IsVentaFranquicia = table.Column<bool>(nullable: false),
                    PesoEspecifico = table.Column<decimal>(nullable: false),
                    CantidadPromocionFranquicia = table.Column<decimal>(nullable: false),
                    PrecioPromocionFranquicia = table.Column<decimal>(nullable: false),
                    isHayQueCorrerFormula = table.Column<bool>(nullable: false),
                    isProduccion = table.Column<bool>(nullable: false),
                    IDRubroFranquicia = table.Column<int>(nullable: true),
                    IdFamiliaItemsOrigen = table.Column<int>(nullable: true),
                    idMedida = table.Column<int>(nullable: true),
                    ReporteDefault = table.Column<string>(type: "varchar(500)", nullable: true),
                    diasVencimiento = table.Column<int>(nullable: false),
                    isSeguirStock = table.Column<bool>(nullable: true),
                    Peso = table.Column<decimal>(nullable: false),
                    Volumen = table.Column<decimal>(nullable: false),
                    Ubicacion = table.Column<string>(type: "varchar(300)", nullable: true),
                    CertificadoMunicipal = table.Column<string>(type: "varchar(100)", nullable: true),
                    PAMS = table.Column<string>(type: "varchar(100)", nullable: true),
                    IsTrasable = table.Column<bool>(nullable: false),
                    Grados = table.Column<string>(type: "varchar(100)", nullable: true),
                    NombreLegal = table.Column<string>(type: "varchar(250)", nullable: true),
                    PreNombreLegal = table.Column<string>(type: "varchar(450)", nullable: true),
                    IsObligaVencimientoLote = table.Column<bool>(nullable: false),
                    isServicio = table.Column<bool>(nullable: true),
                    DESCRIPCIONRubro = table.Column<string>(nullable: true),
                    DESCRIPCIONSeccion = table.Column<string>(nullable: true),
                    DESCRIPCIONTipoUnidad = table.Column<string>(nullable: true),
                    DESCRIPCIONMoneda = table.Column<string>(nullable: true),
                    IDSyncIdentifier = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticulosSyncInicial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticulosSyncInicial_SyncIdentifiers_IDSyncIdentifier",
                        column: x => x.IDSyncIdentifier,
                        principalTable: "SyncIdentifiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticulosSyncInicial_IDSyncIdentifier",
                table: "ArticulosSyncInicial",
                column: "IDSyncIdentifier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticulosSyncInicial");
        }
    }
}
