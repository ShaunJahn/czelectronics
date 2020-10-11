using Microsoft.EntityFrameworkCore.Migrations;

namespace czelectronics.Data.Migrations
{
    public partial class FixNavs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dbcd78b1-bed2-4a6d-96bb-adeb4d4c5bc0", "6d324d0d-0356-4c28-a588-8acac52e0d0b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7900a2d6-0914-47b6-98e8-704e4cd273b4", "d4a02ba5-a890-4d45-9228-06f6eeecc629", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f8aa992-37a1-459f-8e7b-406e4a57071f", "1661e3f8-b366-4031-9884-cae8c11df45f", "Courier", "COURIER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f8aa992-37a1-459f-8e7b-406e4a57071f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7900a2d6-0914-47b6-98e8-704e4cd273b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbcd78b1-bed2-4a6d-96bb-adeb4d4c5bc0");

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
    }
}
