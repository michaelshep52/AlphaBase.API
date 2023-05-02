using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alpha.API.Migrations
{
    /// <inheritdoc />
    public partial class OnModelCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CardType",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Payments");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "FirstName", "LastName", "Password" },
                values: new object[] { 1, "Michael", "Shepherd", "Password1234321!" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "AddressId", "Address1", "Address2", "Address3", "CityTown", "Country", "PostalCode", "StateProvince", "UserId" },
                values: new object[] { 1, "1461 Upper Second Creek Road", "", "", "Hazard", "USA", "41701", "KY", 1 });

            migrationBuilder.InsertData(
                table: "EmailAddresses",
                columns: new[] { "EmailAddressId", "Email", "UserId" },
                values: new object[] { 1, "michaelshep52@gmail.com", 1 });

            migrationBuilder.InsertData(
                table: "Phone",
                columns: new[] { "PhoneId", "PhoneNumber", "UserId" },
                values: new object[] { 1, -4317, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmailAddresses",
                keyColumn: "EmailAddressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "PhoneId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "CardNumber",
                table: "Payments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CardType",
                table: "Payments",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationDate",
                table: "Payments",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Payments",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecurityCode",
                table: "Payments",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
