using System;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;
using System.Linq;

namespace DBU_LibrarySystem
{
    public partial class ucStaffReports : UserControl
    {
        public ucStaffReports()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            LoadOverdueList();
        }

        private void LoadOverdueList()
        {
            dataGridView1.Rows.Clear();
            var activeBorrows = Services.LibraryManager.GetActiveBorrows();
            
            foreach (var t in activeBorrows)
            {
                decimal fine = Services.LibraryManager.CalculateFine(t.DueDate);
                if (fine > 0)
                {
                    dataGridView1.Rows.Add(t.User.Name, t.BookCopy.Book.Title, t.DueDate.ToShortDateString(), fine.ToString("N2"), t.Id);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOverdueList();
        }

        private void btnCollectFine_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                int transId = (int)row.Cells[4].Value;
                string student = row.Cells[0].Value.ToString();
                string amount = row.Cells[3].Value.ToString();

                var result = MessageBox.Show($"Collect ${amount} from {student} and mark as paid?", "Confirm Collection", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Services.LibraryManager.SettleFine(transId);
                    MessageBox.Show("Fine settled successfully!");
                    LoadOverdueList();
                }
            }
            else
            {
                MessageBox.Show("Please select a student from the list first.");
            }
        }
    }
}
