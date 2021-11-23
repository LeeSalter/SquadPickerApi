using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SquadPicker.Data.Migrations
{
    public partial class ChangeTeamPlayers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_Player10Id",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_Player11Id",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_Player1Id",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_Player2Id",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_Player3Id",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_Player4Id",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_Player5Id",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_Player6Id",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_Player7Id",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_Player8Id",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_Player9Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Player10Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Player11Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Player1Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Player2Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Player3Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Player4Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Player5Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Player6Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Player7Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Player8Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Player9Id",
                table: "Teams");

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("55e410f7-8a3c-40f9-ac5f-4cf5cfa6ec80"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("5bd3b67f-d785-4cee-9711-61ffd7fbb8ad"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("adf5739e-a22f-4d49-bd49-8ac77784e8c2"));

            migrationBuilder.DropColumn(
                name: "Player10Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Player11Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Player1Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Player2Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Player3Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Player4Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Player5Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Player6Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Player7Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Player8Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Player9Id",
                table: "Teams");

            migrationBuilder.AddColumn<Guid>(
                name: "TeamId",
                table: "Players",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("23cc11ad-f3b9-4a3e-ad03-fd02d9993a2c"), 4, 2, 1, 4, "4-4-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("a29123bf-c832-460a-886c-e3d848de5b5f"), 5, 2, 1, 3, "5-3-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("a74a3ed1-f780-4908-a697-c8472fe0745f"), 4, 3, 1, 3, "4-3-3" });

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

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

            migrationBuilder.DropIndex(
                name: "IX_Players_TeamId",
                table: "Players");

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("23cc11ad-f3b9-4a3e-ad03-fd02d9993a2c"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("a29123bf-c832-460a-886c-e3d848de5b5f"));

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: new Guid("a74a3ed1-f780-4908-a697-c8472fe0745f"));

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "Player10Id",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player11Id",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player1Id",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player2Id",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player3Id",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player4Id",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player5Id",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player6Id",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player7Id",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player8Id",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Player9Id",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("5bd3b67f-d785-4cee-9711-61ffd7fbb8ad"), 4, 2, 1, 4, "4-4-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("55e410f7-8a3c-40f9-ac5f-4cf5cfa6ec80"), 5, 2, 1, 3, "5-3-2" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Defenders", "Forwards", "Goalkeepers", "Midfielders", "Name" },
                values: new object[] { new Guid("adf5739e-a22f-4d49-bd49-8ac77784e8c2"), 4, 3, 1, 3, "4-3-3" });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Player10Id",
                table: "Teams",
                column: "Player10Id");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Player11Id",
                table: "Teams",
                column: "Player11Id");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Player1Id",
                table: "Teams",
                column: "Player1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Player2Id",
                table: "Teams",
                column: "Player2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Player3Id",
                table: "Teams",
                column: "Player3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Player4Id",
                table: "Teams",
                column: "Player4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Player5Id",
                table: "Teams",
                column: "Player5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Player6Id",
                table: "Teams",
                column: "Player6Id");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Player7Id",
                table: "Teams",
                column: "Player7Id");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Player8Id",
                table: "Teams",
                column: "Player8Id");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Player9Id",
                table: "Teams",
                column: "Player9Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_Player10Id",
                table: "Teams",
                column: "Player10Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_Player11Id",
                table: "Teams",
                column: "Player11Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_Player1Id",
                table: "Teams",
                column: "Player1Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_Player2Id",
                table: "Teams",
                column: "Player2Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_Player3Id",
                table: "Teams",
                column: "Player3Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_Player4Id",
                table: "Teams",
                column: "Player4Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_Player5Id",
                table: "Teams",
                column: "Player5Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_Player6Id",
                table: "Teams",
                column: "Player6Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_Player7Id",
                table: "Teams",
                column: "Player7Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_Player8Id",
                table: "Teams",
                column: "Player8Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_Player9Id",
                table: "Teams",
                column: "Player9Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
