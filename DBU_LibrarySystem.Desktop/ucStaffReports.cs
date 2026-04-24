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
            LoadOverdueList();
        }

        private void LoadOverdueList()
        {
            dataGridView1.Rows.Clear();
            var overdue = Services.LibraryManager.GetActiveBorrows();
            
            foreach (var t in overdue)
            {
                decimal fine = Services.LibraryManager.CalculateFine(t.DueDate);
                if (fine > 0 || t.IsFinePaid)
                {
                    string status = t.IsFinePaid ? "✅ Paid" : "❌ Unpaid";
                    int rowIndex = dataGridView1.Rows.Add(t.User.Name, t.BookCopy.Book.Title, t.DueDate.ToShortDateString(), fine.ToString("N2"), status, t.Id);
                    
                    if (!t.IsFinePaid)
                    {
                        dataGridView1.Rows[rowIndex].Cells[4].Style.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        dataGridView1.Rows[rowIndex].Cells[4].Style.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                string status = row.Cells[4].Value?.ToString() ?? "";
                string fineText = row.Cells[3].Value?.ToString() ?? "0";
                decimal.TryParse(fineText, out decimal fine);
                
                // Only enable if fine exists and is not yet paid
                btnSettleBalance.Enabled = (status == "❌ Unpaid" && fine > 0);
            }
            else
            {
                btnSettleBalance.Enabled = false;
            }
        }

        private void btnSettleBalance_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                string student = row.Cells[0].Value.ToString();
                string amount = row.Cells[3].Value.ToString();
                int transId = (int)row.Cells[5].Value;

                var res = MessageBox.Show($"Confirm payment of ${amount} for {student}?", "Confirm Settlement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        Services.LibraryManager.SettleFine(transId);
                        MessageBox.Show("Fine settled successfully!");
                        LoadOverdueList();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOverdueList();
        }
    }
}
