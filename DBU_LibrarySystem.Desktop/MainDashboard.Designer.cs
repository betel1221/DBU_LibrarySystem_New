namespace DBU_LibrarySystem
{
    partial class MainDashboard
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
            panel2 = new System.Windows.Forms.Panel();
            button6 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            panelContainer = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1200, 60);
            // 
            // btnLogout
            // 
            btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.ForeColor = System.Drawing.Color.White;
            btnLogout.Location = new System.Drawing.Point(1090, 15);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(85, 30);
            btnLogout.Text = "Logout";
            btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = System.Drawing.Color.White;
            lblWelcome.Location = new System.Drawing.Point(920, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(140, 20);
            lblWelcome.Text = "Welcome, Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(20, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(280, 25);
            label1.Text = "DBU Library | Admin Console";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(260, 640);
            // 
            // button1
            // 
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 11F);
            button1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button1.Location = new System.Drawing.Point(10, 40);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(240, 45);
            button1.Text = "📚 Book Management";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Segoe UI", 11F);
            button2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button2.Location = new System.Drawing.Point(10, 95);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(240, 45);
            button2.Text = "🤝 Member Management";
            button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = System.Windows.Forms.Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Segoe UI", 11F);
            button3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button3.Location = new System.Drawing.Point(10, 150);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(240, 45);
            button3.Text = "👤 User Management";
            button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Cursor = System.Windows.Forms.Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Font = new System.Drawing.Font("Segoe UI", 11F);
            button4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button4.Location = new System.Drawing.Point(10, 205);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(240, 45);
            button4.Text = "🔄 Borrow / Return";
            button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Cursor = System.Windows.Forms.Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.Font = new System.Drawing.Font("Segoe UI", 11F);
            button5.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button5.Location = new System.Drawing.Point(10, 260);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(240, 45);
            button5.Text = "📊 Reports";
            button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Cursor = System.Windows.Forms.Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button6.Font = new System.Drawing.Font("Segoe UI", 11F);
            button6.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button6.Location = new System.Drawing.Point(10, 315);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(240, 45);
            button6.Text = "🔍 Search";
            button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button6.Click += button6_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContainer.Location = new System.Drawing.Point(260, 60);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new System.Drawing.Size(960, 640);
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 700);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainDashboard";
            Text = "DBU Library - Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelContainer;
    }
}
