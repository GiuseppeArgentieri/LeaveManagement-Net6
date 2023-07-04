using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDatemodified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
