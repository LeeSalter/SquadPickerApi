using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SquadPicker.Data.Migrations
{
    public partial class AddTeamTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "TeamId",
                table: "Players",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDateUTC = table.Column<DateTime>(nullable: false),
                    FormationId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Formations_FormationId",
                        column: x => x.FormationId,
                        principalTable: "Formations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("cd815d05-bd23-4659-895a-f8bea6340ec3"), 4, 2, 1, 4, "4-4-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("65907fdf-97d0-4fb1-9989-96db9ddbf8b4"), 5, 2, 1, 3, "5-3-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("9c00dde4-fa70-446d-9a98-d91751bf8ca8"), 4, 3, 1, 3, "4-3-3" });

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_FormationId",
                table: "Teams",
                column: "FormationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Players_TeamId",
                table: "Players");

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("65907fdf-97d0-4fb1-9989-96db9ddbf8b4"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("9c00dde4-fa70-446d-9a98-d91751bf8ca8"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("cd815d05-bd23-4659-895a-f8bea6340ec3"));

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Players");

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("165fb9f7-54b4-4afa-88da-a45817151781"), 4, 2, 1, 4, "4-4-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("4b744b4f-a647-497b-8ade-325864f40aee"), 5, 2, 1, 3, "5-3-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("c5f1cb9b-bea7-490f-ab2c-a13f4521aab3"), 4, 3, 1, 3, "4-3-3" });
        }
    }
}
