using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5e65461-939c-4def-a3fb-7d039e1ad873", "AQAAAAEAACcQAAAAEH91hgr6LFw9rGNJagsT7tmVJi6W0hGrTZHxnZ18OlcBr0qPWg5t6iwPjk/YYD1ViA==", "effce485-c015-4caa-86cf-9af93bc90370" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98041755-041b-471b-83c7-0d2b73223833",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "487dc1c8-4541-4bea-ba03-cfba56682212", "AQAAAAEAACcQAAAAEJJaoqvyJKmZGh8hOjOq2iUTupLfY1CTGAal4ojQSJGTbG5uUy5kOEw9IPFjmpCZoA==", "b83759b5-c5b8-42a0-a128-441eaff25cf3" });
        }
    }
}
