using System;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;
using System.Linq;

namespace DBU_LibrarySystem
{
    public partial class ucStaffCirculation : UserControl
    {
        public ucStaffCirculation()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            LoadActiveLoans();
        }

        private void LoadActiveLoans()
        {
            dataGridView1.Rows.Clear();
            var loans = Services.LibraryManager.GetActiveBorrows();
            foreach (var l in loans)
            {
                int daysLeft = (l.DueDate.Date - DateTime.Now.Date).Days;
                string status = daysLeft >= 0 ? $"{daysLeft} days left" : $"{Math.Abs(daysLeft)} days OVERDUE";
                dataGridView1.Rows.Add(l.User.Name, l.BookCopy.Book.Title, l.DueDate.ToShortDateString(), status);
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = txtBMember.Text.Trim();
                string copyId = txtBBook.Text.Trim();

                if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(copyId))
                {
                    MessageBox.Show("Please enter both Member ID and Copy ID.");
                    return;
                }

                Services.LibraryManager.IssueBook(userId, copyId, 14); // Default 14 days
                MessageBox.Show($"Book {copyId} issued successfully to {userId}!");
                
                txtBMember.Clear();
                txtBBook.Clear();
                LoadActiveLoans();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Borrow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                string copyId = txtRBook.Text.Trim();
                if (string.IsNullOrEmpty(copyId))
                {
                    MessageBox.Show("Please enter the Copy ID to return.");
                    return;
                }

                decimal fine = Services.LibraryManager.ReturnBook(copyId);
                if (fine > 0)
                {
                    MessageBox.Show($"Book returned. A fine of ${fine:N2} was calculated for late return.", "Return Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book returned successfully! No fines.", "Return Processed");
                }

                txtRBook.Clear();
                LoadActiveLoans();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Return Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
