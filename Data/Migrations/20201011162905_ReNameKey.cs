using Microsoft.EntityFrameworkCore.Migrations;

namespace czelectronics.Data.Migrations
{
    public partial class ReNameKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Forms_FormId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FormId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Forms",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "FormId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FormId",
                table: "Forms");

            migrationBuilder.AddColumn<int>(
                name: "FormUserInputId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FormUserInputId",
                table: "Forms",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Forms",
                table: "Forms",
                column: "FormUserInputId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_FormUserInputId",
                table: "Products",
                column: "FormUserInputId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Forms_FormUserInputId",
                table: "Products",
                column: "FormUserInputId",
                principalTable: "Forms",
                principalColumn: "FormUserInputId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Forms_FormUserInputId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FormUserInputId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Forms",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "FormUserInputId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FormUserInputId",
                table: "Forms");

            migrationBuilder.AddColumn<int>(
                name: "FormId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FormId",
                table: "Forms",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Forms",
                table: "Forms",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_FormId",
                table: "Products",
                column: "FormId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Forms_FormId",
                table: "Products",
                column: "FormId",
                principalTable: "Forms",
                principalColumn: "FormId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
