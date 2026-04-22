using System;
using System.Windows.Forms;

namespace DBU_LibrarySystem
{
    public partial class MemberManagement : Form
    {
        public MemberManagement()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadDummyData();
            SetupNavigation();
        }

        private void LoadDummyData()
        {
            dataGridView1.Rows.Add("M-001", "John Doe", "john.doe@dbu.edu");
            dataGridView1.Rows.Add("M-002", "Jane Smith", "jane.smith@dbu.edu");
            dataGridView1.Rows.Add("M-003", "Alice Johnson", "alice.j@dbu.edu");
        }

        private void SetupNavigation()
        {
            // Detach any existing handlers to prevent double execution if Designer has them
            button1.Click -= button1_Click;
            button3.Click -= button3_Click;

            button1.Click += (s, e) => NavigateTo(new BookManagement());
            // button2 is MemberManagement (Current)
            button3.Click += (s, e) => NavigateTo(new UserAuthentication());
            button4.Click += (s, e) => NavigateTo(new BorrowReturn());
            button5.Click += (s, e) => NavigateTo(new Reports());
            button6.Click += (s, e) => NavigateTo(new GlobalSearch());
        }

        private void NavigateTo(Form newForm)
        {
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) { /* Handled in SetupNavigation */ }
        private void button3_Click(object sender, EventArgs e) { /* Handled in SetupNavigation */ }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
