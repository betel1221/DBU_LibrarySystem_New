using Microsoft.EntityFrameworkCore;
using DBU_LibrarySystem.Models;
using System;

namespace DBU_LibrarySystem.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCopy> BookCopies { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(local);Database=DBU_LibraryDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User { UserId = "admin", Name = "System Admin", Role = "Admin", Password = "admin", IsApproved = true },
                new User { UserId = "lib", Name = "Main Librarian", Role = "Librarian", Password = "lib", IsApproved = true },
                new User { UserId = "std1", Name = "Alice Student", Role = "Student", Password = "student", IsApproved = true }
            );

            // Seed Books
            modelBuilder.Entity<Book>().HasData(
                new Book { ISBN = "978-0131103627", Title = "The C Programming Language", Author = "Brian W. Kernighan", Category = "Programming", YearOfPublication = 1988 },
                new Book { ISBN = "978-0201616224", Title = "The Pragmatic Programmer", Author = "Andy Hunt", Category = "Software Engineering", YearOfPublication = 1999 },
                new Book { ISBN = "978-0132350884", Title = "Clean Code", Author = "Robert C. Martin", Category = "Programming", YearOfPublication = 2008 }
            );

            // Seed Copies
            modelBuilder.Entity<BookCopy>().HasData(
                new BookCopy { CopyId = "C1", ISBN = "978-0131103627", Status = "Available" },
                new BookCopy { CopyId = "C2", ISBN = "978-0131103627", Status = "Available" },
                new BookCopy { CopyId = "C3", ISBN = "978-0201616224", Status = "Available" },
                new BookCopy { CopyId = "C4", ISBN = "978-0201616224", Status = "Borrowed" },
                new BookCopy { CopyId = "C5", ISBN = "978-0132350884", Status = "Available" }
            );

            // Seed Transaction
            modelBuilder.Entity<Transaction>().HasData(
                new Transaction {
                    Id = 1,
                    UserId = "std1",
                    CopyId = "C4",
                    BorrowDate = new DateTime(2023, 10, 1),
                    DueDate = new DateTime(2023, 10, 15),
                    Status = "Active"
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
