using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class ChangedLeaveRequestEmployeeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "674513af-5dd6-1d51-b63c-46c24a668f27",
                column: "ConcurrencyStamp",
                value: "0459e7ee-2fb7-4396-b3b7-3cbc2ec399a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "974513aa-5dd6-1d51-b63a-46c24a668f27",
                column: "ConcurrencyStamp",
                value: "3e63109f-131d-4fd4-bc26-82b28c54fb31");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88041755-041a-471c-83c7-0d2a73223832",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff6c80d3-a452-48e7-a437-badf91d68a1c", "AQAAAAEAACcQAAAAEJ3FPQIlvmhuNfZOutqz1RGxrV3pBl45gCDXHomPdE55FSkB+0WewBzPutv56U1Asw==", "9f66c1a6-6cc2-4add-8d36-dfbfa2ba5f30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98041755-041b-471b-83c7-0d2b73223833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "964cd0a0-e924-4f7a-8ffb-784edbc512d4", "AQAAAAEAACcQAAAAEE/lEoA92+7jnaM//kW415Vw2oUCJZR6FG20xPnQrw2PcKdYa3V7fjRdMniQ0flNvA==", "a3255ce1-a752-4c3f-ba36-fad41953c2ac" });
        }
    }
}
