using Microsoft.EntityFrameworkCore.Migrations;

namespace Matchtickets1.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "MatchticketBookings");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "MatchDetails",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "MatchDetails");

            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "MatchticketBookings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
