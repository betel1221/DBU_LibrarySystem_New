# DBU University Library System

A modern, three-tier library management application built with .NET 10 effectively managing books, users, and borrowing transactions.

## 🏗️ Architecture
The system is divided into three distinct layers:
1.  **DataLayer**: Entity Framework Core with SQL Server. Contains database models, context, and migrations.
2.  **API/Service Layer**: Backend logic and centralized service layer (LibraryManager) for business rules.
3.  **Desktop**: Windows Forms application with a premium "Deep Space" dark theme and interactive transitions.

## 🚀 Getting Started
1.  **Database**: Ensure SQL Server is running. The system uses a local instance (`Server=(local)`).
2.  **Restore**: Run `dotnet restore` in the root folder.
3.  **Build**: Open `DBU_LibrarySystem.slnx` in Visual Studio or run `dotnet build`.

## 🔐 Login Credentials (Default)

Use the following credentials to access the different system modules:

| Role | Username (User ID) | Password | Access Level |
| :--- | :--- | :--- | :--- |
| **System Admin** | `admin` | `admin` | Full Control (Users, Books, Fines) |
| **Librarian** | `lib` | `lib` | Book Management & Circulation |
| **Student** | `std1` | `student` | Search, Reservations, My History |

## ✨ Key Features
- **Real-Time Reporting**: Live dashboard with book and member statistics.
- **Advanced Search**: Filter books by Title, Author, Category, ISBN, and Year.
- **Fines Management**: Automated fine calculation and overdue tracking for members.
- **Book Reservations**: Remote booking system for students.
- **Premium UI**: Modern dark theme with smooth micro-animations.

---
*Developed for DBU Library Management.*
