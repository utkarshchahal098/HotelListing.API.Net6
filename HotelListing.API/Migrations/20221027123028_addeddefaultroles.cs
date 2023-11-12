using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    public partial class addeddefaultroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52b834b2-b4dd-4f55-8908-a80d8896e5c8", "bc0fc4f9-bed7-4f75-9675-805fbf637dc0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "650d5da5-b1ef-4032-bfdd-b547d9a18194", "6806b64f-dd6b-429d-aae4-1ec45e6d0163", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52b834b2-b4dd-4f55-8908-a80d8896e5c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "650d5da5-b1ef-4032-bfdd-b547d9a18194");
        }
    }
}
