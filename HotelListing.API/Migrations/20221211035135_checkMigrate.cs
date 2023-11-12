using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    public partial class checkMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "225bc878-1852-4294-abc4-e18c12ebb939");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e22a21f-4c44-4e18-85a8-1aa2ecf565b1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ef3b9a5-1b0d-417c-ab0c-61f1ff807bdc", "7435b121-9e88-49c4-892c-788357323ae0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d260053e-b42f-4546-bfd1-cacce6d72698", "d2da30e1-78c4-4111-bf0e-b724b799a3ff", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ef3b9a5-1b0d-417c-ab0c-61f1ff807bdc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d260053e-b42f-4546-bfd1-cacce6d72698");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "225bc878-1852-4294-abc4-e18c12ebb939", "f776c934-429e-4bb7-b9ad-4c157dd54e35", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e22a21f-4c44-4e18-85a8-1aa2ecf565b1", "ad9d8ab9-8c30-4961-9d32-08f07a9d7f44", "Admin", "ADMIN" });
        }
    }
}
