using Microsoft.EntityFrameworkCore.Migrations;

namespace Matchtickets1.Migrations
{
    public partial class ticketbookingforeignkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MatchticketBookings_MatchdetailId",
                table: "MatchticketBookings",
                column: "MatchdetailId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchticketBookings_RegistrationId",
                table: "MatchticketBookings",
                column: "RegistrationId");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchticketBookings_MatchDetails_MatchdetailId",
                table: "MatchticketBookings",
                column: "MatchdetailId",
                principalTable: "MatchDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchticketBookings_Registrations_RegistrationId",
                table: "MatchticketBookings",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchticketBookings_MatchDetails_MatchdetailId",
                table: "MatchticketBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchticketBookings_Registrations_RegistrationId",
                table: "MatchticketBookings");

            migrationBuilder.DropIndex(
                name: "IX_MatchticketBookings_MatchdetailId",
                table: "MatchticketBookings");

            migrationBuilder.DropIndex(
                name: "IX_MatchticketBookings_RegistrationId",
                table: "MatchticketBookings");
        }
    }
}
