using System;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;
using System.Linq;

namespace DBU_LibrarySystem
{
    public partial class ucNotifications : UserControl
    {
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridView1;

        public ucNotifications()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
        }

        private void InitializeComponent()
        {
            labelTitle = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelTitle.Location = new System.Drawing.Point(30, 20);
            labelTitle.Text = "My Notifications";

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.Location = new System.Drawing.Point(34, 80);
            dataGridView1.Size = new System.Drawing.Size(900, 500);
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            Controls.Add(labelTitle);
            Controls.Add(dataGridView1);

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public void LoadNotifications(string userId)
        {
            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Date", "Date");
                dataGridView1.Columns.Add("Message", "Message");
            }

            using (var db = new DBU_LibrarySystem.Data.LibraryContext())
            {
                var notes = db.Notifications.Where(n => n.UserId == userId).OrderByDescending(n => n.Date).ToList();
                foreach (var n in notes)
                {
                    dataGridView1.Rows.Add(n.Date.ToShortDateString(), n.Message);
                }
            }
        }
    }
}
