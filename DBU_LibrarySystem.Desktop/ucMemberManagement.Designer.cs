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
            btnBrowseID = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            lblRole = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblID = new System.Windows.Forms.Label();
            lblDepartment = new System.Windows.Forms.Label();
            lblIDCard = new System.Windows.Forms.Label();

            panelList = new System.Windows.Forms.Panel();
            btnRefresh = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            
            panelCreate.SuspendLayout();
             panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            
            BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            Dock = System.Windows.Forms.DockStyle.Fill;
            AutoScroll = true;
            Font = new System.Drawing.Font("Segoe UI", 10F);
            
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.Cyan;
            labelTitle.Location = new System.Drawing.Point(30, 10);
            labelTitle.Text = "Member & Registration Management";
            
            panelCreate.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            panelCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panelCreate.Location = new System.Drawing.Point(34, 65);
            panelCreate.Size = new System.Drawing.Size(820, 320);
            panelCreate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            labelSubtitle.Text = "ADD NEW MEMBER";
            labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            labelSubtitle.Location = new System.Drawing.Point(20, 15);
            labelSubtitle.AutoSize = true;

            int col1X = 30;
            int col2X = 420;
            int startY = 70;
            int rowHeight = 90;

            // --- Column 1 ---
            // Role
            lblRole.Text = "👤 ROLE";
            lblRole.Location = new System.Drawing.Point(col1X + 5, startY - 18);
            lblRole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblRole.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            lblRole.ForeColor = System.Drawing.Color.Teal;
            cmbRole.Location = new System.Drawing.Point(col1X, startY);
            cmbRole.Size = new System.Drawing.Size(350, 35);
            cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRole.Items.Clear();
            cmbRole.Items.AddRange(new object[] { "Student", "Librarian/Employee" });
            cmbRole.SelectedIndex = 0;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;

            // Name
            lblName.Text = "📛 FULL NAME";
            lblName.Location = new System.Drawing.Point(col1X + 5, startY + rowHeight - 18);
            lblName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblName.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            lblName.ForeColor = System.Drawing.Color.Teal;
            txtName.Location = new System.Drawing.Point(col1X, startY + rowHeight);
            txtName.Size = new System.Drawing.Size(350, 35);
            txtName.PlaceholderText = "Full Name";

            // Email
            lblEmail.Text = "📧 EMAIL ADDRESS";
            lblEmail.Location = new System.Drawing.Point(col1X + 5, startY + (rowHeight * 2) - 18);
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblEmail.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            lblEmail.ForeColor = System.Drawing.Color.Teal;
            txtEmail.Location = new System.Drawing.Point(col1X, startY + (rowHeight * 2));
            txtEmail.Size = new System.Drawing.Size(350, 35);
            txtEmail.PlaceholderText = "Email Address";

            // --- Column 2 ---
            // ID
            lblID.Text = "🆔 STUDENT/STAFF ID";
            lblID.Location = new System.Drawing.Point(col2X + 5, startY - 18);
            lblID.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblID.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            lblID.ForeColor = System.Drawing.Color.Teal;
            txtID.Location = new System.Drawing.Point(col2X, startY);
            txtID.Size = new System.Drawing.Size(350, 35);
            txtID.PlaceholderText = "Member ID";

            // Department
            lblDepartment.Text = "🏢 DEPARTMENT";
            lblDepartment.Location = new System.Drawing.Point(col2X + 5, startY + rowHeight - 18);
            lblDepartment.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblDepartment.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            lblDepartment.ForeColor = System.Drawing.Color.Teal;
            txtDepartment.Location = new System.Drawing.Point(col2X, startY + rowHeight);
            txtDepartment.Size = new System.Drawing.Size(350, 35);
            txtDepartment.PlaceholderText = "Department/Faculty";

            // ID Card Path
            lblIDCard.Text = "🖼️ ID CARD IMAGE";
            lblIDCard.Location = new System.Drawing.Point(col2X + 5, startY + (rowHeight * 2) - 12);
            lblIDCard.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblIDCard.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            lblIDCard.ForeColor = System.Drawing.Color.Teal;
            txtIDCardPath.Location = new System.Drawing.Point(col2X, startY + (rowHeight * 2));
            txtIDCardPath.Size = new System.Drawing.Size(260, 35);
            txtIDCardPath.PlaceholderText = "ID Image Path";

            btnBrowseID.Text = "📁";
            btnBrowseID.Location = new System.Drawing.Point(col2X + 265, startY + (rowHeight * 2));
            btnBrowseID.Size = new System.Drawing.Size(85, 35);
            btnBrowseID.BackColor = System.Drawing.Color.Teal;
            btnBrowseID.ForeColor = System.Drawing.Color.White;
            btnBrowseID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBrowseID.FlatAppearance.BorderSize = 0;
            btnBrowseID.Click += (s, e) => {
                using(OpenFileDialog ofd = new OpenFileDialog()) {
                    if(ofd.ShowDialog() == DialogResult.OK) txtIDCardPath.Text = ofd.FileName;
                }
            };

            // Register Button
            btnAdd.Text = "REGISTER NEW MEMBER";
            btnAdd.Location = new System.Drawing.Point(col1X, 260);
            btnAdd.Size = new System.Drawing.Size(740, 45);
            btnAdd.BackColor = System.Drawing.Color.Teal;
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAdd.Click += btnAdd_Click;
            
            panelCreate.Controls.Clear();
            panelCreate.Controls.AddRange(new System.Windows.Forms.Control[] { 
                labelSubtitle, lblRole, cmbRole, lblName, txtName, lblEmail, txtEmail,
                lblID, txtID, lblDepartment, txtDepartment, lblIDCard, txtIDCardPath, btnBrowseID, btnAdd 
            });


            
            panelList.BackColor = System.Drawing.Color.FromArgb(24, 24, 26);
            panelList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panelList.Location = new System.Drawing.Point(34, 400);
            panelList.Size = new System.Drawing.Size(1250, 400);
            panelList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            
            btnRefresh.BackColor = System.Drawing.Color.Teal;
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(20, 15);
            btnRefresh.Size = new System.Drawing.Size(200, 35);
            btnRefresh.Text = "Refresh Active List";
            btnRefresh.Click += btnRefresh_Click;
            
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(24, 24, 26);
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView1.Height = 330;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            
            panelList.Controls.Clear();
            panelList.Controls.AddRange(new System.Windows.Forms.Control[] { btnRefresh, dataGridView1 });
            
            this.Controls.Clear();
            this.Controls.AddRange(new System.Windows.Forms.Control[] { labelTitle, panelCreate, panelList });
            
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Size = new System.Drawing.Size(1400, 850);
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
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button btnBrowseID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblIDCard;
    }
}
