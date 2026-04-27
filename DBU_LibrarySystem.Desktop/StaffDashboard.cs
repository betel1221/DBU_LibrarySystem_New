using System.Drawing;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class StaffDashboard : Form
    {
        private DBU_LibrarySystem.Models.User _currentUser;
        public StaffDashboard(DBU_LibrarySystem.Models.User user)
        {
            InitializeComponent();
            _currentUser = user;
            this.WindowState = FormWindowState.Maximized;

            this.Load += (s, e) => {
                ThemeHelper.ApplyTheme(this);
                if (lblWelcome != null) lblWelcome.Text = $"Welcome, {_currentUser.Name}";
                // Cleanup
                DBU_LibrarySystem.Services.LibraryManager.CleanupExpiredReservations();
                // Load default
                LoadUserControl(new ucStaffCirculation());
                HighlightButton(button1);
            };
        }

        private void LoadUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            uc.Left = 50; 
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            
            System.Windows.Forms.Timer transitionTimer = new System.Windows.Forms.Timer { Interval = 10 };
            transitionTimer.Tick += (s, e) => {
                if (uc.Left > 0) uc.Left -= 5;
                else transitionTimer.Stop();
            };
            transitionTimer.Start();
        }

        public void NavigateToModule(string moduleName, object data = null)
        {
            switch (moduleName)
            {
                case "Circulation": 
                    var circUc = new ucStaffCirculation();
                    LoadUserControl(circUc);
                    HighlightButton(button1);
                    if (data is string copyId) circUc.PreFillIssue(copyId);
                    break;
                case "Reports": button2_Click(button2, EventArgs.Empty); break;
                case "Search": button3_Click(button3, EventArgs.Empty); break;
            }
        }

        private void HighlightButton(Button activeBtn)
        {
            Button[] btns = { button1, button2, button3 };
            foreach (var b in btns)
            {
                b.BackColor = Color.Transparent;
                b.ForeColor = ThemeHelper.TextSecondary;
            }
            activeBtn.BackColor = Color.FromArgb(40, ThemeHelper.PrimaryColor);
            activeBtn.ForeColor = ThemeHelper.AccentColor;
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
