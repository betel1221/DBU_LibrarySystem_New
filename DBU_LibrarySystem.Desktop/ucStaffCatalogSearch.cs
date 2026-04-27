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
    }
}
