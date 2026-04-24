using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucReports : UserControl
    {
        public ucReports()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            LoadStats();
        }

        private void LoadStats()
        {
            try
            {
                var (total, members, borrowed) = DBU_LibrarySystem.Services.LibraryManager.GetLibraryStats();
                lblTBooksNum.Text = total.ToString("N0");
                lblAMembersNum.Text = members.ToString("N0");
                lblBBorrowedNum.Text = borrowed.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStats();
        }
    }
}
