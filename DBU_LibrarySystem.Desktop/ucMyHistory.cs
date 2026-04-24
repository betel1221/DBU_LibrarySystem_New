using System;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucMyHistory : UserControl
    {
        public ucMyHistory()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            // Default to empty, should be loaded from Main Form
        }

        private string _currentUserId;
        public void LoadUserHistory(string userId)
        {
            _currentUserId = userId;
            dataGridView1.Rows.Clear();
            
            // 1. Load Borrows
            var history = DBU_LibrarySystem.Services.LibraryManager.GetUserHistory(userId);
            foreach (var t in history)
            {
                decimal currentFine = t.Status == "Active" 
                    ? DBU_LibrarySystem.Services.LibraryManager.CalculateFine(t.DueDate) 
                    : t.FineAmount;

                string statusText = t.Status;
                if (t.Status == "Active")
                {
                    int daysLeft = (t.DueDate.Date - DateTime.Now.Date).Days;
                    if (daysLeft > 0) statusText = $"⌛ {daysLeft} Days Left";
                    else if (daysLeft == 0) statusText = "🚩 DUE TODAY";
                    else statusText = $"⚠️ {Math.Abs(daysLeft)} DAYS OVERDUE";
                }

                dataGridView1.Rows.Add(t.BookCopy.Book.Title, t.BorrowDate.ToShortDateString(), t.DueDate.ToShortDateString(), t.ReturnDate?.ToShortDateString() ?? "-", currentFine > 0 ? currentFine.ToString("N2") : "0.00", statusText);
            }

            // 2. Load Reservations
            var reservations = DBU_LibrarySystem.Services.LibraryManager.GetUserReservations(userId);
            foreach (var r in reservations)
            {
                dataGridView1.Rows.Add(
                    r.BookCopy.Book.Title,
                    r.ReservationDate.ToShortDateString(),
                    "-",
                    "-",
                    "0.00",
                    "⭐ RESERVED"
                );
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_currentUserId))
                LoadUserHistory(_currentUserId);
        }
    }
}
