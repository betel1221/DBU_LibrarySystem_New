using System;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucStaffReports : UserControl
    {
        public ucStaffReports()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
        }

        private void btnTotalInventory_Click(object sender, EventArgs e)
        {
            lblStatValue.Text = "TOTAL BOOKS: 13";
        }

        private void btnBooksOnLoan_Click(object sender, EventArgs e)
        {
            lblStatValue.Text = "ISSUED BOOKS: 11";
        }
    }
}
