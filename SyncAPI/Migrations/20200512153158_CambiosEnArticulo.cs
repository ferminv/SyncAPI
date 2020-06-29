using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SyncAPI.Migrations
{
    public partial class CambiosEnArticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isServicio",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "isSeguirStock",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "idTipoUnidad",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "idMedida",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "fechaServicioHasta",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "fechaServicioDesde",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "UltimoPrecio",
                table: "Articulos",
                type: "decimal(18, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioEnOtraMoneda",
                table: "Articulos",
                type: "decimal(18, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsLista4",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "IdTipoTicket",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdFamiliaItemsOrigen",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdDeposito",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdArticuloTransformadoCC",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdArticuloTransformado",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<short>(
                name: "IDVendedor",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "IDRubroFranquicia",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<short>(
                name: "IDProveedorUltimaCompra",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<short>(
                name: "IDMonedaOriginal",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<short>(
                name: "IDMoneda",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaUltimaCompra",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaExistenciaInicial",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaMinima",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaInicial",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaActual",
                table: "Articulos",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<decimal>(
                name: "Porcentaje10",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Porcentaje4",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Porcentaje5",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Porcentaje6",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Porcentaje7",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Porcentaje8",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Porcentaje9",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PorcentajeMarcacion",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PorcentajeMarcacionDos",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PorcentajeMarcacionTres",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio01",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio02",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio03",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio04",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio05",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio06",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio07",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio08",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio09",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio10",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioCosto",
                table: "Articulos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioUltimaCompra",
                table: "Articulos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "PorcentajeMarcacionTres",
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

            migrationBuilder.DropColumn(
                name: "Precio10",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "PrecioCosto",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "PrecioUltimaCompra",
                table: "Articulos");

            migrationBuilder.AlterColumn<bool>(
                name: "isServicio",
                table: "Articulos",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isSeguirStock",
                table: "Articulos",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "idTipoUnidad",
                table: "Articulos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "idMedida",
                table: "Articulos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "fechaServicioHasta",
                table: "Articulos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "fechaServicioDesde",
                table: "Articulos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "UltimoPrecio",
                table: "Articulos",
                type: "decimal(18, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioEnOtraMoneda",
                table: "Articulos",
                type: "decimal(18, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsLista4",
                table: "Articulos",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdTipoTicket",
                table: "Articulos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdFamiliaItemsOrigen",
                table: "Articulos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdDeposito",
                table: "Articulos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdArticuloTransformadoCC",
                table: "Articulos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdArticuloTransformado",
                table: "Articulos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "IDVendedor",
                table: "Articulos",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IDRubroFranquicia",
                table: "Articulos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "IDProveedorUltimaCompra",
                table: "Articulos",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "IDMonedaOriginal",
                table: "Articulos",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "IDMoneda",
                table: "Articulos",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaUltimaCompra",
                table: "Articulos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaExistenciaInicial",
                table: "Articulos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaMinima",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaInicial",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaActual",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);
        }
    }
}
