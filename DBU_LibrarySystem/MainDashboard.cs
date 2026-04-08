using System;
using System.Windows.Forms;

namespace DBU_LibrarySystem
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            // Load the default user control
            LoadUserControl(new ucBookManagement());
            HighlightButton(button1); // BookManagement button
        }

        private void LoadUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void HighlightButton(Button activeBtn)
        {
            // Reset all buttons
            Button[] btns = { button1, button2, button3, button4, button5, button6 };
            foreach (var b in btns)
            {
                b.BackColor = System.Drawing.Color.White;
                b.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }

            // Highlight active
            activeBtn.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            activeBtn.ForeColor = System.Drawing.Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucBookManagement());
            HighlightButton((Button)sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucMemberManagement());
            HighlightButton((Button)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucUserAuthentication());
            HighlightButton((Button)sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucBorrowReturn());
            HighlightButton((Button)sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucReports());
            HighlightButton((Button)sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucGlobalSearch());
            HighlightButton((Button)sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
            this.Hide();
        }
    }
}
