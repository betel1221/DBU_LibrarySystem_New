namespace DBU_LibrarySystem
{
    partial class ucStaffCirculation
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
            
            panelBorrow = new System.Windows.Forms.Panel();
            lblBorrowTitle = new System.Windows.Forms.Label();
            txtBMember = new System.Windows.Forms.TextBox();
            txtBBook = new System.Windows.Forms.TextBox();
            dtpBDate = new System.Windows.Forms.DateTimePicker();
            btnBorrow = new System.Windows.Forms.Button();
            
            panelReturn = new System.Windows.Forms.Panel();
            lblReturnTitle = new System.Windows.Forms.Label();
            txtRMember = new System.Windows.Forms.TextBox();
            txtRBook = new System.Windows.Forms.TextBox();
            dtpRDate = new System.Windows.Forms.DateTimePicker();
            btnReturn = new System.Windows.Forms.Button();
            
            panelBorrow.SuspendLayout();
            panelReturn.SuspendLayout();
            SuspendLayout();
            
            BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            Dock = System.Windows.Forms.DockStyle.Fill;
            Font = new System.Drawing.Font("Segoe UI", 10F);
            
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelTitle.Location = new System.Drawing.Point(30, 20);
            labelTitle.Text = "Circulation Services";
            
            // BORROW PANEL
            panelBorrow.BackColor = System.Drawing.Color.White;
            panelBorrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelBorrow.Location = new System.Drawing.Point(34, 80);
            panelBorrow.Size = new System.Drawing.Size(420, 320);
            
            lblBorrowTitle.AutoSize = true;
            lblBorrowTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblBorrowTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblBorrowTitle.Location = new System.Drawing.Point(30, 20);
            lblBorrowTitle.Text = "Borrow Book";
            
            txtBMember.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtBMember.Location = new System.Drawing.Point(30, 70);
            txtBMember.PlaceholderText = "Member ID";
            txtBMember.Size = new System.Drawing.Size(350, 30);
            
            txtBBook.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtBBook.Location = new System.Drawing.Point(30, 130);
            txtBBook.PlaceholderText = "Book ID";
            txtBBook.Size = new System.Drawing.Size(350, 30);
            
            dtpBDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            dtpBDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpBDate.Location = new System.Drawing.Point(30, 190);
            dtpBDate.Size = new System.Drawing.Size(350, 30);
            
            btnBorrow.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBorrow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnBorrow.ForeColor = System.Drawing.Color.White;
            btnBorrow.Location = new System.Drawing.Point(30, 250);
            btnBorrow.Size = new System.Drawing.Size(350, 45);
            btnBorrow.Text = "Issue Book";
            
            panelBorrow.Controls.Add(lblBorrowTitle);
            panelBorrow.Controls.Add(txtBMember);
            panelBorrow.Controls.Add(txtBBook);
            panelBorrow.Controls.Add(dtpBDate);
            panelBorrow.Controls.Add(btnBorrow);

            // RETURN PANEL
            panelReturn.BackColor = System.Drawing.Color.White;
            panelReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelReturn.Location = new System.Drawing.Point(480, 80);
            panelReturn.Size = new System.Drawing.Size(420, 320);
            
            lblReturnTitle.AutoSize = true;
            lblReturnTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblReturnTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblReturnTitle.Location = new System.Drawing.Point(30, 20);
            lblReturnTitle.Text = "Return Book";
            
            txtRMember.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtRMember.Location = new System.Drawing.Point(30, 70);
            txtRMember.PlaceholderText = "Member ID";
            txtRMember.Size = new System.Drawing.Size(350, 30);
            
            txtRBook.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtRBook.Location = new System.Drawing.Point(30, 130);
            txtRBook.PlaceholderText = "Book ID";
            txtRBook.Size = new System.Drawing.Size(350, 30);
            
            dtpRDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            dtpRDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpRDate.Location = new System.Drawing.Point(30, 190);
            dtpRDate.Size = new System.Drawing.Size(350, 30);
            
            btnReturn.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReturn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnReturn.ForeColor = System.Drawing.Color.White;
            btnReturn.Location = new System.Drawing.Point(30, 250);
            btnReturn.Size = new System.Drawing.Size(350, 45);
            btnReturn.Text = "Process Return";
            
            panelReturn.Controls.Add(lblReturnTitle);
            panelReturn.Controls.Add(txtRMember);
            panelReturn.Controls.Add(txtRBook);
            panelReturn.Controls.Add(dtpRDate);
            panelReturn.Controls.Add(btnReturn);
            
            Controls.Add(labelTitle);
            Controls.Add(panelBorrow);
            Controls.Add(panelReturn);
            
            panelBorrow.ResumeLayout(false);
            panelBorrow.PerformLayout();
            panelReturn.ResumeLayout(false);
            panelReturn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelBorrow;
        private System.Windows.Forms.Label lblBorrowTitle;
        private System.Windows.Forms.TextBox txtBMember;
        private System.Windows.Forms.TextBox txtBBook;
        private System.Windows.Forms.DateTimePicker dtpBDate;
        private System.Windows.Forms.Button btnBorrow;
        
        private System.Windows.Forms.Panel panelReturn;
        private System.Windows.Forms.Label lblReturnTitle;
        private System.Windows.Forms.TextBox txtRMember;
        private System.Windows.Forms.TextBox txtRBook;
        private System.Windows.Forms.DateTimePicker dtpRDate;
        private System.Windows.Forms.Button btnReturn;
    }
}
