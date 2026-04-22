using System;
using System.Windows.Forms;

namespace DBU_LibrarySystem
{
    public partial class ucGlobalSearch : UserControl
    {
        public ucGlobalSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if(!string.IsNullOrEmpty(txtSearch.Text))
            {
                dataGridView1.Rows.Add("Book", "978-0131103627", "The C Programming Language", "Available");
                dataGridView1.Rows.Add("Member", "M-001", "John Doe", "Active");
            }
        }
    }
}
