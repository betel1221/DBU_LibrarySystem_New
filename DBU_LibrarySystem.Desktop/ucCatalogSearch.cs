using System;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucCatalogSearch : UserControl
    {
        public ucCatalogSearch()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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
            
            foreach (var b in results)
            {
                int availableCount = b.Copies?.Count(c => c.Status == "Available") ?? 0;
                string status = availableCount > 0 ? $"✅ {availableCount} Available" : "❌ Out of Stock";
                
                dataGridView1.Rows.Add(b.ISBN, b.Title, b.Author, b.Category, b.YearOfPublication, status);
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            string isbn = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            // Note: In a real app, we'd get this from a Session or Main Form
            string studentId = Microsoft.VisualBasic.Interaction.InputBox("Enter your Member ID to reserve:", "Reservation", "");
            
            if (string.IsNullOrEmpty(studentId)) return;

            try
            {
                if (DBU_LibrarySystem.Services.LibraryManager.ReserveBook(studentId, isbn))
                {
                    MessageBox.Show("Book reserved successfully! Please collect it within 24 hours.");
                    btnSearch_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Reservation failed. All copies might be reserved or you have reached your limit.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
