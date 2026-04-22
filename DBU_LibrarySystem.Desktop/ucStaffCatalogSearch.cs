using System;
using System.Windows.Forms;

namespace DBU_LibrarySystem
{
    public partial class ucStaffCatalogSearch : UserControl
    {
        public ucStaffCatalogSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Future database search binding
            MessageBox.Show("Search query executed for: " + txtSearch.Text);
        }
    }
}
