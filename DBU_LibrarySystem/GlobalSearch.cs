using System;
using System.Windows.Forms;

namespace DBU_LibrarySystem
{
    public partial class GlobalSearch : Form
    {
        public GlobalSearch()
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
            button5.Click += (s, e) => NavigateTo(new Reports());
            // button6 is GlobalSearch (Current)
        }

        private void NavigateTo(Form newForm)
        {
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();
        }

        // Mock search functionality
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if(!string.IsNullOrEmpty(txtSearch.Text))
            {
                dataGridView1.Rows.Add("Book", "978-0131103627", "The C Programming Language", "Available");
                dataGridView1.Rows.Add("Member", "M-001", "John Doe", "Active");
            }
        }
    }
}
