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
            panelSearchBar = new System.Windows.Forms.Panel();
            txtSearch = new System.Windows.Forms.TextBox();
            cmbFilter = new System.Windows.Forms.ComboBox();
            btnSearch = new System.Windows.Forms.Button();
            lblSearchBy = new System.Windows.Forms.Label();
            btnReserve = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            
            // ── UserControl ──
            this.BackColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            
            // ── Title Label (Dock Top) ──
            labelTitle.AutoSize = false;
            labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            labelTitle.Height = 50;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            labelTitle.BackColor = System.Drawing.Color.Transparent;
            labelTitle.Text = "Catalog Search";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            
            // ── Container Panel (Dock Fill) ──
            panelList.BackColor = System.Drawing.Color.FromArgb(40, 42, 46);
            panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            panelList.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            
            // ── Search Bar Panel (Dock Top inside panelList) ──
            panelSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            panelSearchBar.Height = 80;
            panelSearchBar.BackColor = System.Drawing.Color.Transparent;
            panelSearchBar.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            
            // Search Box
            txtSearch.BackColor = System.Drawing.Color.FromArgb(55, 58, 62);
            txtSearch.ForeColor = System.Drawing.Color.White;
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSearch.Location = new System.Drawing.Point(5, 30);
            txtSearch.Size = new System.Drawing.Size(250, 30);
            txtSearch.PlaceholderText = "Type keywords here...";
            txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            
            // Filter Dropdown
            cmbFilter.BackColor = System.Drawing.Color.FromArgb(55, 58, 62);
            cmbFilter.ForeColor = System.Drawing.Color.White;
            cmbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFilter.Font = new System.Drawing.Font("Segoe UI", 11F);
            cmbFilter.Items.AddRange(new object[] { "By Title", "By Author", "By ISBN", "By Category", "By Year" });
            cmbFilter.SelectedIndex = 0;
            cmbFilter.Location = new System.Drawing.Point(270, 30);
            cmbFilter.Size = new System.Drawing.Size(160, 30);
            cmbFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            
            // lblSearchBy
            lblSearchBy.AutoSize = true;
            lblSearchBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSearchBy.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblSearchBy.Location = new System.Drawing.Point(270, 8);
            lblSearchBy.Text = "SELECT SEARCH CRITERIA:";
            
            // Search Button
            btnSearch.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(450, 25);
            btnSearch.Size = new System.Drawing.Size(130, 40);
            btnSearch.Text = "🔍 Search";
            btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSearch.Click += btnSearch_Click;

            // Reserve Button
            btnReserve.BackColor = System.Drawing.Color.FromArgb(0, 180, 100);
            btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReserve.FlatAppearance.BorderSize = 0;
            btnReserve.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnReserve.ForeColor = System.Drawing.Color.White;
            btnReserve.Location = new System.Drawing.Point(595, 25);
            btnReserve.Size = new System.Drawing.Size(150, 40);
            btnReserve.Text = "📋 Reserve Now";
            btnReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            btnReserve.Click += btnReserve_Click;
            
            // ── DataGridView (Dock Fill inside panelList) ──
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(32, 33, 36);
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(60, 64, 67);
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            
            // Header style
            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            cellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            dataGridView1.ColumnHeadersDefaultCellStyle = cellStyle;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;
            
            // Row style
            rowStyle.BackColor = System.Drawing.Color.FromArgb(32, 33, 36);
            rowStyle.ForeColor = System.Drawing.Color.White;
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            rowStyle.SelectionForeColor = System.Drawing.Color.White;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = rowStyle;
            
            // Columns with tuned FillWeights
            colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            colISBN.HeaderText = "ISBN";
            colISBN.Name = "ISBN";
            colISBN.FillWeight = 18;
            
            colTitle.HeaderText = "Title";
            colTitle.Name = "Title";
            colTitle.FillWeight = 25;
            
            colAuthor.HeaderText = "Author";
            colAuthor.Name = "Author";
            colAuthor.FillWeight = 18;
            
            colCategory.HeaderText = "Category";
            colCategory.Name = "Category";
            colCategory.FillWeight = 14;
            
            colYear.HeaderText = "Year";
            colYear.Name = "Year";
            colYear.FillWeight = 8;
            
            colStatus.HeaderText = "Availability";
            colStatus.Name = "Status";
            colStatus.FillWeight = 17;
            
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colISBN, colTitle, colAuthor, colCategory, colYear, colStatus });
            
            // ── Assemble Controls ──
            // Search bar children
            panelSearchBar.Controls.Add(btnReserve);
            panelSearchBar.Controls.Add(btnSearch);
            panelSearchBar.Controls.Add(lblSearchBy);
            panelSearchBar.Controls.Add(cmbFilter);
            panelSearchBar.Controls.Add(txtSearch);
            
            // panelList: grid fills, search bar docks top
            panelList.Controls.Add(dataGridView1);
            panelList.Controls.Add(panelSearchBar);
            
            // Main: panelList fills, title docks top
            Controls.Add(panelList);
            Controls.Add(labelTitle);
            
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Panel panelSearchBar;
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
