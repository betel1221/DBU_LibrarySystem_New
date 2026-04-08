using System;
using System.Windows.Forms;

namespace DBU_LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Resize += (s, e) => CenterComponents();
            this.Load += (s, e) => CenterComponents();
        }

        private void CenterComponents()
        {
            if (panel1 != null && label1 != null && panel2 != null)
            {
                // Center the title in the top bar
                label1.Left = (panel1.Width - label1.Width) / 2;
                
                // Center the login box in the remaining form area
                panel2.Left = (this.ClientSize.Width - panel2.Width) / 2;
                panel2.Top = ((this.ClientSize.Height + panel1.Height) - panel2.Height) / 2;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form dashboard;
            
            // Basic role routing logic
            string user = txtUsername.Text.Trim().ToLower();
            if (user == "student" || user == "student@dbu.edu")
            {
                dashboard = new StudentDashboard();
            }
            else if (user == "staff" || user == "employee")
            {
                dashboard = new StaffDashboard();
            }
            else
            {
                dashboard = new MainDashboard();
            }
            
            // Ensure application exits when dashboard is closed
            dashboard.FormClosed += (s, args) => this.Close();
            
            dashboard.Show();
            this.Hide();
        }
    }
}
