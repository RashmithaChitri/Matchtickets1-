using Microsoft.EntityFrameworkCore.Migrations;

namespace Matchtickets1.Migrations
{
    public partial class ms7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "MatchticketBookings",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "MatchticketBookings");
        }
    }
}
