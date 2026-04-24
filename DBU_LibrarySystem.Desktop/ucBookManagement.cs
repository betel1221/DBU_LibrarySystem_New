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
                dataGridView1.Rows.Add(b.ISBN, b.Title, b.Author, b.Category, "", b.Copies?.Count ?? 0);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = txtISBN.Text.Trim();
                string title = txtTitle.Text.Trim();
                string author = txtAuthor.Text.Trim();
                int qty;

                if (string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }

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
                    Category = "General" // Default for now
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
                txtQty.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRealData();
        }
    }
}
