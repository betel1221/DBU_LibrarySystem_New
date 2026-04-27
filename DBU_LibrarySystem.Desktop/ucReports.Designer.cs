namespace DBU_LibrarySystem
{
    partial class ucReports
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
            panelTBooks = new System.Windows.Forms.Panel();
            lblTBooksTitle = new System.Windows.Forms.Label();
            lblTBooksNum = new System.Windows.Forms.Label();
            panelAMembers = new System.Windows.Forms.Panel();
            lblAMembersTitle = new System.Windows.Forms.Label();
            lblAMembersNum = new System.Windows.Forms.Label();
            panelBBorrowed = new System.Windows.Forms.Panel();
            lblBBorrowedTitle = new System.Windows.Forms.Label();
            lblBBorrowedNum = new System.Windows.Forms.Label();
            btnRefresh = new System.Windows.Forms.Button();
            panelGraph = new System.Windows.Forms.Panel();
            lblGraphTitle = new System.Windows.Forms.Label();
            
            panelTBooks.SuspendLayout();
            panelAMembers.SuspendLayout();
            panelBBorrowed.SuspendLayout();
            panelGraph.SuspendLayout();
            SuspendLayout();
            
            this.BackColor = System.Drawing.Color.Black;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelTitle.Location = new System.Drawing.Point(30, 20);
            labelTitle.Text = "Analytics & Reports Dashboard";
            
            // Stats Section
            int cardWidth = 300;
            int cardHeight = 130;
            int startY = 80;
            
            // Total Books
            panelTBooks.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            panelTBooks.Location = new System.Drawing.Point(34, startY);
            panelTBooks.Size = new System.Drawing.Size(cardWidth, cardHeight);
            
            lblTBooksTitle.AutoSize = true;
            lblTBooksTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTBooksTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblTBooksTitle.Location = new System.Drawing.Point(20, 20);
            lblTBooksTitle.Text = "TOTAL BOOKS INVENTORY";
            
            lblTBooksNum.AutoSize = true;
            lblTBooksNum.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            lblTBooksNum.ForeColor = System.Drawing.Color.White;
            lblTBooksNum.Location = new System.Drawing.Point(20, 45);
            lblTBooksNum.Text = "0";
            
            panelTBooks.Controls.Add(lblTBooksTitle);
            panelTBooks.Controls.Add(lblTBooksNum);
            
            // Active Members
            panelAMembers.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            panelAMembers.Location = new System.Drawing.Point(350, startY);
            panelAMembers.Size = new System.Drawing.Size(cardWidth, cardHeight);
            
            lblAMembersTitle.AutoSize = true;
            lblAMembersTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblAMembersTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblAMembersTitle.Location = new System.Drawing.Point(20, 20);
            lblAMembersTitle.Text = "ACTIVE LIBRARY MEMBERS";
            
            lblAMembersNum.AutoSize = true;
            lblAMembersNum.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            lblAMembersNum.ForeColor = System.Drawing.Color.White;
            lblAMembersNum.Location = new System.Drawing.Point(20, 45);
            lblAMembersNum.Text = "0";
            
            panelAMembers.Controls.Add(lblAMembersTitle);
            panelAMembers.Controls.Add(lblAMembersNum);
            
            // Books Borrowed
            panelBBorrowed.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            panelBBorrowed.Location = new System.Drawing.Point(666, startY);
            panelBBorrowed.Size = new System.Drawing.Size(300, cardHeight);
            
            lblBBorrowedTitle.AutoSize = true;
            lblBBorrowedTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblBBorrowedTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblBBorrowedTitle.Location = new System.Drawing.Point(20, 20);
            lblBBorrowedTitle.Text = "BOOKS CURRENTLY OUT";
            
            lblBBorrowedNum.AutoSize = true;
            lblBBorrowedNum.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            lblBBorrowedNum.ForeColor = System.Drawing.Color.White;
            lblBBorrowedNum.Location = new System.Drawing.Point(20, 45);
            lblBBorrowedNum.Text = "0";
            
            panelBBorrowed.Controls.Add(lblBBorrowedTitle);
            panelBBorrowed.Controls.Add(lblBBorrowedNum);
            
            // Graph Section
            panelGraph.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            panelGraph.Location = new System.Drawing.Point(34, 230);
            panelGraph.Size = new System.Drawing.Size(932, 400);
            panelGraph.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            lblGraphTitle.AutoSize = true;
            lblGraphTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblGraphTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblGraphTitle.Location = new System.Drawing.Point(20, 15);
            lblGraphTitle.Text = "MONTHLY BORROWING ACTIVITY (Visualized)";

            panelGraph.Controls.Add(lblGraphTitle);
            
            // Refresh Button
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(846, 25);
            btnRefresh.Size = new System.Drawing.Size(120, 35);
            btnRefresh.Text = "REFRESH DATA";
            btnRefresh.Click += btnRefresh_Click;

            Controls.Add(labelTitle);
            Controls.Add(btnRefresh);
            Controls.Add(panelTBooks);
            Controls.Add(panelAMembers);
            Controls.Add(panelBBorrowed);
            Controls.Add(panelGraph);
            
            panelTBooks.ResumeLayout(false);
            panelTBooks.PerformLayout();
            panelAMembers.ResumeLayout(false);
            panelAMembers.PerformLayout();
            panelBBorrowed.ResumeLayout(false);
            panelBBorrowed.PerformLayout();
            panelGraph.ResumeLayout(false);
            panelGraph.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelTBooks;
        private System.Windows.Forms.Label lblTBooksTitle;
        private System.Windows.Forms.Label lblTBooksNum;
        private System.Windows.Forms.Panel panelAMembers;
        private System.Windows.Forms.Label lblAMembersTitle;
        private System.Windows.Forms.Label lblAMembersNum;
        private System.Windows.Forms.Panel panelBBorrowed;
        private System.Windows.Forms.Label lblBBorrowedTitle;
        private System.Windows.Forms.Label lblBBorrowedNum;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Label lblGraphTitle;
    }
}
