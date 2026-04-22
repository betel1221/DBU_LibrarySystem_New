using System;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucMyHistory : UserControl
    {
        public ucMyHistory()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            dataGridView1.Rows.Add("mnduban", "2026-01-16", "Still Borrowed", "✅ None");
            dataGridView1.Rows.Add("aaa", "2026-01-13", "2026-01-14", "✅ None");
            dataGridView1.Rows.Add("Sememen", "2026-01-13", "Still Borrowed", "✅ None");
        }
    }
}
