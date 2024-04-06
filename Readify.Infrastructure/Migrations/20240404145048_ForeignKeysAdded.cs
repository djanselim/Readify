using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Readify.Infrastructure.Migrations
{
    public partial class ForeignKeysAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Authors");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Authors",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                comment: "User Identifier");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_UserId",
                table: "Authors",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_AspNetUsers_UserId",
                table: "Authors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_AspNetUsers_UserId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_UserId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Authors");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Name of Author");
        }
    }
}
