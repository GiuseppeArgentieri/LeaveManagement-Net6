using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class UpdatedRequestComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "674513af-5dd6-1d51-b63c-46c24a668f27",
                column: "ConcurrencyStamp",
                value: "19d6a2df-a36a-4537-9aec-e0fb8c9b78c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "974513aa-5dd6-1d51-b63a-46c24a668f27",
                column: "ConcurrencyStamp",
                value: "7a8f7417-f02b-4c55-b86a-17b61fd509d9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88041755-041a-471c-83c7-0d2a73223832",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd5ca5fb-1f27-4641-a301-294cfd1408dc", "AQAAAAEAACcQAAAAELSH+jhYZp3h6fwFd5iitiFBir5YAiJ0xJ7UOUNkMCVJNkO5CMGR99wzMTt5vSYYpA==", "deaed75d-4e68-4b3b-bcb4-e9109fdd64bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98041755-041b-471b-83c7-0d2b73223833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1876b36e-f941-4b22-af26-c4e890720525", "AQAAAAEAACcQAAAAEG7yitNSwt8aAwlcfD1JIy90c7mFUz1ciijCV9zQCakgd8tvUBrrUPhTC9k9mGR7pQ==", "1501f784-214f-4454-b7f2-942c90e2dc21" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "674513af-5dd6-1d51-b63c-46c24a668f27",
                column: "ConcurrencyStamp",
                value: "4987dede-e854-4c1a-9e9f-d5204344f97c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "974513aa-5dd6-1d51-b63a-46c24a668f27",
                column: "ConcurrencyStamp",
                value: "9281c2dd-f168-4b7d-a709-630ca1cc87cd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88041755-041a-471c-83c7-0d2a73223832",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcf21008-6620-4cc3-ba04-2e93eed5311c", "AQAAAAEAACcQAAAAEN11dOI/0QTMY9vWXhSWvhZkCnlAb7DxCyGi6yiM742b061QguvRaI1nDRHJMQOrFQ==", "a62c08d2-3694-4d74-8acd-ef35689fd834" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98041755-041b-471b-83c7-0d2b73223833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "103f2f0c-1c0b-4b88-9740-57d0d5cdbac8", "AQAAAAEAACcQAAAAEHRDfimNpeinKzlTPzAhAUs/czkEo79IPBVoYY9mOLguD6QB7GcMJd3UpBCqexi1xw==", "ebcca106-944f-4115-a01d-e537fb07ad6c" });
        }
    }
}
