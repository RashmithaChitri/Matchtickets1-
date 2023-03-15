using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Matchtickets1.Migrations
{
    public partial class ticketbookinginti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchDetails_Stadiumdetails_StadiumdetailsId",
                table: "MatchDetails");

            migrationBuilder.DropTable(
                name: "Stadiumdetails");

            migrationBuilder.DropIndex(
                name: "IX_MatchDetails_StadiumdetailsId",
                table: "MatchDetails");

            migrationBuilder.DropColumn(
                name: "confirmpassword",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "MatchticketBookings");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MatchDetails");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "MatchDetails");

            migrationBuilder.DropColumn(
                name: "StadiumId",
                table: "MatchDetails");

            migrationBuilder.DropColumn(
                name: "StadiumdetailsId",
                table: "MatchDetails");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Registrations",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "contactNo",
                table: "Registrations",
                newName: "ContactNo");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Registrations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RegistrationId",
                table: "MatchticketBookings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "MatchTime",
                table: "MatchDetails",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "MatchName",
                table: "MatchDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NoOfTickets",
                table: "MatchDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StadiumName",
                table: "MatchDetails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TicketPrice",
                table: "MatchDetails",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "RegistrationId",
                table: "MatchticketBookings");

            migrationBuilder.DropColumn(
                name: "MatchName",
                table: "MatchDetails");

            migrationBuilder.DropColumn(
                name: "NoOfTickets",
                table: "MatchDetails");

            migrationBuilder.DropColumn(
                name: "StadiumName",
                table: "MatchDetails");

            migrationBuilder.DropColumn(
                name: "TicketPrice",
                table: "MatchDetails");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Registrations",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "ContactNo",
                table: "Registrations",
                newName: "contactNo");

            migrationBuilder.AddColumn<string>(
                name: "confirmpassword",
                table: "Registrations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "MatchticketBookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MatchTime",
                table: "MatchDetails",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MatchDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "MatchDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StadiumId",
                table: "MatchDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StadiumdetailsId",
                table: "MatchDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Stadiumdetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketsAvailable = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadiumdetails", x => x.Id);
                });

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
    }
}
