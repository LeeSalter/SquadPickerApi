using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SquadPicker.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Goalkeepers = table.Column<int>(nullable: false),
                    Defenders = table.Column<int>(nullable: false),
                    Midfielders = table.Column<int>(nullable: false),
                    Forwards = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Position = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    Availability = table.Column<string>(nullable: true),
                    Validity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(nullable: false),
                    FormationId = table.Column<Guid>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Teams_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamPlayers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TeamId = table.Column<Guid>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamPlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamPlayers_Players",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamPlayers_Teams",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[,]
                {
                    { new Guid("088957d7-24a0-4535-9d0c-07b3cbba8be8"), 4, 2, 1, 4, "4-4-2" },
                    { new Guid("29319481-0125-4cd8-b609-0e9b29d5a538"), 5, 2, 1, 3, "5-3-2" },
                    { new Guid("09a25e1c-945a-4450-b5df-e0184250050a"), 4, 3, 1, 3, "4-3-3" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Availability", "Name", "Position", "Selected", "Validity" },
                values: new object[,]
                {
                    { 23, null, "Bukayo Saka", 4, false, "player-valid" },
                    { 22, null, "Harry Kane", 4, false, "player-valid" },
                    { 21, null, "Jack Grealish", 4, false, "player-valid" },
                    { 20, null, "Phil Foden", 4, false, "player-valid" },
                    { 19, null, "Tammy Abraham", 4, false, "player-valid" },
                    { 18, null, "James Ward-Prowse", 3, false, "player-valid" },
                    { 17, null, "Declan Rice", 3, false, "player-valid" },
                    { 16, null, "Kalvin Phillips", 3, false, "player-valid" },
                    { 15, null, "Mason Mount", 3, false, "player-valid" },
                    { 14, null, "Jordan Henderson", 3, false, "player-valid" },
                    { 13, null, "Jude Bellingham", 3, false, "player-valid" },
                    { 11, null, "John Stones", 2, false, "player-valid" },
                    { 24, null, "Marcus Rashford", 4, false, "player-valid" },
                    { 10, null, "Luke Shaw", 2, false, "player-valid" },
                    { 9, null, "Tyrone Mings", 2, false, "player-valid" },
                    { 8, null, "Harry Maguire", 2, false, "player-valid" },
                    { 7, null, "Reece James", 2, false, "player-valid" },
                    { 6, null, "Conor Coady", 2, false, "player-valid" },
                    { 5, null, "Ben Chilwell", 2, false, "player-valid" },
                    { 4, null, "Trent Alexander-Arnold", 2, false, "player-valid" },
                    { 3, null, "Aaron Ramsdale", 1, false, "player-valid" },
                    { 2, null, "Sam Johnstone", 1, false, "player-valid" },
                    { 1, null, "Jordan Pickford", 1, false, "player-valid" },
                    { 12, null, "Kyle Walker", 2, false, "player-valid" },
                    { 25, null, "Raheem Sterling", 4, false, "player-valid" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamPlayers_PlayerId",
                table: "TeamPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamPlayers_TeamId",
                table: "TeamPlayers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_FormationId",
                table: "Teams",
                column: "FormationId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_UserId",
                table: "Teams",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamPlayers");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Formations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
