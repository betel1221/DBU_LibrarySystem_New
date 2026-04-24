namespace DBU_LibrarySystem
{
    partial class ucUserAuthentication
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
            lblNote = new System.Windows.Forms.Label();
            panelCreate = new System.Windows.Forms.Panel();
            lblCreateTitle = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            cmbRole = new System.Windows.Forms.ComboBox();
            btnCreate = new System.Windows.Forms.Button();
            panelList = new System.Windows.Forms.Panel();
            btnRefresh = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            panelCreate.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            
            // ucUserAuthentication
            BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            Dock = System.Windows.Forms.DockStyle.Fill;
            Font = new System.Drawing.Font("Segoe UI", 10F);
            
            // labelTitle
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelTitle.Location = new System.Drawing.Point(30, 20);
            labelTitle.Text = "User Authentication Management";
            
            // lblNote
            lblNote.AutoSize = true;
            lblNote.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            lblNote.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            lblNote.Location = new System.Drawing.Point(30, 65);
            lblNote.Text = "Note: Use this section to create Login Accounts so Students and Employees can log in to their portals. For students, the Username must match their Member ID.";
            
            // panelCreate
            panelCreate.BackColor = System.Drawing.Color.White;
            panelCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelCreate.Location = new System.Drawing.Point(34, 120);
            panelCreate.Size = new System.Drawing.Size(900, 160);
            panelCreate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            
            // lblCreateTitle
            lblCreateTitle.AutoSize = true;
            lblCreateTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblCreateTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblCreateTitle.Location = new System.Drawing.Point(20, 15);
            lblCreateTitle.Text = "Create Login Account";
            
            // txtUsername
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtUsername.Location = new System.Drawing.Point(20, 50);
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new System.Drawing.Size(250, 30);
            
            // txtPassword
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtPassword.Location = new System.Drawing.Point(290, 50);
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new System.Drawing.Size(250, 30);
            
            // cmbRole
            cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Employee", "Student" });
            cmbRole.Location = new System.Drawing.Point(560, 50);
            cmbRole.Size = new System.Drawing.Size(250, 30);
            cmbRole.SelectedIndex = 0;
            
            // btnCreate
            btnCreate.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnCreate.ForeColor = System.Drawing.Color.White;
            btnCreate.Location = new System.Drawing.Point(20, 100);
            btnCreate.Size = new System.Drawing.Size(250, 40);
            btnCreate.Text = "Create Account";
            btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCreate.Click += btnCreate_Click;
            
            panelCreate.Controls.Add(lblCreateTitle);
            panelCreate.Controls.Add(txtUsername);
            panelCreate.Controls.Add(txtPassword);
            panelCreate.Controls.Add(cmbRole);
            panelCreate.Controls.Add(btnCreate);
            
            // panelList
            panelList.BackColor = System.Drawing.Color.White;
            panelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelList.Location = new System.Drawing.Point(34, 300);
            panelList.Size = new System.Drawing.Size(900, 300);
            panelList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            // btnRefresh
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(20, 15);
            btnRefresh.Size = new System.Drawing.Size(200, 40);
            btnRefresh.Text = "Refresh User List";
            btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefresh.Click += btnRefresh_Click;
            
            // dataGridView1
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
            dataGridView1.Size = new System.Drawing.Size(860, 210);
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            colID.HeaderText = "ID";
            colUsername.HeaderText = "Username";
            colRole.HeaderText = "Role";
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colID, colUsername, colRole });
            
            panelList.Controls.Add(btnRefresh);
            panelList.Controls.Add(dataGridView1);
            
            // Add Controls
            Controls.Add(labelTitle);
            Controls.Add(lblNote);
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
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Panel panelCreate;
        private System.Windows.Forms.Label lblCreateTitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
    }
}
