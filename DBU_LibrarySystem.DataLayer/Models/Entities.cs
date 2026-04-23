using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBU_LibrarySystem.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        // Roles: Admin, Librarian, Student
        [Required]
        public string Role { get; set; }
        
        public string Password { get; set; }
        
        // New fields for Student Registration
        public string? ContactNumber { get; set; }
        public string? IDCardImagePath { get; set; }
        public bool IsApproved { get; set; } = true;

        // For Students: Max 3 books
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    }

    public class Book
    {
        [Key]
        public string ISBN { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Author { get; set; }
        
        public string Category { get; set; }
        
        public int YearOfPublication { get; set; }
        
        public ICollection<BookCopy> Copies { get; set; } = new List<BookCopy>();
    }

    public class BookCopy
    {
        [Key]
        public string CopyId { get; set; }
        
        [Required]
        [ForeignKey("Book")]
        public string ISBN { get; set; }
        public Book Book { get; set; }
        
        // Available, Borrowed, Lost, Reserved
        [Required]
        public string Status { get; set; } = "Available";
    }

    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        
        [Required]
        [ForeignKey("BookCopy")]
        public string CopyId { get; set; }
        public BookCopy BookCopy { get; set; }
        
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        
        public decimal FineAmount { get; set; } = 0;
        public bool IsFinePaid { get; set; } = false;
        
        // Active, Returned, Lost
        public string Status { get; set; } = "Active";
    }

    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        // Can reserve a specific copy or just the book. Reserving a specific copy is easier for tracking:
        [Required]
        [ForeignKey("BookCopy")]
        public string CopyId { get; set; }
        public BookCopy BookCopy { get; set; }

        public DateTime ReservationDate { get; set; }
        public DateTime ExpiryDate { get; set; } // When the reservation expires if they don't pick it up

        // Pending, Ready, Completed, Cancelled
        public string Status { get; set; } = "Pending";
    }

    public class Notification
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        public string Message { get; set; }
        public DateTime Date { get; set; }
        public bool IsRead { get; set; } = false;

        // Reminder, Overdue, General
        public string Type { get; set; }
    }
}
