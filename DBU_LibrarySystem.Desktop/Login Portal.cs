using System;
using System.Windows.Forms;
using DBU_LibrarySystem.Services;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None; // Make it full screen and modern
            this.Resize += (s, e) => CenterComponents();
            this.Load += (s, e) => {
                try {
                    string bgPath = System.IO.Path.Combine(Application.StartupPath, "Resources", "library_bg.png");
                    if (System.IO.File.Exists(bgPath)) {
                        this.BackgroundImage = System.Drawing.Image.FromFile(bgPath);
                        this.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                } catch { }
                
                panel1.Visible = false;
                CenterComponents();
            };
        }

        private void CenterComponents()
        {
            if (panel2 != null)
            {
                // Center the login box in the middle of the screen
                panel2.Left = (this.ClientSize.Width - panel2.Width) / 2;
                panel2.Top = (this.ClientSize.Height - panel2.Height) / 2 + 50;
            }

            if (label1 != null)
            {
                // Center the title at the top
                label1.Left = (this.ClientSize.Width - label1.Width) / 2;
                label1.Top = 100;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            btnLogin.Enabled = false;

            try
            {
                if (AuthManager.Login(user, pass))
                {
                    Form dashboard = null;
                    string role = AuthManager.CurrentUser.Role;
                    
                    if (role == "Student")
                    {
                        dashboard = new StudentDashboard(AuthManager.CurrentUser);
                    }
                    else if (role == "Librarian" || role == "Employee")
                    {
                        dashboard = new StaffDashboard(AuthManager.CurrentUser);
                    }
                    else if (role == "Admin")
                    {
                        dashboard = new MainDashboard(AuthManager.CurrentUser);
                    }

                    if (dashboard != null)
                    {
                        dashboard.FormClosed += (s, args) => this.Close();
                        dashboard.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid credentials.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnLogin.Enabled = true;
            }
        }
    }
}
