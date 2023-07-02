using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class ChangedEmployeeIdDataTypeLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "674513af-5dd6-1d51-b63c-46c24a668f27",
                column: "ConcurrencyStamp",
                value: "62e3da4a-0196-4c0f-a29b-e867b02055c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "974513aa-5dd6-1d51-b63a-46c24a668f27",
                column: "ConcurrencyStamp",
                value: "1e967e86-8781-4f6b-8c4a-e3a7abcaca96");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88041755-041a-471c-83c7-0d2a73223832",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27777a2a-0d88-4710-a442-2db6349d6319", "AQAAAAEAACcQAAAAEDBqiIl6oHtJWfRamRrf6hMKORt8tyMDaSf+JaOzsovP/tSs/g9f3Q6o0n4tIJoMEg==", "d6d35c2a-7dcc-45d4-a586-63e842bdad1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98041755-041b-471b-83c7-0d2b73223833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d248a28a-241e-41cd-b3c3-8d2b5153e182", "AQAAAAEAACcQAAAAEL6OPdZeczjcbzQqyy7WZbwppv2gQ6NHMDjQEf1GgTkpA/ua+FyVj641vTTFfyX2sw==", "b2aee30c-1538-4d0b-93fd-de055a6fd72e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "674513af-5dd6-1d51-b63c-46c24a668f27",
                column: "ConcurrencyStamp",
                value: "aeb8d29e-697a-44b8-befd-98bba37975c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "974513aa-5dd6-1d51-b63a-46c24a668f27",
                column: "ConcurrencyStamp",
                value: "ce0716d3-e21e-4393-b8b2-5aa4eaa3bf70");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88041755-041a-471c-83c7-0d2a73223832",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3669f5a5-9381-4e08-b259-0dd0f574ded3", "AQAAAAEAACcQAAAAEFLcpHWURJObHyGG/Co5yDd6kUyOvWaMcFPG+ABeHCUorxSdyN9La5OmGxe65EDO2w==", "eee2080c-eded-442e-9f8b-f38bfe87a2af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98041755-041b-471b-83c7-0d2b73223833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1abf7e7-6fba-46e6-b52d-e3a31b1cde9c", "AQAAAAEAACcQAAAAEOCsIimYjxpHJren6/vf7OlSV2ufuyP5gtFmkasPiaf7ZDFn2XGQKdhL7Mnh2bqyOg==", "e5d85cdb-87de-4f52-bf85-a292943c9827" });
        }
    }
}
