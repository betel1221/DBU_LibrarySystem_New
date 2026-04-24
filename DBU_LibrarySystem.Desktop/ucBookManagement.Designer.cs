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
            cmbCategory = new ComboBox();
            txtYear = new TextBox();
            txtQty = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
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
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(44, 127, 184);
            labelTitle.Location = new Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(230, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Book Management";
            // 
            // panelCreate
            // 
            panelCreate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCreate.BackColor = Color.White;
            panelCreate.BorderStyle = BorderStyle.FixedSingle;
            panelCreate.Controls.Add(labelSubtitle);
            panelCreate.Controls.Add(txtISBN);
            panelCreate.Controls.Add(txtTitle);
            panelCreate.Controls.Add(txtAuthor);
            panelCreate.Controls.Add(cmbCategory);
            panelCreate.Controls.Add(txtYear);
            panelCreate.Controls.Add(txtQty);
            panelCreate.Controls.Add(btnAdd);
            panelCreate.Controls.Add(btnClear);
            panelCreate.Location = new Point(34, 80);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(2155, 200);
            panelCreate.TabIndex = 1;
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelSubtitle.ForeColor = Color.FromArgb(44, 127, 184);
            labelSubtitle.Location = new Point(20, 15);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(123, 21);
            labelSubtitle.TabIndex = 0;
            labelSubtitle.Text = "Add New Book";
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Segoe UI", 12F);
            txtISBN.Location = new Point(20, 50);
            txtISBN.Name = "txtISBN";
            txtISBN.PlaceholderText = "ISBN";
            txtISBN.Size = new Size(150, 29);
            txtISBN.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F);
            txtTitle.Location = new Point(190, 50);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(300, 29);
            txtTitle.TabIndex = 2;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 12F);
            txtAuthor.Location = new Point(510, 50);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.PlaceholderText = "Author";
            txtAuthor.Size = new Size(180, 29);
            txtAuthor.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 12F);
            cmbCategory.Items.AddRange(new object[] { "Programming", "Science", "Literature", "Mathematics", "Engineering", "Other" });
            cmbCategory.Location = new Point(710, 50);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(150, 29);
            cmbCategory.TabIndex = 4;
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Segoe UI", 12F);
            txtYear.Location = new Point(20, 100);
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = "Year";
            txtYear.Size = new Size(100, 29);
            txtYear.TabIndex = 5;
            // 
            // txtQty
            // 
            txtQty.Font = new Font("Segoe UI", 12F);
            txtQty.Location = new Point(140, 100);
            txtQty.Name = "txtQty";
            txtQty.PlaceholderText = "Qty";
            txtQty.Size = new Size(100, 29);
            txtQty.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(44, 127, 184);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(260, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 40);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Save Book";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(108, 117, 125);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(480, 100);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(200, 40);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panelList
            // 
            panelList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelList.BackColor = Color.White;
            panelList.BorderStyle = BorderStyle.FixedSingle;
            panelList.Controls.Add(btnRefresh);
            panelList.Controls.Add(lblSearch);
            panelList.Controls.Add(txtSearch);
            panelList.Controls.Add(dataGridView1);
            panelList.Location = new Point(34, 300);
            panelList.Name = "panelList";
            panelList.Padding = new Padding(10, 60, 10, 10);
            panelList.Size = new Size(2225, 739);
            panelList.TabIndex = 2;
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
        private System.Windows.Forms.ComboBox cmbCategory;
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
    }
}
