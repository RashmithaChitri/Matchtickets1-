using Microsoft.EntityFrameworkCore.Migrations;

namespace Matchtickets1.Migrations
{
    public partial class ns2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingStatus",
                table: "MatchticketBookings");

            migrationBuilder.DropColumn(
                name: "SeatNumber",
                table: "MatchticketBookings");

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "MatchticketBookings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "MatchticketBookings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "MatchticketBookings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "noofseats",
                table: "MatchticketBookings",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "MatchticketBookings");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "MatchticketBookings");

            migrationBuilder.DropColumn(
                name: "name",
                table: "MatchticketBookings");

            migrationBuilder.DropColumn(
                name: "noofseats",
                table: "MatchticketBookings");

            migrationBuilder.AddColumn<string>(
                name: "BookingStatus",
                table: "MatchticketBookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeatNumber",
                table: "MatchticketBookings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
