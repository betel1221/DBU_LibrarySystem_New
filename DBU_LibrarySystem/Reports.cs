using System;
using System.Windows.Forms;

namespace DBU_LibrarySystem
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            SetupNavigation();
        }

        private void SetupNavigation()
        {
            button1.Click += (s, e) => NavigateTo(new BookManagement());
            button2.Click += (s, e) => NavigateTo(new MemberManagement());
            button3.Click += (s, e) => NavigateTo(new UserAuthentication());
            button4.Click += (s, e) => NavigateTo(new BorrowReturn());
            // button5 is Reports (Current)
            button6.Click += (s, e) => NavigateTo(new GlobalSearch());
        }

        private void NavigateTo(Form newForm)
        {
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();
        }
    }
}
