using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class AddedDefaultUserUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "674513af-5dd6-1d51-b63c-46c24a668f27",
                column: "ConcurrencyStamp",
                value: "55858837-e958-4376-8177-aec3dd00338f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "974513aa-5dd6-1d51-b63a-46c24a668f27",
                column: "ConcurrencyStamp",
                value: "044fe768-9586-4252-a063-6bc9a1fa3cf1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88041755-041a-471c-83c7-0d2a73223832",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b5e65461-939c-4def-a3fb-7d039e1ad873", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEH91hgr6LFw9rGNJagsT7tmVJi6W0hGrTZHxnZ18OlcBr0qPWg5t6iwPjk/YYD1ViA==", "effce485-c015-4caa-86cf-9af93bc90370", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98041755-041b-471b-83c7-0d2b73223833",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "487dc1c8-4541-4bea-ba03-cfba56682212", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJJaoqvyJKmZGh8hOjOq2iUTupLfY1CTGAal4ojQSJGTbG5uUy5kOEw9IPFjmpCZoA==", "b83759b5-c5b8-42a0-a128-441eaff25cf3", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "674513af-5dd6-1d51-b63c-46c24a668f27",
                column: "ConcurrencyStamp",
                value: "b3828986-f5ef-41e2-99f4-ce5a7cf5e88d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "974513aa-5dd6-1d51-b63a-46c24a668f27",
                column: "ConcurrencyStamp",
                value: "3c96bfb1-2e22-4aef-965e-741fd6218f8e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88041755-041a-471c-83c7-0d2a73223832",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0ebcb3cb-25d8-45cc-8119-b18c15fd0e31", false, null, "AQAAAAEAACcQAAAAEDF33g6CEVWQFXlMyiC64ymqNoy53X1C2S0Ge3WJpUafuV5GMp/4gRP2RUZpqnc0rQ==", "fe0a1d81-c5bb-423f-8e40-7cde41239d91", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98041755-041b-471b-83c7-0d2b73223833",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "60c66f8c-5495-481f-98c0-aae4e6340a5f", false, null, "AQAAAAEAACcQAAAAEJw2HVNJ2YK+v+YooF3jIH9+maNucEDLZudM4iNEWJ/S0YLUKDr2Ua5M86u0y8K41w==", "bd08cc99-8fd2-4355-b912-24f2438947b0", null });
        }
    }
}
