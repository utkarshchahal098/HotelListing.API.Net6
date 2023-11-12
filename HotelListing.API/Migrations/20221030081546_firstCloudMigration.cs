using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    public partial class firstCloudMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52b834b2-b4dd-4f55-8908-a80d8896e5c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "650d5da5-b1ef-4032-bfdd-b547d9a18194");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "225bc878-1852-4294-abc4-e18c12ebb939", "f776c934-429e-4bb7-b9ad-4c157dd54e35", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e22a21f-4c44-4e18-85a8-1aa2ecf565b1", "ad9d8ab9-8c30-4961-9d32-08f07a9d7f44", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "52b834b2-b4dd-4f55-8908-a80d8896e5c8", "bc0fc4f9-bed7-4f75-9675-805fbf637dc0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "650d5da5-b1ef-4032-bfdd-b547d9a18194", "6806b64f-dd6b-429d-aae4-1ec45e6d0163", "User", "USER" });
        }
    }
}
