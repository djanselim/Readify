using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Readify.Infrastructure.Migrations
{
    public partial class AuthorPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Authors",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                comment: "Auhtor's Phone Number");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0728d831-96ec-43ee-aaf7-41c9d19d8683", "AQAAAAEAACcQAAAAEE3C0WMARrNcNV4BZG+mAMmO/kPael8JbrLXXkpP8z1maru7WYKn9SymPQCDfW49jQ==", "a88746c9-aa84-4b01-9060-5c91c1140107" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a37a8e2a-9356-4f19-b57c-519c7074d48e", "AQAAAAEAACcQAAAAENGNTt7HI8sDo0KG3NLharKNd+grMlbJ9kPmy4wDyIqiHZ08m0CoDKLmI09iwFmJ6g==", "797d6091-4436-464d-a5c9-bbf0f3d77906" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84aed177-171c-4792-8548-8b820ce2b9f9", "AQAAAAEAACcQAAAAEJ9G/HlYs5f63yvIYyJqd3YSLZleDPU63cQcIjv8/Kn+hAQlv1m00/qC4PrdJz+8qQ==", "1eeae24e-a37f-4f2f-a9e9-df17201c1e90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c63e7c0c-75a7-44b9-971e-84340b56f516", "AQAAAAEAACcQAAAAEKckJ52uEA/tkftlzVLMo3Ncg7ygSDeUAcVyDQqMlD3roeB+TZva6eYb3O4xB8W9Yg==", "c71a715a-c305-40fb-8b42-c9cac02c1eef" });
        }
    }
}
