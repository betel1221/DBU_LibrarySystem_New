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
            btnReturn = new System.Windows.Forms.Button();

            // Instantiate controls that were missing and caused NullReferenceException
            labelTitle = new System.Windows.Forms.Label();
            panelBorrow = new System.Windows.Forms.Panel();
            lblBorrowTitle = new System.Windows.Forms.Label();
            txtBMember = new System.Windows.Forms.TextBox();
            lblMemberName = new System.Windows.Forms.Label();
            txtBBook = new System.Windows.Forms.TextBox();
            btnBorrow = new System.Windows.Forms.Button();

            panelReturn = new System.Windows.Forms.Panel();
            lblReturnTitle = new System.Windows.Forms.Label();
            txtRBook = new System.Windows.Forms.TextBox();

            panelList = new System.Windows.Forms.Panel();
            lblListTitle = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            colMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
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
            panelBorrow.Size = new System.Drawing.Size(420, 220);
            
            lblBorrowTitle.AutoSize = true;
            lblBorrowTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblBorrowTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblBorrowTitle.Location = new System.Drawing.Point(30, 20);
            lblBorrowTitle.Text = "Borrow Book";
            
            txtBMember.Location = new System.Drawing.Point(30, 60);
            txtBMember.PlaceholderText = "Member ID";
            txtBMember.Size = new System.Drawing.Size(350, 30);

            lblMemberName.AutoSize = true;
            lblMemberName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            lblMemberName.ForeColor = System.Drawing.Color.Gray;
            lblMemberName.Location = new System.Drawing.Point(30, 95);
            lblMemberName.Text = "Enter valid ID...";
            
            txtBBook.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtBBook.Location = new System.Drawing.Point(30, 110);
            txtBBook.PlaceholderText = "Copy ID (e.g. 1001-C1)";
            txtBBook.Size = new System.Drawing.Size(350, 30);
            
            btnBorrow.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBorrow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnBorrow.ForeColor = System.Drawing.Color.White;
            btnBorrow.Location = new System.Drawing.Point(30, 160);
            btnBorrow.Size = new System.Drawing.Size(350, 40);
            btnBorrow.Text = "Issue Book (14 Days)";
            btnBorrow.Click += btnBorrow_Click;
            
            panelBorrow.Controls.Add(lblBorrowTitle);
            panelBorrow.Controls.Add(txtBMember);
            panelBorrow.Controls.Add(lblMemberName);
            panelBorrow.Controls.Add(txtBBook);
            panelBorrow.Controls.Add(btnBorrow);

            // RETURN PANEL
            panelReturn.BackColor = System.Drawing.Color.White;
            panelReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelReturn.Location = new System.Drawing.Point(480, 80);
            panelReturn.Size = new System.Drawing.Size(420, 220);
            
            lblReturnTitle.AutoSize = true;
            lblReturnTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblReturnTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblReturnTitle.Location = new System.Drawing.Point(30, 20);
            lblReturnTitle.Text = "Return Book";
            
            txtRBook.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtRBook.Location = new System.Drawing.Point(30, 70);
            txtRBook.PlaceholderText = "Copy ID to Return";
            txtRBook.Size = new System.Drawing.Size(350, 30);
            
            btnReturn.BackColor = System.Drawing.Color.FromArgb(25, 135, 84);
            btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReturn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnReturn.ForeColor = System.Drawing.Color.White;
            btnReturn.Location = new System.Drawing.Point(30, 120);
            btnReturn.Size = new System.Drawing.Size(350, 40);
            btnReturn.Text = "Process Return";
            btnReturn.Click += btnReturn_Click;
            
            panelReturn.Controls.Add(lblReturnTitle);
            panelReturn.Controls.Add(txtRBook);
            panelReturn.Controls.Add(btnReturn);

            // LIST PANEL
            panelList.BackColor = System.Drawing.Color.White;
            panelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelList.Location = new System.Drawing.Point(34, 320);
            panelList.Size = new System.Drawing.Size(866, 260);
            panelList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;

            lblListTitle.AutoSize = true;
            lblListTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblListTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblListTitle.Location = new System.Drawing.Point(20, 10);
            lblListTitle.Text = "Current Issued Books (Active Loans)";

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.Location = new System.Drawing.Point(20, 40);
            dataGridView1.Size = new System.Drawing.Size(826, 200);
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;

            colMember.HeaderText = "Student";
            colBook.HeaderText = "Book/Copy";
            colDueDate.HeaderText = "Due Date";
            colStatus.HeaderText = "Status";

            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colMember, colBook, colDueDate, colStatus });

            panelList.Controls.Add(lblListTitle);
            panelList.Controls.Add(dataGridView1);
            
            Controls.Add(labelTitle);
            Controls.Add(panelBorrow);
            Controls.Add(panelReturn);
            Controls.Add(panelList);
            
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
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtBBook;
        private System.Windows.Forms.Button btnBorrow;
        
        private System.Windows.Forms.Panel panelReturn;
        private System.Windows.Forms.Label lblReturnTitle;
        private System.Windows.Forms.TextBox txtRBook;
        private System.Windows.Forms.Button btnReturn;

        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
