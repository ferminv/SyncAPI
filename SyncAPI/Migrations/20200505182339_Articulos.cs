using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SyncAPI.Migrations
{
    public partial class Articulos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Porcentaje10",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Porcentaje4",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Porcentaje5",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Porcentaje6",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Porcentaje7",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Porcentaje8",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Porcentaje9",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "PorcentajeMarcacion",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "PorcentajeMarcacionDos",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Precio01",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Precio02",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Precio03",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Precio04",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Precio05",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Precio06",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Precio07",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Precio08",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Precio09",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "PrecioUltimaCompra",
                table: "Articulos",
                newName: "UltimoPrecio");

            migrationBuilder.RenameColumn(
                name: "PrecioCosto",
                table: "Articulos",
                newName: "PrecioFranquicia");

            migrationBuilder.RenameColumn(
                name: "Precio10",
                table: "Articulos",
                newName: "PrecioEnOtraMoneda");

            migrationBuilder.RenameColumn(
                name: "PorcentajeMarcacionTres",
                table: "Articulos",
                newName: "PorcentajeIVA");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "CantidadPromocionFranquicia",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "CertificadoMunicipal",
                table: "Articulos",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo01",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo02",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo03",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo04",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo05",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo06",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo07",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo08",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo09",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo10",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoBarras",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescripcionComponentes",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescripcionFranquicia",
                table: "Articulos",
                type: "varchar(300)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescripcionWeb",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExistenciaActual",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ExistenciaInicial",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ExistenciaMinima",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaExistenciaInicial",
                table: "Articulos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaUltimaCompra",
                table: "Articulos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Grados",
                table: "Articulos",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "IDMoneda",
                table: "Articulos",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "IDMonedaOriginal",
                table: "Articulos",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "IDProveedorUltimaCompra",
                table: "Articulos",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<int>(
                name: "IDRubro",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDRubroFranquicia",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<short>(
                name: "IDVendedor",
                table: "Articulos",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<int>(
                name: "IdArticuloTransformado",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdArticuloTransformadoCC",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdDeposito",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdFamiliaItemsOrigen",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoTicket",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsAVentaFinal",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLista4",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsObligaVencimientoLote",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTrasable",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVentaFranquicia",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NombreLegal",
                table: "Articulos",
                type: "varchar(250)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observaciones",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ObservacionesComponentes",
                table: "Articulos",
                type: "varchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PAMS",
                table: "Articulos",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Peso",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PesoEspecifico",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PreNombreLegal",
                table: "Articulos",
                type: "varchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioPromocionFranquicia",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ReporteDefault",
                table: "Articulos",
                type: "varchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ubicacion",
                table: "Articulos",
                type: "varchar(300)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Volumen",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "diasVencimiento",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fechaServicioDesde",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fechaServicioHasta",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idMedida",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTipoUnidad",
                table: "Articulos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isContenedor",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDestacado",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isGenerico",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isHayQueCorrerFormula",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isIntermedio",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isMateriaPrima",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isProduccion",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isRetornable",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isSeguirStock",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isServicio",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isSubido",
                table: "Articulos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Precios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoPereira = table.Column<string>(nullable: true),
                    PrecioCosto = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    PrecioUltimaCompra = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    Precio01 = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    Precio02 = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    Precio03 = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    Precio04 = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    Precio05 = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    Precio06 = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    Precio07 = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    Precio08 = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    Precio09 = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    Precio10 = table.Column<decimal>(type: "decimal(18, 4)", nullable: false),
                    PorcentajeMarcacion = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    PorcentajeMarcacionDos = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    PorcentajeMarcacionTres = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    Porcentaje4 = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    Porcentaje5 = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    Porcentaje6 = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    Porcentaje7 = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    Porcentaje8 = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    Porcentaje9 = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    Porcentaje10 = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    IDSyncIdentifier = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Precios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Precios_SyncIdentifiers_IDSyncIdentifier",
                        column: x => x.IDSyncIdentifier,
                        principalTable: "SyncIdentifiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Precios_IDSyncIdentifier",
                table: "Precios",
                column: "IDSyncIdentifier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Precios");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "CantidadPromocionFranquicia",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "CertificadoMunicipal",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Codigo01",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Codigo02",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Codigo03",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Codigo04",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Codigo05",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Codigo06",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Codigo07",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Codigo08",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Codigo09",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Codigo10",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "CodigoBarras",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "DescripcionComponentes",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "DescripcionFranquicia",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "DescripcionWeb",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ExistenciaActual",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ExistenciaInicial",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ExistenciaMinima",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "FechaExistenciaInicial",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "FechaUltimaCompra",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Grados",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IDMoneda",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IDMonedaOriginal",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IDProveedorUltimaCompra",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IDRubro",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IDRubroFranquicia",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IDVendedor",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IdArticuloTransformado",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IdArticuloTransformadoCC",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IdDeposito",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IdFamiliaItemsOrigen",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IdTipoTicket",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IsAVentaFinal",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IsLista4",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IsObligaVencimientoLote",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IsTrasable",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "IsVentaFranquicia",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "NombreLegal",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Observaciones",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ObservacionesComponentes",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "PAMS",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "PesoEspecifico",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "PreNombreLegal",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "PrecioPromocionFranquicia",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ReporteDefault",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Volumen",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "diasVencimiento",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "fechaServicioDesde",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "fechaServicioHasta",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "idMedida",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "idTipoUnidad",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "isContenedor",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "isDestacado",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "isGenerico",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "isHayQueCorrerFormula",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "isIntermedio",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "isMateriaPrima",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "isProduccion",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "isRetornable",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "isSeguirStock",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "isServicio",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "isSubido",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "UltimoPrecio",
                table: "Articulos",
                newName: "PrecioUltimaCompra");

            migrationBuilder.RenameColumn(
                name: "PrecioFranquicia",
                table: "Articulos",
                newName: "PrecioCosto");

            migrationBuilder.RenameColumn(
                name: "PrecioEnOtraMoneda",
                table: "Articulos",
                newName: "Precio10");

            migrationBuilder.RenameColumn(
                name: "PorcentajeIVA",
                table: "Articulos",
                newName: "PorcentajeMarcacionTres");

            migrationBuilder.AddColumn<decimal>(
                name: "Porcentaje10",
                table: "Articulos",
                type: "decimal(6, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Porcentaje4",
                table: "Articulos",
                type: "decimal(6, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Porcentaje5",
                table: "Articulos",
                type: "decimal(6, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Porcentaje6",
                table: "Articulos",
                type: "decimal(6, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Porcentaje7",
                table: "Articulos",
                type: "decimal(6, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Porcentaje8",
                table: "Articulos",
                type: "decimal(6, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Porcentaje9",
                table: "Articulos",
                type: "decimal(6, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PorcentajeMarcacion",
                table: "Articulos",
                type: "decimal(6, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PorcentajeMarcacionDos",
                table: "Articulos",
                type: "decimal(6, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio01",
                table: "Articulos",
                type: "decimal(18, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio02",
                table: "Articulos",
                type: "decimal(18, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio03",
                table: "Articulos",
                type: "decimal(18, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio04",
                table: "Articulos",
                type: "decimal(18, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio05",
                table: "Articulos",
                type: "decimal(18, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio06",
                table: "Articulos",
                type: "decimal(18, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio07",
                table: "Articulos",
                type: "decimal(18, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio08",
                table: "Articulos",
                type: "decimal(18, 4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio09",
                table: "Articulos",
                type: "decimal(18, 4)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
