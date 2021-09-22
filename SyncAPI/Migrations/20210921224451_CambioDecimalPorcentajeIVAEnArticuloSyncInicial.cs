using Microsoft.EntityFrameworkCore.Migrations;

namespace SyncAPI.Migrations
{
    public partial class CambioDecimalPorcentajeIVAEnArticuloSyncInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeIVA",
                table: "ArticulosSyncInicial",
                type: "decimal(18, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6, 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeIVA",
                table: "ArticulosSyncInicial",
                type: "decimal(6, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)");
        }
    }
}
