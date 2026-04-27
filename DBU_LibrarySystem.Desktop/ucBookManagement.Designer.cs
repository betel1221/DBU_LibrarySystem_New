namespace DBU_LibrarySystem
{
    partial class ucBookManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            labelTitle = new Label();
            panelCreate = new Panel();
            labelSubtitle = new Label();
            txtISBN = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            cmbFaculty = new ComboBox();
            cmbSubject = new ComboBox();
            txtYear = new TextBox();
            txtQty = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            lblISBN = new Label();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblFaculty = new Label();
            lblSubject = new Label();
            lblYear = new Label();
            lblQty = new Label();
            panelList = new Panel();
            btnRefresh = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            colISBN = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            panelCreate.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            // labelTitle
            // labelTitle
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Cyan;
            labelTitle.Location = new Point(30, 10);
            labelTitle.Text = "Book Inventory Management";

            // panelCreate (Sleek Dashboard Card)
            panelCreate.BackColor = Color.FromArgb(24, 24, 26);
            panelCreate.Location = new Point(34, 65);
            panelCreate.Size = new Size(820, 380);
            panelCreate.BorderStyle = BorderStyle.None;
            panelCreate.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            panelCreate.TabIndex = 1;
            // 
            // labelSubtitle
            // 
            labelSubtitle.Text = "ADD NEW BOOK";
            labelSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelSubtitle.ForeColor = Color.FromArgb(100, 100, 100);
            labelSubtitle.Location = new Point(20, 15);
            labelSubtitle.AutoSize = true;

            int col1X = 30;
            int col2X = 420;
            int startY = 70;
            int rowHeight = 90;

            // --- Column 1 ---
            // ISBN
            lblISBN.Text = "🔢 ISBN";
            lblISBN.Location = new Point(col1X + 5, startY - 18);
            lblISBN.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblISBN.BackColor = Color.FromArgb(24, 24, 26);
            lblISBN.ForeColor = Color.Teal;
            txtISBN.Location = new Point(col1X, startY);
            txtISBN.Size = new Size(350, 35);
            txtISBN.PlaceholderText = "Enter ISBN";

            // Title
            lblTitle.Text = "📖 BOOK TITLE";
            lblTitle.Location = new Point(col1X + 5, startY + rowHeight - 18);
            lblTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTitle.BackColor = Color.FromArgb(24, 24, 26);
            lblTitle.ForeColor = Color.Teal;
            txtTitle.Location = new Point(col1X, startY + rowHeight);
            txtTitle.Size = new Size(350, 35);
            txtTitle.PlaceholderText = "Full Book Title";

            // Author
            lblAuthor.Text = "✍️ AUTHOR";
            lblAuthor.Location = new Point(col1X + 5, startY + (rowHeight * 2) - 18);
            lblAuthor.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblAuthor.BackColor = Color.FromArgb(24, 24, 26);
            lblAuthor.ForeColor = Color.Teal;
            txtAuthor.Location = new Point(col1X, startY + (rowHeight * 2));
            txtAuthor.Size = new Size(350, 35);
            txtAuthor.PlaceholderText = "Author Name";

            // --- Column 2 ---
            // Faculty
            lblFaculty.Text = "🏫 FACULTY";
            lblFaculty.Location = new Point(col2X + 5, startY - 18);
            lblFaculty.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblFaculty.BackColor = Color.FromArgb(24, 24, 26);
            lblFaculty.ForeColor = Color.Teal;
            cmbFaculty.Location = new Point(col2X, startY);
            cmbFaculty.Size = new Size(350, 35);
            cmbFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFaculty.SelectedIndexChanged += cmbFaculty_SelectedIndexChanged;

            // Subject
            lblSubject.Text = "📘 SUBJECT";
            lblSubject.Location = new Point(col2X + 5, startY + rowHeight - 18);
            lblSubject.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSubject.BackColor = Color.FromArgb(24, 24, 26);
            lblSubject.ForeColor = Color.Teal;
            cmbSubject.Location = new Point(col2X, startY + rowHeight);
            cmbSubject.Size = new Size(350, 35);
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;

            // Year & Qty (Shared Row)
            lblYear.Text = "📅 YEAR";
            lblYear.Location = new Point(col2X + 5, startY + (rowHeight * 2) - 18);
            lblYear.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblYear.BackColor = Color.FromArgb(24, 24, 26);
            lblYear.ForeColor = Color.Teal;
            txtYear.Location = new Point(col2X, startY + (rowHeight * 2));
            txtYear.Size = new Size(165, 35);
            txtYear.PlaceholderText = "Year";

            lblQty.Text = "📦 QTY";
            lblQty.Location = new Point(col2X + 190, startY + (rowHeight * 2) - 18);
            lblQty.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblQty.BackColor = Color.FromArgb(24, 24, 26);
            lblQty.ForeColor = Color.Teal;
            txtQty.Location = new Point(col2X + 185, startY + (rowHeight * 2));
            txtQty.Size = new Size(165, 35);
            txtQty.PlaceholderText = "Qty";

            // Add Button (Large Teal)
            btnAdd.Text = "SAVE BOOK TO INVENTORY";
            btnAdd.Location = new Point(col1X, 310);
            btnAdd.Size = new Size(740, 45);
            btnAdd.BackColor = Color.Teal;
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Click += btnAdd_Click;
            
            btnClear.Visible = false; 

            panelCreate.Controls.Clear();
            panelCreate.Controls.AddRange(new Control[] { 
                labelSubtitle,
                lblISBN, txtISBN, lblTitle, txtTitle, lblAuthor, txtAuthor,
                lblFaculty, cmbFaculty, lblSubject, cmbSubject,
                lblYear, txtYear, lblQty, txtQty, btnAdd 
            });
            // List Panel Adjustment
            panelList.Location = new Point(34, 480);
            panelList.Size = new Size(1250, 350);
            panelList.BackColor = Color.FromArgb(24, 24, 26);
            panelList.BorderStyle = BorderStyle.None;
            panelList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelList.Controls.Clear();
            panelList.Controls.AddRange(new Control[] { btnRefresh, lblSearch, txtSearch, dataGridView1 });

            btnRefresh.BackColor = Color.Teal;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Location = new Point(20, 15);
            btnRefresh.Size = new Size(120, 35);
            btnRefresh.Click += btnRefresh_Click;

            lblSearch.ForeColor = Color.LightGray;
            lblSearch.Location = new Point(160, 20);
            lblSearch.Text = "Quick Search:";

            txtSearch.BackColor = Color.FromArgb(30, 30, 32);
            txtSearch.ForeColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(260, 18);
            txtSearch.Size = new Size(300, 25);
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(44, 127, 184);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(20, 15);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 35);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh List";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(160, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(91, 19);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Quick Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(260, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search ISBN or Title...";
            txtSearch.Size = new Size(250, 25);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colISBN, colTitle, colAuthor, colCategory, colYear, colQty, colEdit, colDelete });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(10, 60);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(2203, 667);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colISBN
            // 
            colISBN.HeaderText = "ISBN";
            colISBN.Name = "colISBN";
            // 
            // colTitle
            // 
            colTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTitle.HeaderText = "Book Title";
            colTitle.Name = "colTitle";
            // 
            // colAuthor
            // 
            colAuthor.HeaderText = "Author";
            colAuthor.Name = "colAuthor";
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            // 
            // colYear
            // 
            colYear.HeaderText = "Year";
            colYear.Name = "colYear";
            // 
            // colQty
            // 
            colQty.HeaderText = "Qty";
            colQty.Name = "colQty";
            // 
            // colEdit
            // 
            colEdit.FlatStyle = FlatStyle.Flat;
            colEdit.HeaderText = "✏️";
            colEdit.Name = "colEdit";
            colEdit.Text = "✏️";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.FlatStyle = FlatStyle.Flat;
            colDelete.HeaderText = "🗑️";
            colDelete.Name = "colDelete";
            colDelete.Text = "🗑️";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // ucBookManagement
            // 
            BackColor = Color.FromArgb(240, 242, 245);
            Controls.Add(labelTitle);
            Controls.Add(panelCreate);
            Controls.Add(panelList);
            Font = new Font("Segoe UI", 10F);
            Name = "ucBookManagement";
            Size = new Size(1325, 419);
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            panelList.ResumeLayout(false);
            panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelCreate;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblQty;
    }
}
