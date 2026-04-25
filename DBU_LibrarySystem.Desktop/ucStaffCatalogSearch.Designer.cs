namespace DBU_LibrarySystem
{
    partial class ucStaffCatalogSearch
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
            
            panelSearch = new System.Windows.Forms.Panel();
            lblSearchTitle = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            cmbFilter = new System.Windows.Forms.ComboBox();
            btnSearch = new System.Windows.Forms.Button();
            btnIssue = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAvailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            panelSearch.SuspendLayout();
            SuspendLayout();
            
            BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            Dock = System.Windows.Forms.DockStyle.Fill;
            Font = new System.Drawing.Font("Segoe UI", 10F);
            
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelTitle.Location = new System.Drawing.Point(30, 20);
            labelTitle.Text = "Catalog Search";
            
            // SEARCH PANEL
            panelSearch.BackColor = System.Drawing.Color.White;
            panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelSearch.Location = new System.Drawing.Point(34, 80);
            panelSearch.Size = new System.Drawing.Size(900, 200);
            panelSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            
            lblSearchTitle.AutoSize = true;
            lblSearchTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblSearchTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblSearchTitle.Location = new System.Drawing.Point(30, 20);
            lblSearchTitle.Text = "Catalog Search";
            
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSearch.Location = new System.Drawing.Point(30, 70);
            txtSearch.PlaceholderText = "Search title or author...";
            txtSearch.Size = new System.Drawing.Size(300, 30);
            
            cmbFilter.Items.AddRange(new object[] { "By Title", "By Author", "By ISBN", "By Category", "By Year" });
            cmbFilter.SelectedIndex = 0;
            cmbFilter.Location = new System.Drawing.Point(350, 70);
            cmbFilter.Size = new System.Drawing.Size(200, 30);
            
            lblSearchBy = new System.Windows.Forms.Label();
            lblSearchBy.AutoSize = true;
            lblSearchBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSearchBy.ForeColor = System.Drawing.Color.Gray;
            lblSearchBy.Location = new System.Drawing.Point(350, 50);
            lblSearchBy.Text = "SELECT SEARCH CRITERIA:";
            
            btnSearch.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(570, 65);
            btnSearch.Size = new System.Drawing.Size(200, 40);
            btnSearch.Text = "Find Books";
            btnSearch.Click += btnSearch_Click;
            
            btnIssue.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIssue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnIssue.ForeColor = System.Drawing.Color.White;
            btnIssue.Location = new System.Drawing.Point(570, 115);
            btnIssue.Size = new System.Drawing.Size(200, 40);
            btnIssue.Text = "Issue Book";
            btnIssue.Click += btnIssue_Click;
            
            panelSearch.Controls.Add(lblSearchTitle);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(lblSearchBy);
            panelSearch.Controls.Add(cmbFilter);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(btnIssue);
            
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.Location = new System.Drawing.Point(34, 300);
            dataGridView1.Size = new System.Drawing.Size(830, 300);
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            colISBN.HeaderText = "ISBN";
            colISBN.MinimumWidth = 100;
            colISBN.FillWeight = 100;
            
            colTitle.HeaderText = "Title";
            colTitle.MinimumWidth = 200;
            colTitle.FillWeight = 250;
            
            colAuthor.HeaderText = "Author";
            colAuthor.MinimumWidth = 150;
            colAuthor.FillWeight = 150;
            
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 120;
            colCategory.FillWeight = 120;
            
            colAvailability.HeaderText = "Availability Status";
            colAvailability.MinimumWidth = 150;
            colAvailability.FillWeight = 150;
            
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colISBN, colTitle, colAuthor, colCategory, colAvailability });
            
            Controls.Add(labelTitle);
            Controls.Add(panelSearch);
            Controls.Add(dataGridView1);
            
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailability;
    }
}
