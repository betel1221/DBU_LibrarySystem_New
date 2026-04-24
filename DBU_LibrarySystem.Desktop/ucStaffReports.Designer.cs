namespace DBU_LibrarySystem
{
    partial class ucStaffReports
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new System.Windows.Forms.Label();
            
            panelStats = new System.Windows.Forms.Panel();
            lblStatsTitle = new System.Windows.Forms.Label();
            btnRefresh = new System.Windows.Forms.Button();
            btnCollectFine = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            colMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTransID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            panelStats.SuspendLayout();
            SuspendLayout();
            
            BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            Dock = System.Windows.Forms.DockStyle.Fill;
            Font = new System.Drawing.Font("Segoe UI", 10F);
            
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelTitle.Location = new System.Drawing.Point(30, 20);
            labelTitle.Text = "Library Statistics";
            
            // STATS PANEL
            panelStats.BackColor = System.Drawing.Color.White;
            panelStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelStats.Location = new System.Drawing.Point(34, 80);
            panelStats.Size = new System.Drawing.Size(900, 400);
            panelStats.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            
            lblStatsTitle.AutoSize = true;
            lblStatsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblStatsTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblStatsTitle.Location = new System.Drawing.Point(30, 20);
            lblStatsTitle.Text = "Outstanding Fines & Overdue Books";
            
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(30, 60);
            btnRefresh.Size = new System.Drawing.Size(150, 35);
            btnRefresh.Text = "Refresh List";
            btnRefresh.Click += btnRefresh_Click;

            btnCollectFine.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            btnCollectFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCollectFine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCollectFine.ForeColor = System.Drawing.Color.White;
            btnCollectFine.Location = new System.Drawing.Point(190, 60);
            btnCollectFine.Size = new System.Drawing.Size(180, 35);
            btnCollectFine.Text = "Mark as Paid";
            btnCollectFine.Click += btnCollectFine_Click;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.Location = new System.Drawing.Point(30, 110);
            dataGridView1.Size = new System.Drawing.Size(840, 260);
            
            colMember.HeaderText = "Student Name";
            colBook.HeaderText = "Book Title";
            colDueDate.HeaderText = "Due Date";
            colFine.HeaderText = "Accrued Fine ($)";
            colTransID.Visible = false;

            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colMember, colBook, colDueDate, colFine, colTransID });

            panelStats.Controls.Add(lblStatsTitle);
            panelStats.Controls.Add(btnRefresh);
            panelStats.Controls.Add(btnCollectFine);
            panelStats.Controls.Add(dataGridView1);
            
            Controls.Add(labelTitle);
            Controls.Add(panelStats);
            
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblStatsTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCollectFine;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransID;
    }
}
