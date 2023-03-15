using Microsoft.EntityFrameworkCore.Migrations;

namespace Matchtickets1.Migrations
{
    public partial class ms11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "noofseats",
                table: "MatchticketBookings",
                newName: "NoOfSeats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NoOfSeats",
                table: "MatchticketBookings",
                newName: "noofseats");
        }
    }
}
