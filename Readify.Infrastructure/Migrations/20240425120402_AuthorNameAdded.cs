using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Readify.Infrastructure.Migrations
{
    public partial class AuthorNameAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Author's Name");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b29213b-c6e7-41df-96ac-94bc8970882f", "AQAAAAEAACcQAAAAEPLxHbPmaqj2bEf/9J2O3bkRtMfGfZkLVE3KqBEO3UELqD4JctfeuSMVKWOiThXn2g==", "eaa61f05-cc98-41c8-980f-ad1235899204" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0164a576-63bc-46cc-ae75-daf37f8849cc", "AQAAAAEAACcQAAAAEDBqdnVB8/Bawyqs12NcrmzMNtjX2wc1epY3pMQdMtjSHhQM1Vuv0gpa0vSq4xr6FQ==", "ad6ea071-8fc4-4fa9-a1da-3c272ec1bd81" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "FullName",
                value: "");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_PhoneNumber",
                table: "Authors",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Authors_PhoneNumber",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Authors");

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
        }
    }
}
