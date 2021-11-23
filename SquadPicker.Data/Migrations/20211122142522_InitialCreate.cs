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
                    Selected = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[,]
                {
                    { new Guid("4fd98659-4a59-4104-b3bf-66c065c1e81f"), 4, 2, 1, 4, "4-4-2" },
                    { new Guid("89889a27-93f5-4de2-a3b3-fdf6a974ed61"), 5, 2, 1, 3, "5-3-2" },
                    { new Guid("5892ddf2-079d-4a6d-8f4b-e0a72039fb53"), 4, 3, 1, 3, "4-3-3" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "Position", "Selected" },
                values: new object[,]
                {
                    { 23, "Bukayo Saka", 4, false },
                    { 22, "Harry Kane", 4, false },
                    { 21, "Jack Grealish", 4, false },
                    { 20, "Phil Foden", 4, false },
                    { 19, "Tammy Abraham", 4, false },
                    { 18, "James Ward-Prowse", 3, false },
                    { 17, "Declan Rice", 3, false },
                    { 16, "Kalvin Phillips", 3, false },
                    { 15, "Mason Mount", 3, false },
                    { 14, "Jordan Henderson", 3, false },
                    { 13, "Jude Bellingham", 3, false },
                    { 11, "John Stones", 2, false },
                    { 24, "Marcus Rashford", 4, false },
                    { 10, "Luke Shaw", 2, false },
                    { 9, "Tyrone Mings", 2, false },
                    { 8, "Harry Maguire", 2, false },
                    { 7, "Reece James", 2, false },
                    { 6, "Conor Coady", 2, false },
                    { 5, "Ben Chilwell", 2, false },
                    { 4, "Trent Alexander-Arnold", 2, false },
                    { 3, "Aaron Ramsdale", 1, false },
                    { 2, "Sam Johnstone", 1, false },
                    { 1, "Jordan Pickford", 1, false },
                    { 12, "Kyle Walker", 2, false },
                    { 25, "Raheem Sterling", 4, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Formations");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
