using System;
using System.Windows.Forms;

namespace DBU_LibrarySystem
{
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            // Load default UC
            LoadUserControl(new ucStaffCirculation());
            HighlightButton(button1); // Circulation button
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
            Button[] btns = { button1, button2, button3 };
            foreach (var b in btns)
            {
                b.BackColor = System.Drawing.Color.White;
                b.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
            activeBtn.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            activeBtn.ForeColor = System.Drawing.Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucStaffCirculation());
            HighlightButton((Button)sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucStaffReports());
            HighlightButton((Button)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucStaffCatalogSearch());
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
