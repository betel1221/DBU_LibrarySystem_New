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

        public void LoadUserHistory(string userId)
        {
            dataGridView1.Rows.Clear();
            var history = DBU_LibrarySystem.Services.LibraryManager.GetUserHistory(userId);
            foreach (var t in history)
            {
                string status = t.Status;
                if (status == "Active" && DateTime.Now > t.DueDate)
                    status = "⚠️ OVERDUE";
                
                string fine = t.FineAmount > 0 ? $"{t.FineAmount:C}" : "✅ None";
                
                dataGridView1.Rows.Add(t.BookCopy.Book.Title, t.BorrowDate.ToShortDateString(), t.ReturnDate?.ToShortDateString() ?? "Not Returned", fine);
            }
        }
    }
}
