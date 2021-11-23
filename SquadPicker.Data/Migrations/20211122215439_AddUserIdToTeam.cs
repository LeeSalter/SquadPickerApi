using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SquadPicker.Data.Migrations
{
    public partial class AddUserIdToTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("66cc9d61-ca89-490e-93ef-d5f00fc65f29"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("d8d878f0-d36c-487c-beef-90324a365dd6"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("f50f4aab-2a09-49a9-a897-eab9ae96eafc"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Teams",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("5eb1b188-e7fc-461b-b52b-85eba8f3896b"), 4, 2, 1, 4, "4-4-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("90fcf596-1885-457e-a414-9ecbef4ed6af"), 5, 2, 1, 3, "5-3-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("b909326a-fe7b-450a-afaa-5e64af2ffbe3"), 4, 3, 1, 3, "4-3-3" });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_UserId",
                table: "Teams",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Users_UserId",
                table: "Teams",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Users_UserId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_UserId",
                table: "Teams");

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("5eb1b188-e7fc-461b-b52b-85eba8f3896b"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("90fcf596-1885-457e-a414-9ecbef4ed6af"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("b909326a-fe7b-450a-afaa-5e64af2ffbe3"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Teams");

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("d8d878f0-d36c-487c-beef-90324a365dd6"), 4, 2, 1, 4, "4-4-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("f50f4aab-2a09-49a9-a897-eab9ae96eafc"), 5, 2, 1, 3, "5-3-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("66cc9d61-ca89-490e-93ef-d5f00fc65f29"), 4, 3, 1, 3, "4-3-3" });
        }
    }
}
