namespace DBU_LibrarySystem
{
    partial class ucCatalogSearch
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
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            
            labelTitle = new System.Windows.Forms.Label();
            panelList = new System.Windows.Forms.Panel();
            txtSearch = new System.Windows.Forms.TextBox();
            cmbFilter = new System.Windows.Forms.ComboBox();
            btnSearch = new System.Windows.Forms.Button();
            lblSearchBy = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            
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
            labelTitle.Text = "Catalog Search";
            
            // Container Panel
            panelList.BackColor = System.Drawing.Color.White;
            panelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelList.Location = new System.Drawing.Point(34, 80);
            panelList.Size = new System.Drawing.Size(900, 500);
            panelList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            // Search Box (Light Blue bg)
            txtSearch.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSearch.Location = new System.Drawing.Point(20, 35);
            txtSearch.Size = new System.Drawing.Size(300, 30);
            txtSearch.Text = "";
            txtSearch.PlaceholderText = "Type keywords here...";
            
            // Filter Dropdown
            cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            cmbFilter.Items.AddRange(new object[] { "By Title", "By Author", "By ISBN", "By Category", "By Year" });
            cmbFilter.SelectedIndex = 0;
            cmbFilter.Location = new System.Drawing.Point(340, 35);
            cmbFilter.Size = new System.Drawing.Size(200, 30);
            
            // lblSearchBy
            lblSearchBy.AutoSize = true;
            lblSearchBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSearchBy.ForeColor = System.Drawing.Color.Gray;
            lblSearchBy.Location = new System.Drawing.Point(340, 10);
            lblSearchBy.Text = "SELECT SEARCH CRITERIA:";
            
            // Search Button
            btnSearch.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(560, 30);
            btnSearch.Size = new System.Drawing.Size(150, 40);
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;

            // Reserve Button
            btnReserve = new System.Windows.Forms.Button();
            btnReserve.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReserve.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnReserve.ForeColor = System.Drawing.Color.White;
            btnReserve.Location = new System.Drawing.Point(720, 30);
            btnReserve.Size = new System.Drawing.Size(150, 40);
            btnReserve.Text = "Reserve Now";
            btnReserve.Click += btnReserve_Click;
            
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
            
            rowStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True; // Allows multi-line text
            dataGridView1.RowsDefaultCellStyle = rowStyle;
            
            colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            colISBN.HeaderText = "ISBN";
            colTitle.HeaderText = "Title";
            colAuthor.HeaderText = "Author";
            colCategory.HeaderText = "Category";
            colYear.HeaderText = "Year";
            colStatus.HeaderText = "Status";
            
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colISBN, colTitle, colAuthor, colCategory, colYear, colStatus });
            
            panelList.Controls.Add(txtSearch);
            panelList.Controls.Add(lblSearchBy);
            panelList.Controls.Add(cmbFilter);
            panelList.Controls.Add(btnSearch);
            panelList.Controls.Add(btnReserve);
            panelList.Controls.Add(dataGridView1);
            
            Controls.Add(labelTitle);
            Controls.Add(panelList);
            
            panelList.ResumeLayout(false);
            panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
