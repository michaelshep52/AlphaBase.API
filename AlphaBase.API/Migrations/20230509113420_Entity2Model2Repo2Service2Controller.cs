using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alpha.API.Migrations
{
    /// <inheritdoc />
    public partial class Entity2Model2Repo2Service2Controller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Phone",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 1,
                columns: new[] { "Address2", "Address3" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Phone",
                keyColumn: "PhoneId",
                keyValue: 1,
                column: "PhoneNumber",
                value: "606-438-4485");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "AddressId",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Phone",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "AddressId",
                keyValue: 1,
                columns: new[] { "Address2", "Address3" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Phone",
                keyColumn: "PhoneId",
                keyValue: 1,
                column: "PhoneNumber",
                value: -4317);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "AddressId",
                value: 1);
        }
    }
}
