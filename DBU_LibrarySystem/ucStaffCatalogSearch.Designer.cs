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
            
            cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            cmbFilter.Items.AddRange(new object[] { "By Title", "By Author", "By ISBN" });
            cmbFilter.SelectedIndex = 0;
            cmbFilter.Location = new System.Drawing.Point(350, 70);
            cmbFilter.Size = new System.Drawing.Size(200, 30);
            
            btnSearch.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(570, 65);
            btnSearch.Size = new System.Drawing.Size(200, 40);
            btnSearch.Text = "Find Books";
            btnSearch.Click += btnSearch_Click;
            
            panelSearch.Controls.Add(lblSearchTitle);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(cmbFilter);
            panelSearch.Controls.Add(btnSearch);
            
            Controls.Add(labelTitle);
            Controls.Add(panelSearch);
            
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
        private System.Windows.Forms.Button btnSearch;
    }
}
