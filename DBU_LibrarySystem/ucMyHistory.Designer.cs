namespace DBU_LibrarySystem
{
    partial class ucMyHistory
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
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            labelTitle = new System.Windows.Forms.Label();
            panelList = new System.Windows.Forms.Panel();
            btnRefresh = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            
            BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            Dock = System.Windows.Forms.DockStyle.Fill;
            Font = new System.Drawing.Font("Segoe UI", 10F);
            
            // Title
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelTitle.Location = new System.Drawing.Point(30, 20);
            labelTitle.Text = "My Borrowing History";
            
            // Container Panel
            panelList.BackColor = System.Drawing.Color.White;
            panelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelList.Location = new System.Drawing.Point(34, 80);
            panelList.Size = new System.Drawing.Size(900, 500);
            panelList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            // Refresh Button
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(20, 20);
            btnRefresh.Size = new System.Drawing.Size(160, 40);
            btnRefresh.Text = "Refresh Records";
            
            // DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = System.Drawing.Color.FromArgb(238, 242, 246);
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            cellStyle.ForeColor = System.Drawing.Color.FromArgb(64,64,64);
            dataGridView1.ColumnHeadersDefaultCellStyle = cellStyle;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new System.Drawing.Point(20, 80);
            dataGridView1.Size = new System.Drawing.Size(860, 380);
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            colTitle.HeaderText = "Book Title";
            colBorrowDate.HeaderText = "Borrow Date";
            colReturnDate.HeaderText = "Return Date";
            colReturnDate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            colFine.HeaderText = "Fine Status";
            
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colTitle, colBorrowDate, colReturnDate, colFine });
            
            panelList.Controls.Add(btnRefresh);
            panelList.Controls.Add(dataGridView1);
            
            Controls.Add(labelTitle);
            Controls.Add(panelList);
            
            panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFine;
    }
}
