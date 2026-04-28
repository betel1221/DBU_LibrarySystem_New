using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DBU_LibrarySystem.Models;
using DBU_LibrarySystem.Data;

namespace DBU_LibrarySystem.Services
{
    public static class LibraryManager
    {
        public const decimal FineRatePerDay = 15.0m;
        public const int MaxBorrowLimit = 3;

        // --- BOOK MANAGEMENT ---
        public static void AddBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
        }

        public static void AddOrUpdateBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                var existing = db.Books.Find(book.ISBN);
                if (existing != null)
                {
                    existing.Title = book.Title;
                    existing.Author = book.Author;
                    existing.Category = book.Category;
                    existing.YearOfPublication = book.YearOfPublication;
                }
                else
                {
                    db.Books.Add(book);
                }
                db.SaveChanges();
            }
        }

        public static void UpdateBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                var existing = db.Books.FirstOrDefault(b => b.ISBN == book.ISBN);
                if (existing == null) throw new Exception("Book not found.");
                
                existing.Title = book.Title;
                existing.Author = book.Author;
                existing.Category = book.Category;
                existing.YearOfPublication = book.YearOfPublication;
                
                db.SaveChanges();
            }
        }

        public static void DeleteBook(string isbn)
        {
            using (var db = new LibraryContext())
            {
                var book = db.Books.Include(b => b.Copies).FirstOrDefault(b => b.ISBN == isbn);
                if (book == null) throw new Exception("Book not found.");
                
                // Also remove copies and related data if needed
                db.BookCopies.RemoveRange(book.Copies);
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }

        public static void AddBookCopy(string isbn, string copyId)
        {
            using (var db = new LibraryContext())
            {
                var book = db.Books.FirstOrDefault(b => b.ISBN == isbn);
                if (book == null) throw new Exception("Book not found.");
                if (db.BookCopies.Any(c => c.CopyId == copyId)) throw new Exception("Copy ID already exists.");

                db.BookCopies.Add(new BookCopy { CopyId = copyId, ISBN = isbn, Status = "Available" });
                db.SaveChanges();
            }
        }

        // --- SEARCH ---
        public static List<Book> SearchBooks(string title = null, string author = null, string category = null, string isbn = null, int? year = null)
        {
            using (var db = new LibraryContext())
            {
                var query = db.Books.Include(b => b.Copies).AsQueryable();

                if (!string.IsNullOrEmpty(title))
                    query = query.Where(b => b.Title.ToLower().Contains(title.ToLower()));
                
                if (!string.IsNullOrEmpty(author))
                    query = query.Where(b => b.Author.ToLower().Contains(author.ToLower()));
                
                if (!string.IsNullOrEmpty(category))
                    query = query.Where(b => b.Category.ToLower().Contains(category.ToLower()));
                
                if (!string.IsNullOrEmpty(isbn))
                    query = query.Where(b => b.ISBN.Contains(isbn));

                if (year.HasValue)
                    query = query.Where(b => b.YearOfPublication == year.Value);

                return query.ToList();
            }
        }
        public static List<User> GetAllMembers()
        {
            using (var db = new LibraryContext())
            {
                return db.Users.Where(u => u.Role == "Student" || u.Role == "Employee").ToList();
            }
        }

        public static List<User> SearchMembers(string name = null, string id = null)
        {
            using (var db = new LibraryContext())
            {
                var query = db.Users.Where(u => u.Role == "Student").AsQueryable();

                if (!string.IsNullOrEmpty(name))
                    query = query.Where(u => u.Name.ToLower().Contains(name.ToLower()));
                
                if (!string.IsNullOrEmpty(id))
                    query = query.Where(u => u.UserId.Contains(id));

                return query.ToList();
            }
        }

        public static (int totalBooks, int activeMembers, int borrowedBooks) GetLibraryStats()
        {
            using (var db = new LibraryContext())
            {
                int total = db.Books.Count();
                int members = db.Users.Count(u => u.Role == "Student" && u.IsApproved);
                int borrowed = db.BookCopies.Count(c => c.Status == "Borrowed");
                return (total, members, borrowed);
            }
        }

        public static Dictionary<string, int> GetMonthlyBorrowingStats()
        {
            using (var db = new LibraryContext())
            {
                var stats = new Dictionary<string, int>();
                var sixMonthsAgo = DateTime.Now.AddMonths(-5);
                sixMonthsAgo = new DateTime(sixMonthsAgo.Year, sixMonthsAgo.Month, 1);

                var transactions = db.Transactions
                    .Where(t => t.BorrowDate >= sixMonthsAgo)
                    .ToList();

                for (int i = 0; i < 6; i++)
                {
                    var date = sixMonthsAgo.AddMonths(i);
                    string monthName = date.ToString("MMM");
                    int count = transactions.Count(t => t.BorrowDate.Year == date.Year && t.BorrowDate.Month == date.Month);
                    stats.Add(monthName, count);
                }
                return stats;
            }
        }

        // --- RESERVATION ---
        public static bool ReserveBook(string userId, string isbn)
        {
            using (var db = new LibraryContext())
            {
                // Check if student exists and is approved
                var user = db.Users.FirstOrDefault(u => u.UserId == userId);
                if (user == null) throw new Exception("Member ID not found.");
                if (!user.IsApproved) throw new Exception("Student registration is not yet approved.");

                // Check if student has reached max limit of combined active borrows + pending reservations
                int activeCount = db.Transactions.Count(t => t.UserId == userId && t.Status == "Active");
                int reservedCount = db.Reservations.Count(r => r.UserId == userId && (r.Status == "Pending" || r.Status == "Ready"));
                if (activeCount + reservedCount >= MaxBorrowLimit)
                {
                    throw new Exception($"Borrow limit reached! You can only have {MaxBorrowLimit} active books/reservations.");
                }

                // Check if already reserved this book
                if (db.Reservations.Any(r => r.UserId == userId && r.BookCopy.ISBN == isbn && (r.Status == "Pending" || r.Status == "Ready")))
                {
                    throw new Exception("You have already reserved this book.");
                }
                
                // Check if already borrowed this book
                if (db.Transactions.Any(t => t.UserId == userId && t.CopyId.StartsWith(isbn) && t.Status == "Active"))
                {
                     throw new Exception("You currently have this book borrowed.");
                }

                // Find available copy first
                var availableCopy = db.BookCopies.FirstOrDefault(c => c.ISBN == isbn && c.Status == "Available");
                
                if (availableCopy != null)
                {
                    // Place immediate reservation
                    availableCopy.Status = "Reserved";
                    var reservation = new Reservation
                    {
                        UserId = userId,
                        CopyId = availableCopy.CopyId,
                        ReservationDate = DateTime.Now,
                        ExpiryDate = DateTime.Now.AddDays(2), // 48 hrs to pick up
                        Status = "Ready" 
                    };
                    db.Reservations.Add(reservation);

                    // Send Notification
                    db.Notifications.Add(new Notification {
                        UserId = userId,
                        Message = $"Your reservation for '{availableCopy.CopyId}' is ready to pick up.",
                        Date = DateTime.Now,
                        Type = "Ready"
                    });
                }
                else
                {
                    // No available copies, place in queue for a borrowed copy
                    var borrowedCopy = db.BookCopies.FirstOrDefault(c => c.ISBN == isbn && c.Status == "Borrowed");
                    if (borrowedCopy == null) throw new Exception("No copies of this book exist to reserve.");

                    var reservation = new Reservation
                    {
                        UserId = userId,
                        CopyId = borrowedCopy.CopyId,
                        ReservationDate = DateTime.Now,
                        ExpiryDate = DateTime.Now.AddYears(1), // Will be updated when book is returned
                        Status = "Pending" 
                    };
                    db.Reservations.Add(reservation);

                    db.Notifications.Add(new Notification {
                        UserId = userId,
                        Message = $"You have been placed in the queue for '{isbn}'. We'll notify you when it's returned.",
                        Date = DateTime.Now,
                        Type = "Pending"
                    });
                }

                db.SaveChanges();
                return true;
            }
        }

        // --- CIRCULATION ---
        public static void IssueBook(string userId, string copyId, int borrowDays)
        {
            using (var db = new LibraryContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserId == userId);
                if (user == null) throw new Exception("User not found.");

                int activeCount = db.Transactions.Count(t => t.UserId == userId && t.Status == "Active");
                if (activeCount >= MaxBorrowLimit)
                    throw new Exception("Maximum borrow limit reached for this user.");

                var copy = db.BookCopies.FirstOrDefault(c => c.CopyId == copyId);
                if (copy == null) throw new Exception("Copy not found.");

                // If reserved by this user, mark reservation as Completed
                var reservation = db.Reservations.FirstOrDefault(r => r.CopyId == copyId && r.Status == "Ready");
                if (reservation != null)
                {
                    if (reservation.UserId != userId) throw new Exception("This copy is reserved by someone else.");
                    reservation.Status = "Completed";
                }
                else if (copy.Status != "Available")
                {
                    throw new Exception("This copy is not available.");
                }

                copy.Status = "Borrowed";

                var transaction = new Transaction
                {
                    UserId = userId,
                    CopyId = copyId,
                    BorrowDate = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(borrowDays),
                    Status = "Active"
                };

                db.Transactions.Add(transaction);

                // --- Task 2: Notification Management ---
                // 1. Delete existing reservation notifications for this user/copy
                var oldNotifications = db.Notifications.Where(n => n.UserId == userId && n.Message.Contains(copyId)).ToList();
                db.Notifications.RemoveRange(oldNotifications);

                // 2. Add new borrow notification
                db.Notifications.Add(new Notification
                {
                    UserId = userId,
                    Message = $"You borrowed '{copyId}'. Due date: {transaction.DueDate.ToShortDateString()}.",
                    Date = DateTime.Now,
                    Type = "Reminder"
                });

                db.SaveChanges();
            }
        }

        public static decimal CalculateFine(DateTime dueDate, DateTime? returnDate = null)
        {
            DateTime effectiveReturnDate = returnDate ?? DateTime.Now;
            int lateDays = (effectiveReturnDate.Date - dueDate.Date).Days;
            return lateDays > 0 ? lateDays * FineRatePerDay : 0m;
        }

        public static List<Transaction> GetActiveBorrows(string userId = null)
        {
            using (var db = new LibraryContext())
            {
                var query = db.Transactions.Include(t => t.BookCopy).ThenInclude(c => c.Book)
                                          .Include(t => t.User)
                                          .Where(t => t.Status == "Active");
                
                if (!string.IsNullOrEmpty(userId))
                    query = query.Where(t => t.UserId == userId);

                return query.ToList();
            }
        }

        public static decimal ReturnBook(string copyId)
        {
            using (var db = new LibraryContext())
            {
                var transaction = db.Transactions.FirstOrDefault(t => t.CopyId == copyId && t.Status == "Active");
                if (transaction == null) throw new Exception("Active transaction not found for this copy.");

                var copy = db.BookCopies.FirstOrDefault(c => c.CopyId == copyId);
                if (copy != null)
                {
                    // Check for pending reservations
                    var pendingRes = db.Reservations.FirstOrDefault(r => r.CopyId == copyId && r.Status == "Pending");
                    if (pendingRes != null)
                    {
                        copy.Status = "Reserved";
                        pendingRes.Status = "Ready";
                        pendingRes.ExpiryDate = DateTime.Now.AddDays(1);
                        
                        // Notify reserver
                        db.Notifications.Add(new Notification {
                            UserId = pendingRes.UserId,
                            Message = $"The book you reserved ({copyId}) has been returned! You have 24 hours to collect it.",
                            Date = DateTime.Now,
                            Type = "Ready"
                        });
                    }
                    else
                    {
                        copy.Status = "Available";
                    }
                }

                transaction.Status = "Returned";
                transaction.ReturnDate = DateTime.Now;

                decimal fine = CalculateFine(transaction.DueDate, transaction.ReturnDate);
                transaction.FineAmount = fine;

                db.SaveChanges();
                return fine;
            }
        }

        // --- HISTORY ---
        public static List<Transaction> GetUserHistory(string userId)
        {
            using (var db = new LibraryContext())
            {
                return db.Transactions.Include(t => t.BookCopy).ThenInclude(c => c.Book)
                          .Where(t => t.UserId == userId)
                          .OrderByDescending(t => t.BorrowDate)
                          .ToList();
            }
        }
        public static List<Reservation> GetUserReservations(string userId)
        {
            using (var db = new LibraryContext())
            {
                return db.Reservations
                          .Include(r => r.BookCopy)
                          .ThenInclude(c => c.Book)
                          .Where(r => r.UserId == userId && (r.Status == "Active" || r.Status == "Ready" || r.Status == "Pending"))
                          .ToList();
            }
        }

        public static void SettleFine(int transactionId)
        {
            using (var db = new LibraryContext())
            {
                var transaction = db.Transactions.FirstOrDefault(t => t.Id == transactionId);
                if (transaction == null) throw new Exception("Transaction not found.");
                
                transaction.IsFinePaid = true;
                db.SaveChanges();
            }
        }

        public static void CleanupExpiredReservations()
        {
            using (var db = new LibraryContext())
            {
                var expired = db.Reservations.Include(r => r.BookCopy)
                                .Where(r => r.Status == "Ready" && r.ExpiryDate < DateTime.Now)
                                .ToList();

                foreach (var res in expired)
                {
                    res.Status = "Expired";
                    if (res.BookCopy != null && res.BookCopy.Status == "Reserved")
                    {
                        res.BookCopy.Status = "Available";
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
