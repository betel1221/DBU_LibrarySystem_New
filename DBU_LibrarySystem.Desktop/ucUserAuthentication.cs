using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucUserAuthentication : UserControl
    {
        public ucUserAuthentication()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            dataGridView1.Rows.Add("E-001", "johndoe", "Employee");
            dataGridView1.Rows.Add("S-105", "asmith", "Student");
        }
    }
}
