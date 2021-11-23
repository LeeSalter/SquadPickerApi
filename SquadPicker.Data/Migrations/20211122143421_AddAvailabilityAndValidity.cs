using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SquadPicker.Data.Migrations
{
    public partial class AddAvailabilityAndValidity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("4fd98659-4a59-4104-b3bf-66c065c1e81f"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("5892ddf2-079d-4a6d-8f4b-e0a72039fb53"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("89889a27-93f5-4de2-a3b3-fdf6a974ed61"));

            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Validity",
                table: "Players",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("88c9ffd3-fb7d-41db-896c-b47a70653d22"), 4, 2, 1, 4, "4-4-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("1e8023c8-40f2-4503-b610-9ecfc71caeda"), 5, 2, 1, 3, "5-3-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("2fe43d34-67e4-475e-b5be-c9346ff43399"), 4, 3, 1, 3, "4-3-3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("1e8023c8-40f2-4503-b610-9ecfc71caeda"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("2fe43d34-67e4-475e-b5be-c9346ff43399"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("88c9ffd3-fb7d-41db-896c-b47a70653d22"));

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Validity",
                table: "Players");

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("4fd98659-4a59-4104-b3bf-66c065c1e81f"), 4, 2, 1, 4, "4-4-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("89889a27-93f5-4de2-a3b3-fdf6a974ed61"), 5, 2, 1, 3, "5-3-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("5892ddf2-079d-4a6d-8f4b-e0a72039fb53"), 4, 3, 1, 3, "4-3-3" });
        }
    }
}
