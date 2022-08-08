using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SyncAPI.Migrations
{
    public partial class ArticuloPropertiesType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUltimaCompra",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioCosto",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio10",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio09",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio08",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio07",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio06",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio05",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio04",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio03",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio02",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio01",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeMarcacionTres",
                table: "Articulos",
                type: "decimal(10,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeMarcacionDos",
                table: "Articulos",
                type: "decimal(10,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeMarcacion",
                table: "Articulos",
                type: "decimal(10,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeIVA",
                table: "Articulos",
                type: "decimal(10,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje9",
                table: "Articulos",
                type: "decimal(10,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje8",
                table: "Articulos",
                type: "decimal(10,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje7",
                table: "Articulos",
                type: "decimal(10,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje6",
                table: "Articulos",
                type: "decimal(10,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje5",
                table: "Articulos",
                type: "decimal(10,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje4",
                table: "Articulos",
                type: "decimal(10,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje10",
                table: "Articulos",
                type: "decimal(10,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUltimaCompra",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioCosto",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio10",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio09",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio08",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio07",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio06",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio05",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio04",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio03",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio02",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio01",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeMarcacionTres",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeMarcacionDos",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeMarcacion",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeIVA",
                table: "Articulos",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje9",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje8",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje7",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje6",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje5",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje4",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentaje10",
                table: "Articulos",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)",
                oldNullable: true);
        }
    }
}
