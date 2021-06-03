using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SyncAPI.Migrations
{
    public partial class ClaseImagen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imagenes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoPereira = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    IDSyncIdentifier = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imagenes_SyncIdentifiers_IDSyncIdentifier",
                        column: x => x.IDSyncIdentifier,
                        principalTable: "SyncIdentifiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Imagenes_IDSyncIdentifier",
                table: "Imagenes",
                column: "IDSyncIdentifier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imagenes");
        }
    }
}
