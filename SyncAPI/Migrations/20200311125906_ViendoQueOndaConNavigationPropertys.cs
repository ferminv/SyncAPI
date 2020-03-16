using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SyncAPI.Migrations
{
    public partial class ViendoQueOndaConNavigationPropertys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_SyncIdentifiers_IDSyncIdentifier",
                table: "Articulos");

            migrationBuilder.AlterColumn<Guid>(
                name: "IDSyncIdentifier",
                table: "Articulos",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_SyncIdentifiers_IDSyncIdentifier",
                table: "Articulos",
                column: "IDSyncIdentifier",
                principalTable: "SyncIdentifiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_SyncIdentifiers_IDSyncIdentifier",
                table: "Articulos");

            migrationBuilder.AlterColumn<Guid>(
                name: "IDSyncIdentifier",
                table: "Articulos",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_SyncIdentifiers_IDSyncIdentifier",
                table: "Articulos",
                column: "IDSyncIdentifier",
                principalTable: "SyncIdentifiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
