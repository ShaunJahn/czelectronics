using Microsoft.EntityFrameworkCore.Migrations;

namespace czelectronics.Data.Migrations
{
    public partial class FixICollectionProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Forms_StatusId",
                table: "Forms");

            migrationBuilder.DropIndex(
                name: "IX_Forms_StoreCodeId",
                table: "Forms");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "1e2e619f-43bc-4d8f-aa63-a46cb06f0d20");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "5ed2ffa0-f0ad-42f0-94d6-b41d3984cd26");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "931bcc44-fdfe-4670-ad21-caaf59bdae8f");

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[] { "43401aad-d710-491b-9d51-8b483a696426", "6e7495c5-3687-44d6-9b7b-4a1832389115", "User", "USER" });

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[] { "48110906-4124-43c8-859c-e6c94b09e508", "e54105b8-9908-4a64-8202-9af1f37ab518", "Admin", "ADMIN" });

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[] { "2c419395-f8c9-43c7-b1cd-df4f13b37bef", "35c131ca-7198-4179-aab7-b8b2cda7669f", "Courier", "COURIER" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_StatusId",
                table: "Forms",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_StoreCodeId",
                table: "Forms",
                column: "StoreCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Forms_StatusId",
                table: "Forms");

            migrationBuilder.DropIndex(
                name: "IX_Forms_StoreCodeId",
                table: "Forms");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c419395-f8c9-43c7-b1cd-df4f13b37bef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43401aad-d710-491b-9d51-8b483a696426");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48110906-4124-43c8-859c-e6c94b09e508");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "931bcc44-fdfe-4670-ad21-caaf59bdae8f", "3359f7a3-e3b4-4267-aa5e-db456ff6fa8c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ed2ffa0-f0ad-42f0-94d6-b41d3984cd26", "527eac8e-b366-4e69-a022-8a25d99e8dd4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e2e619f-43bc-4d8f-aa63-a46cb06f0d20", "0a4ac5aa-8575-40e3-8b83-05790afcbcac", "Courier", "COURIER" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Forms_StatusId",
                table: "Forms",
                column: "StatusId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Forms_StoreCodeId",
                table: "Forms",
                column: "StoreCodeId",
                unique: true);
        }
    }
}
