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
        public const decimal FineRatePerDay = 5.0m;
        public const int MaxBorrowLimit = 3;

        // --- BOOK MANAGEMENT ---
        public static void AddBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                if (db.Books.Any(b => b.ISBN == book.ISBN))
                    throw new Exception("Book with this ISBN already exists.");
                db.Books.Add(book);
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

                // Find available copy
                var availableCopy = db.BookCopies.FirstOrDefault(c => c.ISBN == isbn && c.Status == "Available");
                if (availableCopy == null) throw new Exception("No copies are currently available for reservation.");

                // Place reservation
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
                    copy.Status = "Available";
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
                          .Where(r => r.UserId == userId && r.Status == "Active")
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
    }
}
