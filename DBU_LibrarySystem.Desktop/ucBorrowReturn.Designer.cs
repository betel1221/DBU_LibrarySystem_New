namespace DBU_LibrarySystem
{
    partial class ucBorrowReturn
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
            panelIssue = new System.Windows.Forms.Panel();
            labelIssue = new System.Windows.Forms.Label();
            txtIssueMember = new System.Windows.Forms.TextBox();
            txtIssueBook = new System.Windows.Forms.TextBox();
            btnIssue = new System.Windows.Forms.Button();
            panelReturn = new System.Windows.Forms.Panel();
            labelReturn = new System.Windows.Forms.Label();
            txtReturnBook = new System.Windows.Forms.TextBox();
            btnReturn = new System.Windows.Forms.Button();
            
            panelIssue.SuspendLayout();
            panelReturn.SuspendLayout();
            SuspendLayout();
            
            BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            Dock = System.Windows.Forms.DockStyle.Fill;
            Font = new System.Drawing.Font("Segoe UI", 10F);
            
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelTitle.Location = new System.Drawing.Point(30, 20);
            labelTitle.Text = "Issue & Return Books";
            
            panelIssue.BackColor = System.Drawing.Color.White;
            panelIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelIssue.Location = new System.Drawing.Point(34, 80);
            panelIssue.Size = new System.Drawing.Size(430, 200);
            
            labelIssue.AutoSize = true;
            labelIssue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            labelIssue.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelIssue.Location = new System.Drawing.Point(20, 15);
            labelIssue.Text = "Issue Book";
            
            txtIssueMember.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtIssueMember.Location = new System.Drawing.Point(20, 60);
            txtIssueMember.PlaceholderText = "Member ID";
            txtIssueMember.Size = new System.Drawing.Size(180, 30);
            
            txtIssueBook.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtIssueBook.Location = new System.Drawing.Point(220, 60);
            txtIssueBook.PlaceholderText = "Book Copy ID";
            txtIssueBook.Size = new System.Drawing.Size(180, 30);
            
            btnIssue.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIssue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnIssue.ForeColor = System.Drawing.Color.White;
            btnIssue.Location = new System.Drawing.Point(20, 120);
            btnIssue.Size = new System.Drawing.Size(150, 40);
            btnIssue.Text = "Issue";
            
            panelIssue.Controls.Add(labelIssue);
            panelIssue.Controls.Add(txtIssueMember);
            panelIssue.Controls.Add(txtIssueBook);
            panelIssue.Controls.Add(btnIssue);

            // Return Panel
            panelReturn.BackColor = System.Drawing.Color.White;
            panelReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelReturn.Location = new System.Drawing.Point(500, 80);
            panelReturn.Size = new System.Drawing.Size(430, 200);
            
            labelReturn.AutoSize = true;
            labelReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            labelReturn.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelReturn.Location = new System.Drawing.Point(20, 15);
            labelReturn.Text = "Return Book";
            
            txtReturnBook.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtReturnBook.Location = new System.Drawing.Point(20, 60);
            txtReturnBook.PlaceholderText = "Book Copy ID";
            txtReturnBook.Size = new System.Drawing.Size(180, 30);
            
            btnReturn.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReturn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnReturn.ForeColor = System.Drawing.Color.White;
            btnReturn.Location = new System.Drawing.Point(20, 120);
            btnReturn.Size = new System.Drawing.Size(150, 40);
            btnReturn.Text = "Return";
            
            panelReturn.Controls.Add(labelReturn);
            panelReturn.Controls.Add(txtReturnBook);
            panelReturn.Controls.Add(btnReturn);
            
            Controls.Add(labelTitle);
            Controls.Add(panelIssue);
            Controls.Add(panelReturn);
            
            panelIssue.ResumeLayout(false);
            panelIssue.PerformLayout();
            panelReturn.ResumeLayout(false);
            panelReturn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelIssue;
        private System.Windows.Forms.Label labelIssue;
        private System.Windows.Forms.TextBox txtIssueMember;
        private System.Windows.Forms.TextBox txtIssueBook;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Panel panelReturn;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.TextBox txtReturnBook;
        private System.Windows.Forms.Button btnReturn;
    }
}
