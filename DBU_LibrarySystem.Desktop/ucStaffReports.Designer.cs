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
            btnTotalInventory = new System.Windows.Forms.Button();
            btnBooksOnLoan = new System.Windows.Forms.Button();
            lblStatValue = new System.Windows.Forms.Label();
            
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
            lblStatsTitle.Text = "Library Statistics";
            
            btnTotalInventory.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnTotalInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTotalInventory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnTotalInventory.ForeColor = System.Drawing.Color.White;
            btnTotalInventory.Location = new System.Drawing.Point(30, 70);
            btnTotalInventory.Size = new System.Drawing.Size(150, 40);
            btnTotalInventory.Text = "Total Inventory";
            btnTotalInventory.Click += btnTotalInventory_Click;
            
            btnBooksOnLoan.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnBooksOnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBooksOnLoan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnBooksOnLoan.ForeColor = System.Drawing.Color.White;
            btnBooksOnLoan.Location = new System.Drawing.Point(190, 70);
            btnBooksOnLoan.Size = new System.Drawing.Size(150, 40);
            btnBooksOnLoan.Text = "Books on Loan";
            btnBooksOnLoan.Click += btnBooksOnLoan_Click;
            
            lblStatValue.AutoSize = true;
            lblStatValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblStatValue.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblStatValue.Location = new System.Drawing.Point(30, 150);
            lblStatValue.Text = "TOTAL BOOKS: 13";
            lblStatValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblStatValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            
            panelStats.Controls.Add(lblStatsTitle);
            panelStats.Controls.Add(btnTotalInventory);
            panelStats.Controls.Add(btnBooksOnLoan);
            panelStats.Controls.Add(lblStatValue);
            
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
        private System.Windows.Forms.Button btnTotalInventory;
        private System.Windows.Forms.Button btnBooksOnLoan;
        private System.Windows.Forms.Label lblStatValue;
    }
}
