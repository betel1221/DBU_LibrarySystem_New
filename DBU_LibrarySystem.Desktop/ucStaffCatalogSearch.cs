using System;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;
using System.Linq;

namespace DBU_LibrarySystem
{
    public partial class ucStaffCatalogSearch : UserControl
    {
        public ucStaffCatalogSearch()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            
            // Interaction: Ensure the grid expands properly
            this.Load += (s, e) => {
                dataGridView1.Width = this.Width - 70;
            };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            string filter = cmbFilter.SelectedItem?.ToString();

            System.Collections.Generic.List<DBU_LibrarySystem.Models.Book> results;

            if (filter == "By Author")
                results = DBU_LibrarySystem.Services.LibraryManager.SearchBooks(author: query);
            else if (filter == "By ISBN")
                results = DBU_LibrarySystem.Services.LibraryManager.SearchBooks(isbn: query);
            else if (filter == "By Category")
                results = DBU_LibrarySystem.Services.LibraryManager.SearchBooks(category: query);
            else if (filter == "By Year")
            {
                int.TryParse(query, out int year);
                results = DBU_LibrarySystem.Services.LibraryManager.SearchBooks(year: year > 0 ? year : (int?)null);
            }
            else // By Title
                results = DBU_LibrarySystem.Services.LibraryManager.SearchBooks(title: query);

            dataGridView1.Rows.Clear();
            foreach (var b in results)
            {
                int total = b.Copies.Count;
                int available = b.Copies.Count(c => c.Status == "Available");
                string availStatus = (available > 0) ? $"✅ {available} / {total} Available" : "❌ Out of Stock";

                dataGridView1.Rows.Add(b.ISBN, b.Title, b.Author, b.Category, availStatus);
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            string isbn = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            // Find an available copy to issue
            var book = DBU_LibrarySystem.Services.LibraryManager.SearchBooks(isbn: isbn).FirstOrDefault();
            var copy = book?.Copies?.FirstOrDefault(c => c.Status == "Available");

            if (copy == null)
            {
                MessageBox.Show("No available copies to issue for this book.");
                return;
            }

            // Navigate to Circulation screen
            Form parent = this.FindForm();
            if (parent is StaffDashboard staffDash)
            {
                staffDash.NavigateToModule("Circulation", copy.CopyId);
            }
            else if (parent is MainDashboard adminDash)
            {
                adminDash.NavigateToModule("Borrow", copy.CopyId);
            }
        }
    }
}
