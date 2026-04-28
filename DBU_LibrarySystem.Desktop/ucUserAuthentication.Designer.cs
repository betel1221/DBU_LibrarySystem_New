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
            labelTitle = new System.Windows.Forms.Label();
            panelCreate = new System.Windows.Forms.Panel();
            labelSubtitle = new System.Windows.Forms.Label();
            txtMemberID = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            cmbRole = new System.Windows.Forms.ComboBox();
            btnCreate = new System.Windows.Forms.Button();
            
            lblMemberID = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            lblRole = new System.Windows.Forms.Label();

            panelList = new System.Windows.Forms.Panel();
            btnRefresh = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();

            panelCreate.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // Main Control
            BackColor = System.Drawing.Color.FromArgb(0, 150, 255);
            this.Size = new System.Drawing.Size(1400, 1000);

            // labelTitle
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelTitle.Location = new System.Drawing.Point(30, 10);
            labelTitle.Text = "User Account & Authentication Management";

            // panelCreate (Premium Dashboard Card)
            panelCreate.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            panelCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panelCreate.Location = new System.Drawing.Point(34, 65);
            panelCreate.Size = new System.Drawing.Size(820, 320);
            panelCreate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            // labelSubtitle
            labelSubtitle.Text = "CREATE OR UPDATE LOGIN ACCOUNT";
            labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            labelSubtitle.Location = new System.Drawing.Point(20, 15);
            labelSubtitle.AutoSize = true;

            int col1X = 30;
            int col2X = 420;
            int startY = 70;
            int rowHeight = 90;

            // --- Column 1 ---
            lblMemberID.Text = "MEMBER ID";
            lblMemberID.Location = new System.Drawing.Point(col1X, startY - 25);
            lblMemberID.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblMemberID.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            lblMemberID.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblMemberID.AutoSize = true;
            
            txtMemberID.Location = new System.Drawing.Point(col1X, startY);
            txtMemberID.Size = new System.Drawing.Size(350, 35);
            txtMemberID.PlaceholderText = "Search/Enter Member ID";
            txtMemberID.BackColor = Color.FromArgb(45, 45, 48);
            txtMemberID.ForeColor = System.Drawing.Color.White;
            txtMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            lblPassword.Text = "PASSWORD";
            lblPassword.Location = new System.Drawing.Point(col1X, startY + rowHeight - 25);
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblPassword.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblPassword.AutoSize = true;

            txtPassword.Location = new System.Drawing.Point(col1X, startY + rowHeight);
            txtPassword.Size = new System.Drawing.Size(350, 35);
            txtPassword.PlaceholderText = "Enter Secure Password";
            txtPassword.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            txtPassword.ForeColor = System.Drawing.Color.White;
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.UseSystemPasswordChar = true;

            // --- Column 2 ---
            lblRole.Text = "USER ROLE";
            lblRole.Location = new System.Drawing.Point(col2X, startY - 25);
            lblRole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblRole.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            lblRole.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            lblRole.AutoSize = true;

            cmbRole.Location = new System.Drawing.Point(col2X, startY);
            cmbRole.Size = new System.Drawing.Size(350, 35);
            cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRole.BackColor = Color.FromArgb(45, 45, 48);
            cmbRole.ForeColor = System.Drawing.Color.White;
            cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbRole.Items.Clear();
            cmbRole.Items.AddRange(new object[] { "Employee", "Student" });
            cmbRole.SelectedIndex = 0;

            // Create Button (Large Teal)
            btnCreate.Text = "CONFIRM AND CREATE ACCOUNT";
            btnCreate.Location = new System.Drawing.Point(col1X, 220);
            btnCreate.Size = new System.Drawing.Size(740, 45);
            btnCreate.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnCreate.ForeColor = System.Drawing.Color.White;
            btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCreate.Click += btnCreate_Click;

            panelCreate.Controls.AddRange(new System.Windows.Forms.Control[] { 
                labelSubtitle, lblMemberID, txtMemberID, lblPassword, txtPassword, lblRole, cmbRole, btnCreate 
            });

            // List Panel
            panelList.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            panelList.Location = new System.Drawing.Point(34, 420);
            panelList.Size = new System.Drawing.Size(1250, 500);
            panelList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(20, 15);
            btnRefresh.Size = new System.Drawing.Size(200, 35);
            btnRefresh.Text = "Refresh User List";
            btnRefresh.Click += btnRefresh_Click;
            
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(24, 24, 26);
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.Location = new System.Drawing.Point(10, 60);
            dataGridView1.Size = new System.Drawing.Size(1230, 420);
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            
            panelList.Controls.AddRange(new System.Windows.Forms.Control[] { btnRefresh, dataGridView1 });

            this.Controls.Clear();
            this.Controls.AddRange(new System.Windows.Forms.Control[] { labelTitle, panelCreate, panelList });

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
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
    }
}
