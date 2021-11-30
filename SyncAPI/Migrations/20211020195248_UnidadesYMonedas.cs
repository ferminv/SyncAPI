using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SyncAPI.Migrations
{
    public partial class UnidadesYMonedas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monedas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    ValorActual = table.Column<decimal>(type: "decimal(19, 4)", nullable: false),
                    Signo = table.Column<string>(type: "varchar(5)", nullable: true),
                    CodigoAfip = table.Column<string>(type: "varchar(3)", nullable: true),
                    IDSyncIdentifier = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monedas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monedas_SyncIdentifiers_IDSyncIdentifier",
                        column: x => x.IDSyncIdentifier,
                        principalTable: "SyncIdentifiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TiposUnidad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: true),
                    Unidades = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EquivalenteKG = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IDSyncIdentifier = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposUnidad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TiposUnidad_SyncIdentifiers_IDSyncIdentifier",
                        column: x => x.IDSyncIdentifier,
                        principalTable: "SyncIdentifiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Monedas_IDSyncIdentifier",
                table: "Monedas",
                column: "IDSyncIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_TiposUnidad_IDSyncIdentifier",
                table: "TiposUnidad",
                column: "IDSyncIdentifier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monedas");

            migrationBuilder.DropTable(
                name: "TiposUnidad");
        }
    }
}
