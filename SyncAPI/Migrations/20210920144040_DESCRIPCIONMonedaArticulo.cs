using Microsoft.EntityFrameworkCore.Migrations;

namespace SyncAPI.Migrations
{
    public partial class DESCRIPCIONMonedaArticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "DESCRIPCIONMoneda",
                table: "Articulos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "DESCRIPCIONMoneda",
                table: "Articulos");
        }
    }
}
