using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SquadPicker.Data.Migrations
{
    public partial class AddDefaultValidity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[,]
                {
                    { new Guid("165fb9f7-54b4-4afa-88da-a45817151781"), 4, 2, 1, 4, "4-4-2" },
                    { new Guid("4b744b4f-a647-497b-8ade-325864f40aee"), 5, 2, 1, 3, "5-3-2" },
                    { new Guid("c5f1cb9b-bea7-490f-ab2c-a13f4521aab3"), 4, 3, 1, 3, "4-3-3" }
                });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                column: "Validity",
                value: "player-valid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                column: "Validity",
                value: "player-valid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("165fb9f7-54b4-4afa-88da-a45817151781"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("4b744b4f-a647-497b-8ade-325864f40aee"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("c5f1cb9b-bea7-490f-ab2c-a13f4521aab3"));

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[,]
                {
                    { new Guid("88c9ffd3-fb7d-41db-896c-b47a70653d22"), 4, 2, 1, 4, "4-4-2" },
                    { new Guid("1e8023c8-40f2-4503-b610-9ecfc71caeda"), 5, 2, 1, 3, "5-3-2" },
                    { new Guid("2fe43d34-67e4-475e-b5be-c9346ff43399"), 4, 3, 1, 3, "4-3-3" }
                });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                column: "Validity",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                column: "Validity",
                value: null);
        }
    }
}
