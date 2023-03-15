using Microsoft.EntityFrameworkCore.Migrations;

namespace Matchtickets1.Migrations
{
    public partial class ms8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "MatchticketBookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "MatchticketBookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "MatchticketBookings",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
