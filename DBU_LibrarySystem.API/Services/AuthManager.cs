using System;
using System.Linq;
using DBU_LibrarySystem.Models;
using DBU_LibrarySystem.Data;

namespace DBU_LibrarySystem.Services
{
    public static class AuthManager
    {
        public static User CurrentUser { get; private set; }

        public static bool Login(string userId, string password)
        {
            using (var db = new LibraryContext())
            {
                // Ensure default users exist if database is fresh
                if (!db.Users.Any())
                {
                    db.Users.Add(new User { UserId = "admin", Name = "System Admin", Role = "Admin", Password = "admin", IsApproved = true });
                    db.Users.Add(new User { UserId = "lib", Name = "Main Librarian", Role = "Librarian", Password = "lib", IsApproved = true });
                    db.Users.Add(new User { UserId = "std1", Name = "Alice Student", Role = "Student", Password = "student", IsApproved = true });
                    db.Users.Add(new User { UserId = "std2", Name = "Bob Smith", Role = "Student", Password = "password123", IsApproved = true });
                    db.Users.Add(new User { UserId = "std3", Name = "Charlie Davis", Role = "Student", Password = "password123", IsApproved = false });
                    db.Users.Add(new User { UserId = "staff1", Name = "John Staff", Role = "Librarian", Password = "staff", IsApproved = true });
                    db.SaveChanges();
                }

                var user = db.Users.FirstOrDefault(u => u.UserId.ToLower() == userId.ToLower() && u.Password == password);
                if (user != null)
                {
                    if (user.Role == "Student" && !user.IsApproved)
                    {
                        throw new Exception("Your account is pending Admin approval.");
                    }
                    CurrentUser = user;
                    return true;
                }
                return false;
            }
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

        public static void RegisterStudent(string userId, string name, string password, string contactNumber, string idCardPath)
        {
            using (var db = new LibraryContext())
            {
                if (db.Users.Any(u => u.UserId == userId))
                {
                    throw new Exception("Student ID already exists.");
                }

                var student = new User
                {
                    UserId = userId,
                    Name = name,
                    Role = "Student",
                    Password = password,
                    ContactNumber = contactNumber,
                    IDCardImagePath = idCardPath,
                    IsApproved = false // Requires Admin approval
                };

                db.Users.Add(student);
                db.SaveChanges();
            }
        }

        public static void ApproveStudent(string userId)
        {
            using (var db = new LibraryContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserId == userId);
                if (user != null && user.Role == "Student")
                {
                    user.IsApproved = true;
                    db.SaveChanges();
                }
            }
        }
    }
}
