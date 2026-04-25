using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DBU_LibrarySystem.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentAndPosition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "CopyId",
                keyValue: "C1");

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "CopyId",
                keyValue: "C2");

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "CopyId",
                keyValue: "C3");

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "CopyId",
                keyValue: "C4");

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "CopyId",
                keyValue: "C5");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "CopyId", "ISBN", "Status" },
                values: new object[,]
                {
                    { "1001-C1", "978-0131103627", "Available" },
                    { "1002-C1", "978-0201616224", "Borrowed" },
                    { "1003-C1", "978-0132350884", "Borrowed" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ISBN", "Author", "Category", "Title", "YearOfPublication" },
                values: new object[,]
                {
                    { "978-0262033848", "Thomas H. Cormen", "Computer Science", "Introduction to Algorithms", 2009 },
                    { "978-0321125217", "Martin Fowler", "Software Engineering", "Refactoring", 1999 },
                    { "978-0596007126", "Eric Freeman", "Design", "Head First Design Patterns", 2004 }
                });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "CopyId", "DueDate" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 57, 37, 399, DateTimeKind.Local).AddTicks(9053), "1003-C1", new DateTime(2026, 3, 26, 7, 57, 37, 401, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "admin",
                columns: new[] { "Department", "Position" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "lib",
                columns: new[] { "Department", "Position" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "std1",
                columns: new[] { "Department", "Position" },
                values: new object[] { null, null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ContactNumber", "Department", "IDCardImagePath", "IsApproved", "Name", "Password", "Position", "Role" },
                values: new object[,]
                {
                    { "staff1", null, null, null, true, "John Staff", "staff", null, "Librarian" },
                    { "std2", null, null, null, true, "Bob Smith", "password123", null, "Student" },
                    { "std3", null, null, null, false, "Charlie Davis", "password123", null, "Student" }
                });

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "CopyId", "ISBN", "Status" },
                values: new object[,]
                {
                    { "1004-C1", "978-0596007126", "Borrowed" },
                    { "1005-C1", "978-0262033848", "Available" },
                    { "1006-C1", "978-0321125217", "Reserved" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "BorrowDate", "CopyId", "DueDate", "FineAmount", "IsFinePaid", "ReturnDate", "Status", "UserId" },
                values: new object[] { 3, new DateTime(2026, 4, 23, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(4180), "1002-C1", new DateTime(2026, 5, 7, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(4190), 0m, false, null, "Active", "std2" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CopyId", "ExpiryDate", "ReservationDate", "Status", "UserId" },
                values: new object[] { 1, "1006-C1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 25, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(9870), "Active", "std2" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "BorrowDate", "CopyId", "DueDate", "FineAmount", "IsFinePaid", "ReturnDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2026, 4, 10, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(1278), "1005-C1", new DateTime(2026, 4, 17, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(1289), 0m, false, new DateTime(2026, 4, 17, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(1291), "Returned", "std2" },
                    { 4, new DateTime(2026, 4, 20, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(4194), "1004-C1", new DateTime(2026, 5, 4, 7, 57, 37, 402, DateTimeKind.Local).AddTicks(4196), 0m, false, null, "Active", "std2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "CopyId",
                keyValue: "1001-C1");

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "CopyId",
                keyValue: "1003-C1");

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "staff1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "std3");

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "CopyId",
                keyValue: "1002-C1");

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "CopyId",
                keyValue: "1004-C1");

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "CopyId",
                keyValue: "1005-C1");

            migrationBuilder.DeleteData(
                table: "BookCopies",
                keyColumn: "CopyId",
                keyValue: "1006-C1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "std2");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0262033848");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0321125217");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0596007126");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Users");

            migrationBuilder.InsertData(
                table: "BookCopies",
                columns: new[] { "CopyId", "ISBN", "Status" },
                values: new object[,]
                {
                    { "C1", "978-0131103627", "Available" },
                    { "C2", "978-0131103627", "Available" },
                    { "C3", "978-0201616224", "Available" },
                    { "C4", "978-0201616224", "Borrowed" },
                    { "C5", "978-0132350884", "Available" }
                });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorrowDate", "CopyId", "DueDate" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C4", new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
