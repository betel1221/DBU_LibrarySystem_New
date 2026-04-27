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
            btnIssue = new System.Windows.Forms.Button();
            lblSearchBy = new System.Windows.Forms.Label();
            panelList = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            
            panelSearch.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            
            // Background & Dock
            BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            Dock = System.Windows.Forms.DockStyle.Fill;
            Font = new System.Drawing.Font("Segoe UI", 10F);
            
            // labelTitle
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelTitle.Location = new System.Drawing.Point(30, 20);
            labelTitle.Text = "Global Search";
            
            // panelSearch
            panelSearch.BackColor = System.Drawing.Color.White;
            panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelSearch.Location = new System.Drawing.Point(34, 80);
            panelSearch.Size = new System.Drawing.Size(950, 130); // Width increased for button visibility
            panelSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            
            // cmbSearchMode
            cmbSearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSearchMode.Items.AddRange(new object[] { "Books", "Members" });
            cmbSearchMode.Location = new System.Drawing.Point(20, 25);
            cmbSearchMode.Size = new System.Drawing.Size(150, 30);
            cmbSearchMode.SelectedIndexChanged += cmbSearchMode_SelectedIndexChanged;

            // txtSearch
            txtSearch.Location = new System.Drawing.Point(20, 70);
            txtSearch.PlaceholderText = "Type keywords here...";
            txtSearch.Size = new System.Drawing.Size(300, 30);
            
            // lblSearchBy
            lblSearchBy.AutoSize = true;
            lblSearchBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSearchBy.ForeColor = System.Drawing.Color.Gray;
            lblSearchBy.Location = new System.Drawing.Point(340, 40);
            lblSearchBy.Text = "SELECT SEARCH CRITERIA:";

            // cmbFilter
            cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFilter.Location = new System.Drawing.Point(340, 75);
            cmbFilter.Size = new System.Drawing.Size(200, 30);

            // UPDATED: btnSearch (Moved to right of filter)
            btnSearch.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSearch.Location = new System.Drawing.Point(560, 65);
            btnSearch.Size = new System.Drawing.Size(110, 40);
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;

            // UPDATED: btnIssue (Moved further right to prevent overlap)
            btnIssue.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIssue.ForeColor = System.Drawing.Color.White;
            btnIssue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnIssue.Location = new System.Drawing.Point(685, 65);
            btnIssue.Size = new System.Drawing.Size(130, 40);
            btnIssue.Text = "Issue Book";
            btnIssue.Click += btnIssue_Click;
            
            // panelSearch Controls
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(cmbSearchMode);
            panelSearch.Controls.Add(lblSearchBy);
            panelSearch.Controls.Add(cmbFilter);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(btnIssue);
            
            // panelList & DataGridView
            panelList.BackColor = System.Drawing.Color.White;
            panelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelList.Location = new System.Drawing.Point(34, 230);
            panelList.Size = new System.Drawing.Size(950, 370);
            panelList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            
            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            cellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle = cellStyle;
            
            panelList.Controls.Add(dataGridView1);
            
            // Add to Main Control
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
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}