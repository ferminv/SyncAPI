using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SyncAPI.Migrations
{
    public partial class ArticuloExistenciaPropertiesType19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "UltimoPrecio",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUltimaCompra",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioFranquicia",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioEnOtraMoneda",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioCosto",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio10",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio09",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio08",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio07",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio06",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio05",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio04",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio03",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio02",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio01",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaMinima",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaInicial",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaActual",
                table: "Articulos",
                type: "decimal(19,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "UltimoPrecio",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUltimaCompra",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioFranquicia",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioEnOtraMoneda",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioCosto",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio10",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio09",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio08",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio07",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio06",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio05",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio04",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio03",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio02",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio01",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaMinima",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaInicial",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExistenciaActual",
                table: "Articulos",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)",
                oldNullable: true);
        }
    }
}
