# DBU University Library System

A modern, three-tier library management application built with .NET 10 effectively managing books, users, and borrowing transactions.

## 🏗️ Architecture
The system is divided into three distinct layers:
1.  **DataLayer**: Entity Framework Core with SQL Server. Contains database models, context, and migrations.
2.  **API**: Backend logic and service layer (planned for future web scalability).
3.  **Desktop**: Windows Forms application with a premium "Deep Space" dark theme and interactive transitions.

## 🚀 Getting Started
1.  **Database**: Ensure SQL Server is running. The system uses a local instance (`Server=(local)`).
2.  **Restore**: Run `dotnet restore` in the root folder.
3.  **Build**: Open `DBU_LibrarySystem.slnx` in Visual Studio or run `dotnet build`.

## 🔐 Login Credentials (Seed Data)

Use the following credentials to explore the different system perspectives:

| Role | Username (User ID) | Password |
| :--- | :--- | :--- |
| **System Admin** | `admin` | `admin` |
| **Librarian** | `lib` | `lib` |
| **Student** | `std1` | `student` |

## ✨ Premium UI Features
- **Modern Theme**: High-contrast dark mode with neon accents.
- **Animations**: Smooth slide-in user controls and hover transitions.
- **Unified Sidebar**: Global navigation consistent across all roles.

---
*Created by Antigravity AI Assistant.*
