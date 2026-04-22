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
            
            panelTBooks.SuspendLayout();
            panelAMembers.SuspendLayout();
            panelBBorrowed.SuspendLayout();
            SuspendLayout();
            
            BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            Dock = System.Windows.Forms.DockStyle.Fill;
            Font = new System.Drawing.Font("Segoe UI", 10F);
            
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelTitle.Location = new System.Drawing.Point(30, 20);
            labelTitle.Text = "Library Dashboard";
            
            // Total Books
            panelTBooks.BackColor = System.Drawing.Color.White;
            panelTBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelTBooks.Location = new System.Drawing.Point(34, 80);
            panelTBooks.Size = new System.Drawing.Size(280, 150);
            
            lblTBooksTitle.AutoSize = true;
            lblTBooksTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTBooksTitle.ForeColor = System.Drawing.Color.Gray;
            lblTBooksTitle.Location = new System.Drawing.Point(20, 20);
            lblTBooksTitle.Text = "Total Books";
            
            lblTBooksNum.AutoSize = true;
            lblTBooksNum.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            lblTBooksNum.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblTBooksNum.Location = new System.Drawing.Point(20, 50);
            lblTBooksNum.Text = "1,245";
            
            panelTBooks.Controls.Add(lblTBooksTitle);
            panelTBooks.Controls.Add(lblTBooksNum);
            
            // Active Members
            panelAMembers.BackColor = System.Drawing.Color.White;
            panelAMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelAMembers.Location = new System.Drawing.Point(340, 80);
            panelAMembers.Size = new System.Drawing.Size(280, 150);
            
            lblAMembersTitle.AutoSize = true;
            lblAMembersTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblAMembersTitle.ForeColor = System.Drawing.Color.Gray;
            lblAMembersTitle.Location = new System.Drawing.Point(20, 20);
            lblAMembersTitle.Text = "Active Members";
            
            lblAMembersNum.AutoSize = true;
            lblAMembersNum.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            lblAMembersNum.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblAMembersNum.Location = new System.Drawing.Point(20, 50);
            lblAMembersNum.Text = "480";
            
            panelAMembers.Controls.Add(lblAMembersTitle);
            panelAMembers.Controls.Add(lblAMembersNum);
            
            // Books Borrowed
            panelBBorrowed.BackColor = System.Drawing.Color.White;
            panelBBorrowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelBBorrowed.Location = new System.Drawing.Point(646, 80);
            panelBBorrowed.Size = new System.Drawing.Size(280, 150);
            
            lblBBorrowedTitle.AutoSize = true;
            lblBBorrowedTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblBBorrowedTitle.ForeColor = System.Drawing.Color.Gray;
            lblBBorrowedTitle.Location = new System.Drawing.Point(20, 20);
            lblBBorrowedTitle.Text = "Books Borrowed";
            
            lblBBorrowedNum.AutoSize = true;
            lblBBorrowedNum.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            lblBBorrowedNum.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblBBorrowedNum.Location = new System.Drawing.Point(20, 50);
            lblBBorrowedNum.Text = "214";
            
            panelBBorrowed.Controls.Add(lblBBorrowedTitle);
            panelBBorrowed.Controls.Add(lblBBorrowedNum);
            
            Controls.Add(labelTitle);
            Controls.Add(panelTBooks);
            Controls.Add(panelAMembers);
            Controls.Add(panelBBorrowed);
            
            panelTBooks.ResumeLayout(false);
            panelTBooks.PerformLayout();
            panelAMembers.ResumeLayout(false);
            panelAMembers.PerformLayout();
            panelBBorrowed.ResumeLayout(false);
            panelBBorrowed.PerformLayout();
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
    }
}
