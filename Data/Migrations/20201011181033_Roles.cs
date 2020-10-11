using Microsoft.EntityFrameworkCore.Migrations;

namespace czelectronics.Data.Migrations
{
    public partial class Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11065f0c-5657-42a5-8eef-0fdf5b928849", "a4943269-1808-4e63-9e52-4620a26edc4b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac189132-be72-4d79-a591-ad05ed0258de", "5381bc35-919d-4d7c-a4b1-7a26de53a5f2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95d69a7f-0468-45d7-b5e2-a61d5aa0fa45", "02d86510-c599-4dcd-885e-40006e065caf", "Courier", "COURIER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11065f0c-5657-42a5-8eef-0fdf5b928849");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95d69a7f-0468-45d7-b5e2-a61d5aa0fa45");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac189132-be72-4d79-a591-ad05ed0258de");
        }
    }
}
