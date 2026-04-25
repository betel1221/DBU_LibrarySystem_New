using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBU_LibrarySystem.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfficeNumber",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2026, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "DueDate" },
                values: new object[] { new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BorrowDate", "DueDate", "ReturnDate" },
                values: new object[] { new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BorrowDate", "DueDate" },
                values: new object[] { new DateTime(2026, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BorrowDate", "DueDate" },
                values: new object[] { new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OfficeNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "admin",
                column: "OfficeNumber",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "lib",
                column: "OfficeNumber",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "staff1",
                column: "OfficeNumber",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "std1",
                column: "OfficeNumber",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "std2",
                column: "OfficeNumber",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "std3",
                column: "OfficeNumber",
                value: null);
        }
    }
}
