using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SquadPicker.Data.Migrations
{
    public partial class AddForeignKeyFromPlayerToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Players",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[,]
                {
                    { new Guid("c104e680-fcc6-471e-9409-591f8c5c9f38"), 4, 2, 1, 4, "4-4-2" },
                    { new Guid("5f8770e5-4394-452e-9ced-8536bc947b36"), 5, 2, 1, 3, "5-3-2" },
                    { new Guid("77eb4f29-7019-42c7-8dce-d760b686c0fa"), 4, 3, 1, 3, "4-3-3" }
                });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                column: "UserId",
                value: new Guid("4be180ee-1af1-4a19-a5f4-8105ad3ef124"));

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserId",
                table: "Players",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Users_UserId",
                table: "Players",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Users_UserId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_UserId",
                table: "Players");

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("5f8770e5-4394-452e-9ced-8536bc947b36"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("77eb4f29-7019-42c7-8dce-d760b686c0fa"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("c104e680-fcc6-471e-9409-591f8c5c9f38"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Players");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("fc96424a-4569-4099-8efa-64b2d58fe019"), 4, 2, 1, 4, "4-4-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("9622462c-cd09-4d85-94ad-c9c0c9d64942"), 5, 2, 1, 3, "5-3-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("66b6ce96-04f9-4465-9b8e-2240055246bd"), 4, 3, 1, 3, "4-3-3" });
        }
    }
}
