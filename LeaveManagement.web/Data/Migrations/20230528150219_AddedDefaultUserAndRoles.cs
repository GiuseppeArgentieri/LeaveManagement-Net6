using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class AddedDefaultUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DAteJoined",
                table: "AspNetUsers",
                newName: "DateJoined");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "674513af-5dd6-1d51-b63c-46c24a668f27", "b3828986-f5ef-41e2-99f4-ce5a7cf5e88d", "Administrator", "ADMINISTRATOR" },
                    { "974513aa-5dd6-1d51-b63a-46c24a668f27", "3c96bfb1-2e22-4aef-965e-741fd6218f8e", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "88041755-041a-471c-83c7-0d2a73223832", 0, "0ebcb3cb-25d8-45cc-8119-b18c15fd0e31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEDF33g6CEVWQFXlMyiC64ymqNoy53X1C2S0Ge3WJpUafuV5GMp/4gRP2RUZpqnc0rQ==", null, false, "fe0a1d81-c5bb-423f-8e40-7cde41239d91", null, false, null },
                    { "98041755-041b-471b-83c7-0d2b73223833", 0, "60c66f8c-5495-481f-98c0-aae4e6340a5f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEJw2HVNJ2YK+v+YooF3jIH9+maNucEDLZudM4iNEWJ/S0YLUKDr2Ua5M86u0y8K41w==", null, false, "bd08cc99-8fd2-4355-b912-24f2438947b0", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "974513aa-5dd6-1d51-b63a-46c24a668f27", "88041755-041a-471c-83c7-0d2a73223832" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "674513af-5dd6-1d51-b63c-46c24a668f27", "98041755-041b-471b-83c7-0d2b73223833" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "974513aa-5dd6-1d51-b63a-46c24a668f27", "88041755-041a-471c-83c7-0d2a73223832" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "674513af-5dd6-1d51-b63c-46c24a668f27", "98041755-041b-471b-83c7-0d2b73223833" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "674513af-5dd6-1d51-b63c-46c24a668f27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "974513aa-5dd6-1d51-b63a-46c24a668f27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88041755-041a-471c-83c7-0d2a73223832");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98041755-041b-471b-83c7-0d2b73223833");

            migrationBuilder.RenameColumn(
                name: "DateJoined",
                table: "AspNetUsers",
                newName: "DAteJoined");
        }
    }
}
