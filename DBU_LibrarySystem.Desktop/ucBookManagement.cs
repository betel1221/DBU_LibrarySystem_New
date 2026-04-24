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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRealData();
        }
    }
}
