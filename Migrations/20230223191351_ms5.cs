using Microsoft.EntityFrameworkCore.Migrations;

namespace Matchtickets1.Migrations
{
    public partial class ms5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchDetails_Stadiumdetails_StadiumdetailId",
                table: "MatchDetails");

            migrationBuilder.DropIndex(
                name: "IX_MatchDetails_StadiumdetailId",
                table: "MatchDetails");

            migrationBuilder.DropColumn(
                name: "StadiumdetailId",
                table: "MatchDetails");

            migrationBuilder.AddColumn<int>(
                name: "StadiumdetailsId",
                table: "MatchDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MatchDetails_StadiumdetailsId",
                table: "MatchDetails",
                column: "StadiumdetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchDetails_Stadiumdetails_StadiumdetailsId",
                table: "MatchDetails",
                column: "StadiumdetailsId",
                principalTable: "Stadiumdetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchDetails_Stadiumdetails_StadiumdetailsId",
                table: "MatchDetails");

            migrationBuilder.DropIndex(
                name: "IX_MatchDetails_StadiumdetailsId",
                table: "MatchDetails");

            migrationBuilder.DropColumn(
                name: "StadiumdetailsId",
                table: "MatchDetails");

            migrationBuilder.AddColumn<int>(
                name: "StadiumdetailId",
                table: "MatchDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MatchDetails_StadiumdetailId",
                table: "MatchDetails",
                column: "StadiumdetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchDetails_Stadiumdetails_StadiumdetailId",
                table: "MatchDetails",
                column: "StadiumdetailId",
                principalTable: "Stadiumdetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
