using System;
using System.Linq;
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
            this.Load += ucGlobalSearch_Load;
            cmbSearchMode.SelectedIndex = 0; // Trigger initial column setup
        }

        private void ucGlobalSearch_Load(object sender, EventArgs e)
        {
            panelSearch.BringToFront();
            SetupColumns();
        }

        private void SetupColumns()
        {
            dataGridView1.Columns.Clear();
            string mode = cmbSearchMode.SelectedItem?.ToString();
            bool isAdmin = this.FindForm() is MainDashboard;

            if (mode == "Members")
            {
                dataGridView1.Columns.Add("colID", "Member ID");
                dataGridView1.Columns.Add("colName", "Full Name");
                dataGridView1.Columns.Add("colDept", "Department/Role");
                dataGridView1.Columns.Add("colStatus", "Status");
                btnIssue.Visible = false;
            }
            else
            {
                dataGridView1.Columns.Add("colISBN", "ISBN");
                dataGridView1.Columns.Add("colTitle", "Title");
                dataGridView1.Columns.Add("colAuthor", "Author");
                // ENSURE VISIBILITY:
                var availCol = new DataGridViewTextBoxColumn();
                availCol.Name = "colAvail";
                availCol.HeaderText = "Availability";
                availCol.Visible = true; 
                dataGridView1.Columns.Add(availCol);

                btnIssue.Visible = !isAdmin;
                btnIssue.Text = "Issue Book";
            }
        }

        private void cmbSearchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFilter.Items.Clear();
            if (cmbSearchMode.SelectedItem?.ToString() == "Members")
            {
                cmbFilter.Items.AddRange(new object[] { "By Name", "By Member ID" });
            }
            else
            {
                cmbFilter.Items.AddRange(new object[] { "By Title", "By Author", "By ISBN", "By Category", "By Year" });
            }
            cmbFilter.SelectedIndex = 0;
            SetupColumns();
            dataGridView1.Rows.Clear();
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
                    dataGridView1.Rows.Add(m.UserId, m.Name, m.Department ?? m.Role, m.IsApproved ? "✅ Approved" : "⏳ Pending");
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
                    string availStatus = availableCount > 0 ? $"✅ {availableCount} Available" : "❌ Out of Stock";
                    
                    // Column index 3 is our availability column
                    dataGridView1.Rows.Add(b.ISBN, b.Title, b.Author, availStatus);
                }
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || cmbSearchMode.SelectedItem?.ToString() != "Books") return;
            
            string isbn = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var book = Services.LibraryManager.SearchBooks(isbn: isbn).FirstOrDefault();
            var copy = book?.Copies?.FirstOrDefault(c => c.Status == "Available");
            
            if (copy == null)
            {
                MessageBox.Show("No available copies to issue for this book.", "Library System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form parent = this.FindForm();
            if (parent is MainDashboard adminDash)
            {
                adminDash.NavigateToModule("Borrow", copy.CopyId);
            }
            else if (parent is StaffDashboard staffDash)
            {
                staffDash.NavigateToModule("Circulation", copy.CopyId);
            }
        }
    }
}