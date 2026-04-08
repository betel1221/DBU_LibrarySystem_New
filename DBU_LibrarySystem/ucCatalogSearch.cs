using System;
using System.Windows.Forms;

namespace DBU_LibrarySystem
{
    public partial class ucCatalogSearch : UserControl
    {
        public ucCatalogSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if(txtSearch.Text.ToLower().Contains("fikr"))
            {
                dataGridView1.Rows.Add("fikr eske mekabr\nhadis alemayehu", "❌ Issued");
                dataGridView1.Rows.Add("fikr eske mekabr\nhadis alemayehu", "✅ Available");
                
                // Adjust row height to show both lines for details
                dataGridView1.Rows[0].Height = 60;
                dataGridView1.Rows[1].Height = 60;
            }
        }
    }
}
