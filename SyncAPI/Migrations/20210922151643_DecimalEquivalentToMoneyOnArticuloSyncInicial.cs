using Microsoft.EntityFrameworkCore.Migrations;

namespace SyncAPI.Migrations
{
    public partial class DecimalEquivalentToMoneyOnArticuloSyncInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Volumen",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UltimoPrecio",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUltimaCompra",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioPromocionFranquicia",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioFranquicia",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioEnOtraMoneda",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioCosto",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio10",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio09",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio08",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio07",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio06",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio05",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio04",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio03",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio02",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio01",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeMarcacionTres",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeMarcacionDos",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeMarcacion",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeIVA",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje9",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje8",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje7",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje6",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje5",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje4",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje10",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PesoEspecifico",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaMinima",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaInicial",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaActual",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CantidadPromocionFranquicia",
                table: "ArticulosSyncInicial",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Volumen",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UltimoPrecio",
                table: "ArticulosSyncInicial",
                type: "decimal(18, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUltimaCompra",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioPromocionFranquicia",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioFranquicia",
                table: "ArticulosSyncInicial",
                type: "decimal(18, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioEnOtraMoneda",
                table: "ArticulosSyncInicial",
                type: "decimal(18, 4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioCosto",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio10",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio09",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio08",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio07",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio06",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio05",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio04",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio03",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio02",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio01",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeMarcacionTres",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeMarcacionDos",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeMarcacion",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeIVA",
                table: "ArticulosSyncInicial",
                type: "decimal(18, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje9",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje8",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje7",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje6",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje5",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje4",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje10",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PesoEspecifico",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaMinima",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaInicial",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaActual",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CantidadPromocionFranquicia",
                table: "ArticulosSyncInicial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");
        }
    }
}
