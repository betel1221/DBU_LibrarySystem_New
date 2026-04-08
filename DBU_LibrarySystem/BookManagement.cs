using System;
using System.Windows.Forms;

namespace DBU_LibrarySystem
{
    public partial class BookManagement : Form
    {
        public BookManagement()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            dataGridView1.Rows.Add("978-0131103627", "The C Programming Language", "Brian W. Kernighan", "5");
            dataGridView1.Rows.Add("978-0201616224", "The Pragmatic Programmer", "Andy Hunt", "2");
            dataGridView1.Rows.Add("978-0132350884", "Clean Code", "Robert C. Martin", "10");
        }

        private void NavigateTo(Form newForm)
        {
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigateTo(new MemberManagement());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavigateTo(new UserAuthentication());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NavigateTo(new BorrowReturn());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NavigateTo(new Reports());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NavigateTo(new GlobalSearch());
        }
    }
}
