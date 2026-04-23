using System.Windows.Forms;
using DBU_LibrarySystem.Services;
using DBU_LibrarySystem.Utilities;
using System.Linq;
namespace DBU_LibrarySystem
{
    public partial class ucBookManagement : UserControl
    {
        public ucBookManagement()
        {
            InitializeComponent();
            LoadRealData();
            ThemeHelper.ApplyTheme(this);
        }

        private void LoadRealData()
        {
            dataGridView1.Rows.Clear();
            var books = LibraryManager.SearchBooks("");
            foreach (var b in books)
            {
                dataGridView1.Rows.Add(b.ISBN, b.Title, b.Author, b.Category, b.YearOfPublication, b.Copies.Count);
            }
        }
    }
}
