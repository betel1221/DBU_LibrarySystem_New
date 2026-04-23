using System.Drawing;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.Load += (s, e) => {
                ThemeHelper.ApplyTheme(this);
                // Load default
                LoadUserControl(new ucMyHistory());
                HighlightButton(button1);
            };
        }

        private void LoadUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            
            // Interaction: Slide-in Transition
            uc.Left = 50; 
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            
            System.Windows.Forms.Timer transitionTimer = new System.Windows.Forms.Timer { Interval = 10 };
            transitionTimer.Tick += (s, e) => {
                if (uc.Left > 0)
                    uc.Left -= 5;
                else
                    transitionTimer.Stop();
            };
            transitionTimer.Start();
        }

        private void HighlightButton(Button activeBtn)
        {
            Button[] btns = { button1, button2 };
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
            LoadUserControl(new ucMyHistory());
            HighlightButton((Button)sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucCatalogSearch());
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
