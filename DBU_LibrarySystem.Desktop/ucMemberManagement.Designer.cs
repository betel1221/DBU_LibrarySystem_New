namespace DBU_LibrarySystem
{
    partial class ucMemberManagement
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
            txtID = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtIDCardPath = new System.Windows.Forms.TextBox();
            cmbRole = new System.Windows.Forms.ComboBox();
            txtDepartment = new System.Windows.Forms.TextBox();
            txtOfficeNumber = new System.Windows.Forms.TextBox();
            btnBrowseID = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();

            panelList = new System.Windows.Forms.Panel();
            btnRefresh = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            
            panelCreate.SuspendLayout();
             panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            
            BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            Dock = System.Windows.Forms.DockStyle.Fill;
            AutoScroll = true;
            Font = new System.Drawing.Font("Segoe UI", 10F);
            
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelTitle.Location = new System.Drawing.Point(30, 10);
            labelTitle.Text = "Member & Registration Management";
            
            panelCreate.BackColor = System.Drawing.Color.White;
            panelCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelCreate.Location = new System.Drawing.Point(34, 60);
            panelCreate.Size = new System.Drawing.Size(900, 150);
            panelCreate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            
            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelSubtitle.Location = new System.Drawing.Point(20, 10);
            labelSubtitle.Text = "Add New Member (Direct)";
            
            cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRole.Font = new System.Drawing.Font("Segoe UI", 11F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Student", "Librarian/Employee" });
            cmbRole.Location = new System.Drawing.Point(20, 45);
            cmbRole.Size = new System.Drawing.Size(150, 28);
            cmbRole.SelectedIndex = 0;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;

            txtID.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtID.Location = new System.Drawing.Point(180, 45);
            txtID.PlaceholderText = "Student ID";
            txtID.Size = new System.Drawing.Size(150, 27);
            
            txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtName.Location = new System.Drawing.Point(340, 45);
            txtName.PlaceholderText = "Full Name";
            txtName.Size = new System.Drawing.Size(200, 27);
            
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtEmail.Location = new System.Drawing.Point(550, 45);
            txtEmail.PlaceholderText = "Student Email";
            txtEmail.Size = new System.Drawing.Size(180, 27);

            txtIDCardPath.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtIDCardPath.Location = new System.Drawing.Point(20, 85);
            txtIDCardPath.PlaceholderText = "ID Card Image Path";
            txtIDCardPath.Size = new System.Drawing.Size(310, 27);

            btnBrowseID.Location = new System.Drawing.Point(340, 85);
            btnBrowseID.Size = new System.Drawing.Size(80, 27);
            btnBrowseID.Text = "Browse...";
            btnBrowseID.Click += (s, e) => {
                using(OpenFileDialog ofd = new OpenFileDialog()) {
                    if(ofd.ShowDialog() == DialogResult.OK) txtIDCardPath.Text = ofd.FileName;
                }
            };
            
            txtDepartment.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtDepartment.Location = new System.Drawing.Point(430, 85);
            txtDepartment.PlaceholderText = "Department";
            txtDepartment.Size = new System.Drawing.Size(150, 27);
            
            txtOfficeNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtOfficeNumber.Location = new System.Drawing.Point(430, 85);
            txtOfficeNumber.PlaceholderText = "Office Number";
            txtOfficeNumber.Size = new System.Drawing.Size(150, 27);
            txtOfficeNumber.Visible = false;

            btnAdd.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(740, 45);
            btnAdd.Size = new System.Drawing.Size(140, 67);
            btnAdd.Text = "Register";
            btnAdd.Click += btnAdd_Click;
            
            panelCreate.Controls.AddRange(new System.Windows.Forms.Control[] { labelSubtitle, cmbRole, txtID, txtName, txtEmail, txtIDCardPath, btnBrowseID, txtDepartment, txtOfficeNumber, btnAdd });


            
            panelList.BackColor = System.Drawing.Color.White;
            panelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelList.Location = new System.Drawing.Point(34, 220);
            panelList.Size = new System.Drawing.Size(900, 430);
            panelList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(20, 10);
            btnRefresh.Size = new System.Drawing.Size(200, 35);
            btnRefresh.Text = "Refresh Active List";
            btnRefresh.Click += btnRefresh_Click;
            
            dataGridView1.Location = new System.Drawing.Point(20, 50);
            dataGridView1.Size = new System.Drawing.Size(860, 170);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            panelList.Controls.AddRange(new System.Windows.Forms.Control[] { btnRefresh, dataGridView1 });
            
            Controls.AddRange(new System.Windows.Forms.Control[] { labelTitle, panelCreate, panelList });
            
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Size = new System.Drawing.Size(1000, 700);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelCreate;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIDCardPath;
        private System.Windows.Forms.Button btnBrowseID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}
