using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Readify.Infrastructure.Migrations
{
    public partial class AddRatingBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Image URL of the book");

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                comment: "Rating of the book");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Books");
        }
    }
}
