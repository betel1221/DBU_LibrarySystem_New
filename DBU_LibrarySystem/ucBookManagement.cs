using System.Windows.Forms;

namespace DBU_LibrarySystem
{
    public partial class ucBookManagement : UserControl
    {
        public ucBookManagement()
        {
            InitializeComponent();
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            dataGridView1.Rows.Add("978-0131103627", "The C Programming Language", "Brian W. Kernighan", "5");
            dataGridView1.Rows.Add("978-0201616224", "The Pragmatic Programmer", "Andy Hunt", "2");
        }
    }
}
