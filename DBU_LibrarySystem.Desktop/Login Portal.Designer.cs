namespace DBU_LibrarySystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btnLogin = new System.Windows.Forms.Button();
            txtPassword = new System.Windows.Forms.TextBox();
            txtUsername = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(584, 80);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            label1.Location = new System.Drawing.Point(50, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(560, 45);
            label1.TabIndex = 0;
            label1.Text = "DBU LIBRARY MANAGEMENT SYSTEM";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(200, 28, 30, 38);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new System.Drawing.Point(120, 120);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(350, 350);
            panel2.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(35, 260);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(280, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "SIGN IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.FromArgb(35, 38, 48);
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPassword.ForeColor = System.Drawing.Color.White;
            txtPassword.Location = new System.Drawing.Point(35, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(280, 29);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = System.Drawing.Color.FromArgb(35, 38, 48);
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtUsername.ForeColor = System.Drawing.Color.White;
            txtUsername.Location = new System.Drawing.Point(35, 80);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(280, 29);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(35, 140);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 19);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(35, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 19);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(28, 30, 38);
            ClientSize = new System.Drawing.Size(584, 421);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "DBU Library - Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
