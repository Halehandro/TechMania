using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcess.Migrations
{
    public partial class AddAddressToOrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckInDate",
                table: "SmartPhoneOrderDetails");

            migrationBuilder.DropColumn(
                name: "CheckOutDate",
                table: "SmartPhoneOrderDetails");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "SmartPhoneOrderDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "SmartPhoneOrderDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "SmartPhoneOrderDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "SmartPhoneOrderDetails");

            migrationBuilder.DropColumn(
                name: "City",
                table: "SmartPhoneOrderDetails");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "SmartPhoneOrderDetails");

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
    }
}
