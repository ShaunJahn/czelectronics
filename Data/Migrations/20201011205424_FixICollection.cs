using Microsoft.EntityFrameworkCore.Migrations;

namespace czelectronics.Data.Migrations
{
    public partial class FixICollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Forms_CustomerId",
                table: "Forms");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "4f8aa992-37a1-459f-8e7b-406e4a57071f");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "7900a2d6-0914-47b6-98e8-704e4cd273b4");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "dbcd78b1-bed2-4a6d-96bb-adeb4d4c5bc0");

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[] { "931bcc44-fdfe-4670-ad21-caaf59bdae8f", "3359f7a3-e3b4-4267-aa5e-db456ff6fa8c", "User", "USER" });

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[] { "5ed2ffa0-f0ad-42f0-94d6-b41d3984cd26", "527eac8e-b366-4e69-a022-8a25d99e8dd4", "Admin", "ADMIN" });

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[] { "1e2e619f-43bc-4d8f-aa63-a46cb06f0d20", "0a4ac5aa-8575-40e3-8b83-05790afcbcac", "Courier", "COURIER" });

            migrationBuilder.CreateIndex(
                name: "IX_Forms_CustomerId",
                table: "Forms",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Forms_CustomerId",
                table: "Forms");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e2e619f-43bc-4d8f-aa63-a46cb06f0d20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ed2ffa0-f0ad-42f0-94d6-b41d3984cd26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "931bcc44-fdfe-4670-ad21-caaf59bdae8f");

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

            migrationBuilder.CreateIndex(
                name: "IX_Forms_CustomerId",
                table: "Forms",
                column: "CustomerId",
                unique: true);
        }
    }
}
