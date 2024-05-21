using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedLeaveRequestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LeaveRequests",
                columns: new[] { "Id", "Approved", "Cancelled", "CreatedBy", "DateActioned", "DateCreated", "DateRequested", "EndDate", "LastModifiedBy", "LastModifiedDate", "LeaveTypeId", "RequestComments", "RequestingEmployeeId", "StartDate" },
                values: new object[] { 1, null, false, "Admin", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 2, 7, 34, 680, DateTimeKind.Utc).AddTicks(197), new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Utc), "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Very urgent", "1", new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
