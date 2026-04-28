# 📚 DBU Library Management System

A robust, modern desktop application designed to streamline library operations for Debre Berhan University (DBU). Built using a scalable **Three-Tier Architecture**, this system provides a highly intuitive and visually premium experience for managing books, members, circulation, and user roles.

---

## 🌟 Key Features

### 1. Modern & Premium User Interface
* **Deep Space Dark Theme:** A carefully curated dark charcoal aesthetic (`#18181A`) paired with vibrant "Electric Blue" (`#2C7FB8`) accents for reduced eye strain and a modern SaaS feel.
* **Dynamic Dashboards:** Unique, tailored dashboards based on the logged-in user's role (Admin, Librarian, or Student) featuring smooth slide-in animations.

### 2. Comprehensive Member Management
* **Role-Based Authentication:** Dedicated access control for Students, Librarians, and System Admins.
* **Live Webcam Integration:** Administrators can seamlessly capture a student's ID Card photo on the spot using a built-in webcam interface (powered by AForge).
* **Flexible Login:** Users can securely log into the portal using either their `User ID` or their `Registered Full Name`.

### 3. Catalog & Inventory Control
* **Book Management:** Effortlessly add, update, search, and delete books from the database.
* **Global Search:** Lightning-fast global search capabilities to locate books by Title, ISBN, or Author instantly.

### 4. Circulation & Operations
* **Borrow & Return:** Track active book loans, automatically manage due dates, and securely return items to the inventory.
* **Notifications & Fines:** (Extendable) Keep track of overdue items and student notification alerts.

---

## 🏗️ Architecture

The application strictly adheres to a **Three-Tier Architecture**, ensuring modularity, easy maintenance, and scalability:

1. **Presentation Layer (Desktop / WinForms)**
   * Built with .NET Windows Forms.
   * Handles all UI rendering, custom painting, theming (`ThemeHelper`), and user interactions.
2. **Business Logic Layer (Services / API)**
   * Manages core application rules (`AuthManager`, `LibraryManager`).
   * Acts as the bridge between the user interface and the database.
3. **Data Access Layer (DataLayer / Entity Framework)**
   * Uses **Entity Framework Core** as the ORM.
   * Manages schema generation and all CRUD operations against the SQL Server database.

---

## 🛠️ Technology Stack

* **Language:** C# 10.0
* **Framework:** .NET 10 (Windows)
* **UI Technology:** Windows Forms (WinForms)
* **Database:** Microsoft SQL Server
* **ORM:** Entity Framework Core
* **Hardware Integration:** AForge.Video & AForge.Video.DirectShow (for WebCam Capture)

---

## 🚀 Getting Started

### Prerequisites
* Visual Studio 2022 (or newer)
* .NET 10.0 SDK
* SQL Server Express (or any SQL Server instance)

### Installation & Setup

1. **Clone/Open the Solution:**
   Open `DBU_LibrarySystem.sln` in Visual Studio.
2. **Restore NuGet Packages:**
   Right-click the solution and select **"Restore NuGet Packages"** to download necessary dependencies (Entity Framework Core, AForge, etc.).
3. **Database Setup:**
   * Open the **Package Manager Console**.
   * Set the Default Project to `DBU_LibrarySystem.DataLayer`.
   * Run the command: `Update-Database`
   * *Note: The system automatically seeds default admin/staff accounts if the database is empty.*
4. **Run the Application:**
   Set `DBU_LibrarySystem.Desktop` as the Startup Project and hit **Start (F5)**.

### Default Login Credentials (Seeded on first run)
* **System Admin:**
  * Username: `admin` (or `System Admin`)
  * Password: `admin`
* **Main Librarian:**
  * Username: `lib` (or `Main Librarian`)
  * Password: `lib`

---

## 🎨 Design Philosophy
This project heavily prioritizes **Aesthetics and UX**. By overriding default WinForm styles, removing generic grays, and enforcing a strict, unified color palette, the DBU Library System breaks away from the "legacy" feel of standard desktop apps and delivers a premium, engaging experience.
