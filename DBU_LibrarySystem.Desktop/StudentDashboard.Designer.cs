namespace DBU_LibrarySystem
{
    partial class StudentDashboard
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
            panel1 = new System.Windows.Forms.Panel();
            btnLogout = new System.Windows.Forms.Button();
            lblWelcome = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            
            // Wrapping panel to make sidebar look rounded/floating like the image
            panelSidebarContainer = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            panelContainer = new System.Windows.Forms.Panel();
            
            panel1.SuspendLayout();
            panelSidebarContainer.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            
            // panel1 (Top Bar)
            panel1.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Size = new System.Drawing.Size(1200, 60);
            
            // btnLogout
            btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.ForeColor = System.Drawing.Color.White;
            btnLogout.Location = new System.Drawing.Point(1090, 15);
            btnLogout.Size = new System.Drawing.Size(85, 30);
            btnLogout.Text = "Logout";
            btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogout.Click += btnLogout_Click;
            
            // lblWelcome
            lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = System.Drawing.Color.White;
            lblWelcome.Location = new System.Drawing.Point(920, 20);
            lblWelcome.Size = new System.Drawing.Size(140, 20);
            lblWelcome.Text = "Welcome, Student";
            
            // label1
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(20, 15);
            label1.Text = "DBU Library | Student Portal";
            
            // panelSidebarContainer (To give floating card effect on gray bg)
            panelSidebarContainer.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            panelSidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            panelSidebarContainer.Size = new System.Drawing.Size(300, 640);
            panelSidebarContainer.Padding = new System.Windows.Forms.Padding(30, 40, 30, 40);
            panelSidebarContainer.Controls.Add(panel2);
            
            // panel2 (Actual Buttons container)
            panel2.BackColor = System.Drawing.Color.White;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Simulating small drop shadow border
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Size = new System.Drawing.Size(240, 150);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            
            // button1
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 11F);
            button1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button1.Location = new System.Drawing.Point(10, 20);
            button1.Size = new System.Drawing.Size(220, 45);
            button1.Text = "🕙 My History";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Click += button1_Click;
            
            // button2
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Segoe UI", 11F);
            button2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button2.Location = new System.Drawing.Point(10, 75);
            button2.Size = new System.Drawing.Size(220, 45);
            button2.Text = "🔍 Search Catalog";
            button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button2.Click += button2_Click;
            
            // panelContainer
            panelContainer.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContainer.Location = new System.Drawing.Point(300, 60);
            
            // StudentDashboard
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 700);
            Controls.Add(panelContainer);
            Controls.Add(panelSidebarContainer);
            Controls.Add(panel1);
            Name = "StudentDashboard";
            Text = "DBU Library - Student Portal";
            
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panelSidebarContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSidebarContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelContainer;
    }
}
