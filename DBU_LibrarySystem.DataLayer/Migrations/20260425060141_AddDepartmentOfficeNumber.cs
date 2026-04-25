using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBU_LibrarySystem.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentOfficeNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Users",
                newName: "OfficeNumber");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2026, 4, 25, 9, 1, 32, 815, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "DueDate" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 1, 32, 812, DateTimeKind.Local).AddTicks(3352), new DateTime(2026, 3, 26, 9, 1, 32, 814, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BorrowDate", "DueDate", "ReturnDate" },
                values: new object[] { new DateTime(2026, 4, 10, 9, 1, 32, 814, DateTimeKind.Local).AddTicks(4463), new DateTime(2026, 4, 17, 9, 1, 32, 814, DateTimeKind.Local).AddTicks(4476), new DateTime(2026, 4, 17, 9, 1, 32, 814, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BorrowDate", "DueDate" },
                values: new object[] { new DateTime(2026, 4, 23, 9, 1, 32, 814, DateTimeKind.Local).AddTicks(7094), new DateTime(2026, 5, 7, 9, 1, 32, 814, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BorrowDate", "DueDate" },
                values: new object[] { new DateTime(2026, 4, 20, 9, 1, 32, 814, DateTimeKind.Local).AddTicks(7107), new DateTime(2026, 5, 4, 9, 1, 32, 814, DateTimeKind.Local).AddTicks(7109) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OfficeNumber",
                table: "Users",
                newName: "Position");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2026, 4, 25, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "DueDate" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 57, 37, 399, DateTimeKind.Local).AddTicks(9053), new DateTime(2026, 3, 26, 7, 57, 37, 401, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BorrowDate", "DueDate", "ReturnDate" },
                values: new object[] { new DateTime(2026, 4, 10, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(1278), new DateTime(2026, 4, 17, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(1289), new DateTime(2026, 4, 17, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BorrowDate", "DueDate" },
                values: new object[] { new DateTime(2026, 4, 23, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(4180), new DateTime(2026, 5, 7, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BorrowDate", "DueDate" },
                values: new object[] { new DateTime(2026, 4, 20, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(4194), new DateTime(2026, 5, 4, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(4196) });
        }
    }
}
