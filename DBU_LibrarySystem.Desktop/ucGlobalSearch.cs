using System;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucGlobalSearch : UserControl
    {
        public ucGlobalSearch()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
        }

        private void cmbSearchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFilter.Items.Clear();
            if (cmbSearchMode.SelectedItem?.ToString() == "Members")
            {
                cmbFilter.Items.AddRange(new object[] { "By Name", "By Member ID" });
                btnReserve.Visible = false;
            }
            else
            {
                cmbFilter.Items.AddRange(new object[] { "By Title", "By Author", "By ISBN", "By Category", "By Year" });
                btnReserve.Visible = true;
            }
            cmbFilter.SelectedIndex = 0;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || cmbSearchMode.SelectedItem?.ToString() != "Books") return;
            string isbn = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            string studentId = Microsoft.VisualBasic.Interaction.InputBox("Enter Member ID to reserve for:", "Global Reservation", "");
            if (string.IsNullOrEmpty(studentId)) return;

            try
            {
                if (Services.LibraryManager.ReserveBook(studentId, isbn))
                {
                    MessageBox.Show("Book reserved successfully!");
                    btnSearch_Click(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string query = txtSearch.Text.Trim();
            string mode = cmbSearchMode.SelectedItem?.ToString();
            string filter = cmbFilter.SelectedItem?.ToString();

            if (mode == "Members")
            {
                var members = (filter == "By Name") 
                    ? Services.LibraryManager.SearchMembers(name: query)
                    : Services.LibraryManager.SearchMembers(id: query);

                foreach (var m in members)
                {
                    dataGridView1.Rows.Add("Member", m.UserId, m.Name, m.IsApproved ? "Approved" : "Pending");
                }
            }
            else
            {
                System.Collections.Generic.List<Models.Book> books;
                if (filter == "By Author") books = Services.LibraryManager.SearchBooks(author: query);
                else if (filter == "By ISBN") books = Services.LibraryManager.SearchBooks(isbn: query);
                else if (filter == "By Category") books = Services.LibraryManager.SearchBooks(category: query);
                else if (filter == "By Year")
                {
                    int.TryParse(query, out int year);
                    books = Services.LibraryManager.SearchBooks(year: year > 0 ? year : (int?)null);
                }
                else books = Services.LibraryManager.SearchBooks(title: query);

                foreach (var b in books)
                {
                    int availableCount = b.Copies?.Count(c => c.Status == "Available") ?? 0;
                    dataGridView1.Rows.Add("Book", b.ISBN, $"{b.Title} ({b.Category})", availableCount > 0 ? "Available" : "Stock Out");
                }
            }
        }
    }
}
