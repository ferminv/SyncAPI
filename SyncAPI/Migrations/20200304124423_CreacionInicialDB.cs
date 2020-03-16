using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SyncAPI.Migrations
{
    public partial class CreacionInicialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SyncIdentifiers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    UltimaFechaActualizacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SyncIdentifiers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoPereira = table.Column<string>(nullable: true),
                    PrecioCosto = table.Column<decimal>(nullable: false),
                    PrecioUltimaCompra = table.Column<decimal>(nullable: false),
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
                    PorcentajeMarcacionDos = table.Column<decimal>(nullable: false),
                    PorcentajeMarcacionTres = table.Column<decimal>(nullable: false),
                    Porcentaje4 = table.Column<decimal>(nullable: false),
                    Porcentaje5 = table.Column<decimal>(nullable: false),
                    Porcentaje6 = table.Column<decimal>(nullable: false),
                    Porcentaje7 = table.Column<decimal>(nullable: false),
                    Porcentaje8 = table.Column<decimal>(nullable: false),
                    Porcentaje9 = table.Column<decimal>(nullable: false),
                    Porcentaje10 = table.Column<decimal>(nullable: false),
                    IDSyncIdentifier = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articulos_SyncIdentifiers_IDSyncIdentifier",
                        column: x => x.IDSyncIdentifier,
                        principalTable: "SyncIdentifiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_IDSyncIdentifier",
                table: "Articulos",
                column: "IDSyncIdentifier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulos");

            migrationBuilder.DropTable(
                name: "SyncIdentifiers");
        }
    }
}
