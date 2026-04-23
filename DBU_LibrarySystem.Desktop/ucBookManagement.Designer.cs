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
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            labelTitle = new System.Windows.Forms.Label();
            panelCreate = new System.Windows.Forms.Panel();
            labelSubtitle = new System.Windows.Forms.Label();
            txtISBN = new System.Windows.Forms.TextBox();
            txtTitle = new System.Windows.Forms.TextBox();
            txtAuthor = new System.Windows.Forms.TextBox();
            txtQty = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            panelList = new System.Windows.Forms.Panel();
            btnRefresh = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            panelCreate.SuspendLayout();
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
            labelTitle.Text = "Book Management";
            
            panelCreate.BackColor = System.Drawing.Color.White;
            panelCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelCreate.Location = new System.Drawing.Point(34, 80);
            panelCreate.Size = new System.Drawing.Size(900, 160);
            panelCreate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            
            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelSubtitle.Location = new System.Drawing.Point(20, 15);
            labelSubtitle.Text = "Add New Book";
            
            txtISBN.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtISBN.Location = new System.Drawing.Point(20, 50);
            txtISBN.PlaceholderText = "ISBN";
            txtISBN.Size = new System.Drawing.Size(150, 30);
            
            txtTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtTitle.Location = new System.Drawing.Point(190, 50);
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new System.Drawing.Size(300, 30);
            
            txtAuthor.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtAuthor.Location = new System.Drawing.Point(510, 50);
            txtAuthor.PlaceholderText = "Author";
            txtAuthor.Size = new System.Drawing.Size(200, 30);

            txtQty.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtQty.Location = new System.Drawing.Point(730, 50);
            txtQty.PlaceholderText = "Qty";
            txtQty.Size = new System.Drawing.Size(100, 30);
            
            btnAdd.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(20, 100);
            btnAdd.Size = new System.Drawing.Size(250, 40);
            btnAdd.Text = "Add Book";
            
            panelCreate.Controls.Add(labelSubtitle);
            panelCreate.Controls.Add(txtISBN);
            panelCreate.Controls.Add(txtTitle);
            panelCreate.Controls.Add(txtAuthor);
            panelCreate.Controls.Add(txtQty);
            panelCreate.Controls.Add(btnAdd);
            
            panelList.BackColor = System.Drawing.Color.White;
            panelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelList.Location = new System.Drawing.Point(34, 260);
            panelList.Size = new System.Drawing.Size(900, 340);
            panelList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(20, 15);
            btnRefresh.Size = new System.Drawing.Size(200, 40);
            btnRefresh.Text = "Refresh List";
            
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
            dataGridView1.Location = new System.Drawing.Point(20, 70);
            dataGridView1.Size = new System.Drawing.Size(860, 250);
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            colISBN.HeaderText = "ISBN";
            colTitle.HeaderText = "Book Title";
            colAuthor.HeaderText = "Author";
            colQty.HeaderText = "Quantity Available";
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colISBN, colTitle, colAuthor, colQty });
            
            panelList.Controls.Add(btnRefresh);
            panelList.Controls.Add(dataGridView1);
            
            Controls.Add(labelTitle);
            Controls.Add(panelCreate);
            Controls.Add(panelList);
            
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            panelList.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
    }
}
