using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DBU_LibrarySystem.Services;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucBookManagement : UserControl
    {
        private List<DBU_LibrarySystem.Models.Book> _allBooks = new List<DBU_LibrarySystem.Models.Book>();

        public ucBookManagement()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            SetupGridAtRuntime(); // FORCE REBUILD
            LoadRealData();
        }

        private void SetupGridAtRuntime()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // 1. ISBN
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ISBN", DataPropertyName = "ISBN" });
            // 2. Title
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Title", DataPropertyName = "Title" });
            // 3. Author
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Author", DataPropertyName = "Author" });
            // 4. Category
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Category", DataPropertyName = "Category" });
            // 5. Year
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Year", DataPropertyName = "Year" });
            // 6. Qty
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Qty" });
            
            // 7. Edit Button
            var editBtn = new DataGridViewButtonColumn
            {
                HeaderText = "✏️",
                Text = "✏️",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat
            };
            dataGridView1.Columns.Add(editBtn);

            // 8. Delete Button
            var delBtn = new DataGridViewButtonColumn
            {
                HeaderText = "🗑️",
                Text = "🗑️",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat
            };
            dataGridView1.Columns.Add(delBtn);

            // Style Headers
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 127, 184);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void LoadRealData()
        {
            try
            {
                _allBooks = LibraryManager.SearchBooks();
                DisplayBooks(_allBooks);
            }
            catch (Exception ex) { MessageBox.Show("Error loading data: " + ex.Message); }
        }

        private void DisplayBooks(List<DBU_LibrarySystem.Models.Book> books)
        {
            dataGridView1.Rows.Clear();
            foreach (var b in books)
            {
                dataGridView1.Rows.Add(b.ISBN, b.Title, b.Author, b.Category, b.YearOfPublication, b.Copies.Count);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string q = txtSearch.Text.ToLower();
            var filtered = _allBooks.Where(b => b.Title.ToLower().Contains(q) || b.ISBN.Contains(q)).ToList();
            DisplayBooks(filtered);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var book = new DBU_LibrarySystem.Models.Book
                {
                    ISBN = txtISBN.Text.Trim(),
                    Title = txtTitle.Text.Trim(),
                    Author = txtAuthor.Text.Trim(),
                    Category = cmbCategory.SelectedItem?.ToString() ?? "Other",
                    YearOfPublication = int.Parse(txtYear.Text)
                };

                LibraryManager.AddOrUpdateBook(book);

                if (txtISBN.ReadOnly == false && int.TryParse(txtQty.Text, out int qty))
                {
                    for (int i = 1; i <= qty; i++)
                    {
                        LibraryManager.AddBookCopy(book.ISBN, $"{book.ISBN}-C{i}");
                    }
                }

                MessageBox.Show("Book saved successfully!");
                LoadRealData();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string isbn = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string title = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            // Check if column 6 (Edit) or 7 (Delete) was clicked
            if (e.ColumnIndex == 6) // Edit
            {
                txtISBN.Text = isbn;
                txtTitle.Text = title;
                txtAuthor.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbCategory.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtYear.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtQty.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                txtISBN.ReadOnly = true;
                btnAdd.Text = "Save Changes";
                panelCreate.Focus();
            }
            else if (e.ColumnIndex == 7) // Delete
            {
                var res = MessageBox.Show($"Are you sure you want to delete '{title}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    LibraryManager.DeleteBook(isbn);
                    LoadRealData();
                    ClearFields();
                }
            }
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
            cmbCategory.SelectedIndex = 0;
            txtYear.Clear();
            txtQty.Clear();
            txtISBN.ReadOnly = false;
            btnAdd.Text = "Save Book";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRealData();
        }
    }
}
