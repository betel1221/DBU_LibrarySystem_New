using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucBorrowReturn : UserControl
    {
        public ucBorrowReturn()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            btnIssue.Click += btnIssue_Click;
            btnReturn.Click += btnReturn_Click;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = txtIssueMember.Text.Trim();
                string copyId = txtIssueBook.Text.Trim();

                if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(copyId))
                {
                    MessageBox.Show("User ID and Copy ID are required.");
                    return;
                }

                DBU_LibrarySystem.Services.LibraryManager.IssueBook(userId, copyId, 7); // Default 7 days
                MessageBox.Show($"Book {copyId} issued to {userId} successfully!");
                txtIssueMember.Clear();
                txtIssueBook.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Issue Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                string copyId = txtReturnBook.Text.Trim();
                if (string.IsNullOrEmpty(copyId)) return;

                decimal fine = DBU_LibrarySystem.Services.LibraryManager.ReturnBook(copyId);
                
                if (fine > 0)
                {
                    MessageBox.Show($"Book returned successfully!\n\n⚠️ LATE RETURN FINE: {fine:C}", "Return with Fine", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Book returned successfully! No fines applied.", "Return Success");
                }
                txtReturnBook.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Return Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
