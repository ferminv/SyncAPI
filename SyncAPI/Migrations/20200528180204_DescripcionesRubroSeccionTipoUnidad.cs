using Microsoft.EntityFrameworkCore.Migrations;

namespace SyncAPI.Migrations
{
    public partial class DescripcionesRubroSeccionTipoUnidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DESCRIPCIONRubro",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DESCRIPCIONSeccion",
                table: "Articulos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DESCRIPCIONTipoUnidad",
                table: "Articulos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DESCRIPCIONRubro",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "DESCRIPCIONSeccion",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "DESCRIPCIONTipoUnidad",
                table: "Articulos");
        }
    }
}
