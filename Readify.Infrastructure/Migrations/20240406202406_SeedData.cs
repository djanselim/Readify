using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Readify.Infrastructure.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "84aed177-171c-4792-8548-8b820ce2b9f9", "guest@mail.com", false, false, null, "guest@mail.com", "GUEST", "AQAAAAEAACcQAAAAEJ9G/HlYs5f63yvIYyJqd3YSLZleDPU63cQcIjv8/Kn+hAQlv1m00/qC4PrdJz+8qQ==", null, false, "1eeae24e-a37f-4f2f-a9e9-df17201c1e90", false, "guest" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "c63e7c0c-75a7-44b9-971e-84340b56f516", "author@mail.com", false, false, null, "author@mail.com", "AUTHOR", "AQAAAAEAACcQAAAAEKckJ52uEA/tkftlzVLMo3Ncg7ygSDeUAcVyDQqMlD3roeB+TZva6eYb3O4xB8W9Yg==", null, false, "c71a715a-c305-40fb-8b42-c9cac02c1eef", false, "author" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fiction" },
                    { 2, "Non-Fiction" },
                    { 3, "Mystery & Thriller" },
                    { 4, "Science Fiction & Fantasy" },
                    { 5, "Romance" },
                    { 6, "Historical Fiction" },
                    { 7, "Biography & Memoir" },
                    { 8, "Self-Help & Personal Development" },
                    { 9, "Business & Economics" },
                    { 10, "History" },
                    { 11, "Travel" },
                    { 12, "Billing" },
                    { 13, "Art & Photography" },
                    { 14, "Science & Nature" },
                    { 15, "Religion & Spirituality" },
                    { 16, "Health & Fitness" },
                    { 17, "Children's Books" },
                    { 18, "Young Adult" },
                    { 19, "Graphic Novels & Comics" },
                    { 20, "Poetry" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CategoryId", "DateOfPublication", "Description", "ImageUrl", "Language", "Price", "Rating", "Title" },
                values: new object[] { 1, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Great Gatsby is a 1925 novel by American writer F. Scott Fitzgerald. Set in the Jazz Age on Long Island, near New York City, the novel depicts first-person narrator Nick Carraway's interactions with mysterious millionaire Jay Gatsby and Gatsby's obsession to reunite with his former lover, Daisy Buchanan.", "https://upload.wikimedia.org/wikipedia/commons/7/7a/The_Great_Gatsby_Cover_1925_Retouched.jpg", "", 0m, 4.5m, "The Great Gatsby" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CategoryId", "DateOfPublication", "Description", "ImageUrl", "Language", "Price", "Rating", "Title" },
                values: new object[] { 2, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "To Kill a Mockingbird is a novel by the American author Harper Lee. It was published in 1960 and was instantly successful. In the United States, it is widely read in high schools and middle schools.", "https://m.media-amazon.com/images/I/71FxgtFKcQL._AC_UF1000,1000_QL80_.jpg", "", 0m, 4.8m, "To Kill a Mockingbird" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CategoryId", "DateOfPublication", "Description", "ImageUrl", "Language", "Price", "Rating", "Title" },
                values: new object[] { 3, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nineteen Eighty-Four: A Novel, often referred to as 1984, is a dystopian social science fiction novel by the English novelist George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.", "https://m.media-amazon.com/images/I/71rpa1-kyvL._AC_UF1000,1000_QL80_.jpg", "", 0m, 4.9m, "1984" });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
