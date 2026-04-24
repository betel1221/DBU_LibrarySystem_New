using System.Windows.Forms;
using DBU_LibrarySystem.Services;
using DBU_LibrarySystem.Utilities;
using System.Linq;
namespace DBU_LibrarySystem
{
    public partial class ucBookManagement : UserControl
    {
        public ucBookManagement()
        {
            InitializeComponent();
            LoadRealData();
            ThemeHelper.ApplyTheme(this);
        }

        private void LoadRealData()
        {
            dataGridView1.Rows.Clear();
            var books = LibraryManager.SearchBooks("");
            foreach (var b in books)
            {
                dataGridView1.Rows.Add(b.ISBN, b.Title, b.Author, b.Category, b.YearOfPublication, b.Copies?.Count ?? 0);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = txtISBN.Text.Trim();
                string title = txtTitle.Text.Trim();
                string author = txtAuthor.Text.Trim();
                string category = txtCategory.Text.Trim();
                int year, qty;

                if (string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }

                if (!int.TryParse(txtYear.Text.Trim(), out year)) year = DateTime.Now.Year;

                if (!int.TryParse(txtQty.Text.Trim(), out qty) || qty <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                var book = new DBU_LibrarySystem.Models.Book
                {
                    ISBN = isbn,
                    Title = title,
                    Author = author,
                    Category = string.IsNullOrEmpty(category) ? "General" : category,
                    YearOfPublication = year
                };

                LibraryManager.AddBook(book);

                // Add copies
                for (int i = 1; i <= qty; i++)
                {
                    LibraryManager.AddBookCopy(isbn, $"{isbn}-C{i}-{DateTime.Now.Ticks % 1000}");
                }

                MessageBox.Show("Book and copies added successfully!");
                LoadRealData();
                
                // Clear fields
                txtISBN.Clear();
                txtTitle.Clear();
                txtAuthor.Clear();
                txtCategory.Clear();
                txtYear.Clear();
                txtQty.Clear();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (ex.InnerException != null) msg += "\nInner: " + ex.InnerException.Message;
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtISBN.Text = row.Cells[0].Value.ToString();
                txtTitle.Text = row.Cells[1].Value.ToString();
                txtAuthor.Text = row.Cells[2].Value.ToString();
                txtCategory.Text = row.Cells[3].Value.ToString();
                txtYear.Text = row.Cells[4].Value.ToString();
                txtQty.Text = row.Cells[5].Value.ToString();
                
                txtISBN.ReadOnly = true; // Don't allow ISBN change on update
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var book = new DBU_LibrarySystem.Models.Book
                {
                    ISBN = txtISBN.Text.Trim(),
                    Title = txtTitle.Text.Trim(),
                    Author = txtAuthor.Text.Trim(),
                    Category = txtCategory.Text.Trim(),
                    YearOfPublication = int.Parse(txtYear.Text)
                };

                LibraryManager.UpdateBook(book);
                MessageBox.Show("Book updated successfully!");
                LoadRealData();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = txtISBN.Text.Trim();
                if (string.IsNullOrEmpty(isbn)) return;

                var res = MessageBox.Show($"Are you sure you want to delete book {isbn} and all its copies?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    LibraryManager.DeleteBook(isbn);
                    MessageBox.Show("Book deleted.");
                    LoadRealData();
                    ClearFields();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtCategory.Clear();
            txtYear.Clear();
            txtQty.Clear();
            txtISBN.ReadOnly = false;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRealData();
        }
    }
}
