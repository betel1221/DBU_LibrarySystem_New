using System;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucMemberManagement : UserControl
    {
        public ucMemberManagement()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            dataGridView1.Rows.Add("M-001", "John Doe", "john.doe@dbu.edu");
            dataGridView1.Rows.Add("M-002", "Jane Smith", "jane.smith@dbu.edu");
            dataGridView1.Rows.Add("M-003", "Alice Johnson", "alice.j@dbu.edu");
        }
    }
}
