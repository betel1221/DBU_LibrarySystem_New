namespace DBU_LibrarySystem
{
    partial class ucGlobalSearch
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
            panelSearch = new System.Windows.Forms.Panel();
            txtSearch = new System.Windows.Forms.TextBox();
            cmbSearchMode = new System.Windows.Forms.ComboBox();
            cmbFilter = new System.Windows.Forms.ComboBox();
            btnSearch = new System.Windows.Forms.Button();
            btnReserve = new System.Windows.Forms.Button();
            lblSearchBy = new System.Windows.Forms.Label();
            panelList = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            panelSearch.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            
            BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            Dock = System.Windows.Forms.DockStyle.Fill;
            Font = new System.Drawing.Font("Segoe UI", 10F);
            
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelTitle.Location = new System.Drawing.Point(30, 20);
            labelTitle.Text = "Global Search";
            
            panelSearch.BackColor = System.Drawing.Color.White;
            panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelSearch.Location = new System.Drawing.Point(34, 80);
            panelSearch.Size = new System.Drawing.Size(900, 130);
            panelSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSearch.Location = new System.Drawing.Point(20, 70);
            txtSearch.PlaceholderText = "Type keywords here...";
            txtSearch.Size = new System.Drawing.Size(300, 30);
            
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;

            // btnReserve
            btnReserve.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReserve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnReserve.ForeColor = System.Drawing.Color.White;
            btnReserve.Location = new System.Drawing.Point(670, 15);
            btnReserve.Size = new System.Drawing.Size(150, 40);
            btnReserve.Text = "Reserve";
            btnReserve.Click += btnReserve_Click;
            btnReserve.Visible = true; // Will show/hide based on mode

            // cmbSearchMode
            cmbSearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSearchMode.Font = new System.Drawing.Font("Segoe UI", 12F);
            cmbSearchMode.Items.AddRange(new object[] { "Books", "Members" });
            cmbSearchMode.SelectedIndex = 0;
            cmbSearchMode.Location = new System.Drawing.Point(20, 25);
            cmbSearchMode.Size = new System.Drawing.Size(150, 30);
            cmbSearchMode.SelectedIndexChanged += cmbSearchMode_SelectedIndexChanged;

            // cmbFilter
            cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            cmbFilter.Items.AddRange(new object[] { "By Title", "By Author", "By ISBN", "By Category", "By Year" });
            cmbFilter.SelectedIndex = 0;
            cmbFilter.Location = new System.Drawing.Point(340, 70);
            cmbFilter.Size = new System.Drawing.Size(200, 30);

            // lblSearchBy
            lblSearchBy.AutoSize = true;
            lblSearchBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSearchBy.ForeColor = System.Drawing.Color.Gray;
            lblSearchBy.Location = new System.Drawing.Point(340, 45);
            lblSearchBy.Text = "SELECT SEARCH CRITERIA:";
            
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(cmbSearchMode);
            panelSearch.Controls.Add(lblSearchBy);
            panelSearch.Controls.Add(cmbFilter);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(btnReserve);
            
            panelList.BackColor = System.Drawing.Color.White;
            panelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelList.Location = new System.Drawing.Point(34, 230);
            panelList.Size = new System.Drawing.Size(900, 370);
            panelList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = System.Drawing.Color.LightGray;
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            cellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle = cellStyle;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new System.Drawing.Point(20, 20);
            dataGridView1.Size = new System.Drawing.Size(860, 360);
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            colType.HeaderText = "Type";
            colID.HeaderText = "ID/ISBN";
            colDetail.HeaderText = "Details";
            colStatus.HeaderText = "Status";
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colType, colID, colDetail, colStatus });
            
            panelList.Controls.Add(dataGridView1);
            
            Controls.Add(labelTitle);
            Controls.Add(panelSearch);
            Controls.Add(panelList);
            
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchMode;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
