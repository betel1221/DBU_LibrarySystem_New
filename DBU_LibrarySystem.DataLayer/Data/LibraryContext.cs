using Microsoft.EntityFrameworkCore;
using DBU_LibrarySystem.Models;
using System;

namespace DBU_LibrarySystem.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
            Database.EnsureCreated();
        }

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
                new User { UserId = "std1", Name = "Alice Student", Role = "Student", Password = "student", IsApproved = true },
                new User { UserId = "std2", Name = "Bob Smith", Role = "Student", Password = "password123", IsApproved = true },
                new User { UserId = "std3", Name = "Charlie Davis", Role = "Student", Password = "password123", IsApproved = false },
                new User { UserId = "staff1", Name = "John Staff", Role = "Librarian", Password = "staff", IsApproved = true }
            );

            // Seed Books
            modelBuilder.Entity<Book>().HasData(
                new Book { ISBN = "978-0131103627", Title = "The C Programming Language", Author = "Brian W. Kernighan", Category = "Programming", YearOfPublication = 1988 },
                new Book { ISBN = "978-0201616224", Title = "The Pragmatic Programmer", Author = "Andy Hunt", Category = "Software Engineering", YearOfPublication = 1999 },
                new Book { ISBN = "978-0132350884", Title = "Clean Code", Author = "Robert C. Martin", Category = "Programming", YearOfPublication = 2008 },
                new Book { ISBN = "978-0596007126", Title = "Head First Design Patterns", Author = "Eric Freeman", Category = "Design", YearOfPublication = 2004 },
                new Book { ISBN = "978-0262033848", Title = "Introduction to Algorithms", Author = "Thomas H. Cormen", Category = "Computer Science", YearOfPublication = 2009 },
                new Book { ISBN = "978-0321125217", Title = "Refactoring", Author = "Martin Fowler", Category = "Software Engineering", YearOfPublication = 1999 }
            );

            // Seed Copies
            modelBuilder.Entity<BookCopy>().HasData(
                new BookCopy { CopyId = "1001-C1", ISBN = "978-0131103627", Status = "Available" },
                new BookCopy { CopyId = "1002-C1", ISBN = "978-0201616224", Status = "Borrowed" }, // std2
                new BookCopy { CopyId = "1003-C1", ISBN = "978-0132350884", Status = "Borrowed" }, // std1
                new BookCopy { CopyId = "1004-C1", ISBN = "978-0596007126", Status = "Borrowed" }, // std2
                new BookCopy { CopyId = "1005-C1", ISBN = "978-0262033848", Status = "Available" },
                new BookCopy { CopyId = "1006-C1", ISBN = "978-0321125217", Status = "Reserved" }  // std2
            );

            // Seed Transactions
            modelBuilder.Entity<Transaction>().HasData(
                new Transaction { Id = 1, UserId = "std1", CopyId = "1003-C1", BorrowDate = new DateTime(2026, 3, 1), DueDate = new DateTime(2026, 3, 11), Status = "Active" }, // Large Fine
                new Transaction { Id = 2, UserId = "std2", CopyId = "1005-C1", BorrowDate = new DateTime(2026, 4, 10), DueDate = new DateTime(2026, 4, 17), Status = "Returned", ReturnDate = new DateTime(2026, 4, 17), FineAmount = 0 },
                new Transaction { Id = 3, UserId = "std2", CopyId = "1002-C1", BorrowDate = new DateTime(2026, 4, 23), DueDate = new DateTime(2026, 5, 7), Status = "Active" },
                new Transaction { Id = 4, UserId = "std2", CopyId = "1004-C1", BorrowDate = new DateTime(2026, 4, 20), DueDate = new DateTime(2026, 5, 4), Status = "Active" }
            );

            // Seed Reservations
            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, UserId = "std2", CopyId = "1006-C1", ReservationDate = new DateTime(2026, 4, 25), Status = "Active" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
