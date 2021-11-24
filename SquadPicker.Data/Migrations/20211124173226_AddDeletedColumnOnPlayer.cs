using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SquadPicker.Data.Migrations
{
    public partial class AddDeletedColumnOnPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Players",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("66b6ce96-04f9-4465-9b8e-2240055246bd"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("9622462c-cd09-4d85-94ad-c9c0c9d64942"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("fc96424a-4569-4099-8efa-64b2d58fe019"));

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Players");

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("088957d7-24a0-4535-9d0c-07b3cbba8be8"), 4, 2, 1, 4, "4-4-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("29319481-0125-4cd8-b609-0e9b29d5a538"), 5, 2, 1, 3, "5-3-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("09a25e1c-945a-4450-b5df-e0184250050a"), 4, 3, 1, 3, "4-3-3" });
        }
    }
}
