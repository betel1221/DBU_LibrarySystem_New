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
            btnBrowseID = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            panelApproval = new System.Windows.Forms.Panel();
            labelApprove = new System.Windows.Forms.Label();
            dataGridViewPending = new System.Windows.Forms.DataGridView();
            btnApprove = new System.Windows.Forms.Button();
            btnViewID = new System.Windows.Forms.Button();
            panelList = new System.Windows.Forms.Panel();
            btnRefresh = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            
            panelCreate.SuspendLayout();
            panelApproval.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPending).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            
            BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            Dock = System.Windows.Forms.DockStyle.Fill;
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
            
            txtID.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtID.Location = new System.Drawing.Point(20, 45);
            txtID.PlaceholderText = "Member ID";
            txtID.Size = new System.Drawing.Size(150, 27);
            
            txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtName.Location = new System.Drawing.Point(180, 45);
            txtName.PlaceholderText = "Full Name";
            txtName.Size = new System.Drawing.Size(250, 27);
            
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtEmail.Location = new System.Drawing.Point(440, 45);
            txtEmail.PlaceholderText = "Contact / Email";
            txtEmail.Size = new System.Drawing.Size(200, 27);

            txtIDCardPath.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtIDCardPath.Location = new System.Drawing.Point(20, 85);
            txtIDCardPath.PlaceholderText = "ID Card Image Path";
            txtIDCardPath.Size = new System.Drawing.Size(410, 27);

            btnBrowseID.Location = new System.Drawing.Point(440, 85);
            btnBrowseID.Size = new System.Drawing.Size(80, 27);
            btnBrowseID.Text = "Browse...";
            btnBrowseID.Click += (s, e) => {
                using(OpenFileDialog ofd = new OpenFileDialog()) {
                    if(ofd.ShowDialog() == DialogResult.OK) txtIDCardPath.Text = ofd.FileName;
                }
            };
            
            btnAdd.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(660, 45);
            btnAdd.Size = new System.Drawing.Size(200, 70);
            btnAdd.Text = "Register Member";
            btnAdd.Click += btnAdd_Click;
            
            panelCreate.Controls.AddRange(new System.Windows.Forms.Control[] { labelSubtitle, txtID, txtName, txtEmail, txtIDCardPath, btnBrowseID, btnAdd });

            // Approval Panel
            panelApproval.BackColor = System.Drawing.Color.White;
            panelApproval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelApproval.Location = new System.Drawing.Point(34, 220);
            panelApproval.Size = new System.Drawing.Size(900, 180);
            panelApproval.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            labelApprove.AutoSize = true;
            labelApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            labelApprove.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            labelApprove.Location = new System.Drawing.Point(20, 10);
            labelApprove.Text = "Pending Registration Approvals";

            dataGridViewPending.Location = new System.Drawing.Point(20, 40);
            dataGridViewPending.Size = new System.Drawing.Size(650, 120);
            dataGridViewPending.AllowUserToAddRows = false;
            dataGridViewPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPending.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;

            btnViewID.Location = new System.Drawing.Point(685, 40);
            btnViewID.Size = new System.Drawing.Size(180, 40);
            btnViewID.Text = "View ID Card";
            btnViewID.Click += btnViewID_Click;

            btnApprove.BackColor = System.Drawing.Color.FromArgb(46, 213, 115);
            btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnApprove.ForeColor = System.Drawing.Color.White;
            btnApprove.Location = new System.Drawing.Point(685, 90);
            btnApprove.Size = new System.Drawing.Size(180, 70);
            btnApprove.Text = "APPROVE";
            btnApprove.Click += btnApprove_Click;

            panelApproval.Controls.AddRange(new System.Windows.Forms.Control[] { labelApprove, dataGridViewPending, btnViewID, btnApprove });
            
            panelList.BackColor = System.Drawing.Color.White;
            panelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelList.Location = new System.Drawing.Point(34, 410);
            panelList.Size = new System.Drawing.Size(900, 240);
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
            
            Controls.AddRange(new System.Windows.Forms.Control[] { labelTitle, panelCreate, panelApproval, panelList });
            
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            panelApproval.ResumeLayout(false);
            panelApproval.PerformLayout();
            panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPending).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private System.Windows.Forms.Panel panelApproval;
        private System.Windows.Forms.Label labelApprove;
        private System.Windows.Forms.DataGridView dataGridViewPending;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnViewID;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelCreate;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    }
}
