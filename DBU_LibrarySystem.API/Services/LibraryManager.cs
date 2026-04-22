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
        public static List<Book> SearchBooks(string query)
        {
            using (var db = new LibraryContext())
            {
                query = query.ToLower();
                return db.Books
                         .Include(b => b.Copies)
                         .Where(b => b.Title.ToLower().Contains(query) || 
                                     b.Author.ToLower().Contains(query) || 
                                     b.Category.ToLower().Contains(query) || 
                                     b.ISBN.Contains(query))
                         .ToList();
            }
        }

        // --- RESERVATION ---
        public static void ReserveBook(string userId, string isbn)
        {
            using (var db = new LibraryContext())
            {
                // Check if student has reached max limit of combined active borrows + pending reservations
                int activeCount = db.Transactions.Count(t => t.UserId == userId && t.Status == "Active");
                int reservedCount = db.Reservations.Count(r => r.UserId == userId && r.Status == "Pending");
                if (activeCount + reservedCount >= MaxBorrowLimit)
                {
                    throw new Exception("Borrow limit reached! Cannot reserve more books.");
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
                    Status = "Ready" // Or Pending if they just reserve a title, but we reserved a specific copy
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

                decimal fine = 0m;
                int lateDays = (DateTime.Now.Date - transaction.DueDate.Date).Days;
                if (lateDays > 0)
                {
                    fine = lateDays * FineRatePerDay;
                    transaction.FineAmount = fine;
                }

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
    }
}
