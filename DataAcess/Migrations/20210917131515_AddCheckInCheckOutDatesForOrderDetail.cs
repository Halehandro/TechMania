using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcess.Migrations
{
    public partial class AddCheckInCheckOutDatesForOrderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ActualCheckInDate",
                table: "SmartPhoneOrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ActualCheckOutDate",
                table: "SmartPhoneOrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckInDate",
                table: "SmartPhoneOrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckOutDate",
                table: "SmartPhoneOrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualCheckInDate",
                table: "SmartPhoneOrderDetails");

            migrationBuilder.DropColumn(
                name: "ActualCheckOutDate",
                table: "SmartPhoneOrderDetails");

            migrationBuilder.DropColumn(
                name: "CheckInDate",
                table: "SmartPhoneOrderDetails");

            migrationBuilder.DropColumn(
                name: "CheckOutDate",
                table: "SmartPhoneOrderDetails");
        }
    }
}
