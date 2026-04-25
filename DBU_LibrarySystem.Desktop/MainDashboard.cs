using System;
using System.Drawing;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class MainDashboard : Form
    {
        private DBU_LibrarySystem.Models.User _currentUser;
        public MainDashboard(DBU_LibrarySystem.Models.User user)
        {
            InitializeComponent();
            _currentUser = user;
            this.WindowState = FormWindowState.Maximized;

            this.Load += (s, e) => {
                ThemeHelper.ApplyTheme(this);
                if (lblWelcome != null) lblWelcome.Text = $"Welcome, Admin {_currentUser.Name}";
                // Load default
                LoadUserControl(new ucBookManagement());
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
                case "Books": button1_Click(button1, EventArgs.Empty); break;
                case "Members": button2_Click(button2, EventArgs.Empty); break;
                case "Auth": button3_Click(button3, EventArgs.Empty); break;
                case "Borrow": 
                    var borrowUc = new ucBorrowReturn();
                    LoadUserControl(borrowUc);
                    HighlightButton(button4);
                    if (data is string copyId) borrowUc.PreFillIssue(copyId);
                    break;
                case "Reports": button5_Click(button5, EventArgs.Empty); break;
                case "Search": button6_Click(button6, EventArgs.Empty); break;
            }
        }

        private void HighlightButton(Button activeBtn)
        {
            Button[] btns = { button1, button2, button3, button4, button5, button6 };
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
