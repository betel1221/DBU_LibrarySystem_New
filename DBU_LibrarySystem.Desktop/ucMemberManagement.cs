using System;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucMemberManagement : UserControl
    {
        public ucMemberManagement()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            LoadRealData();
        }

        private void LoadRealData()
        {
            dataGridView1.Rows.Clear();
            using (var db = new DBU_LibrarySystem.Data.LibraryContext())
            {
                var members = db.Users.Where(u => u.Role == "Student" || u.Role == "Employee").ToList();
                foreach (var m in members)
                {
                    dataGridView1.Rows.Add(m.UserId, m.Name, m.ContactNumber ?? "N/A");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text.Trim();
                string name = txtName.Text.Trim();
                string contact = txtEmail.Text.Trim(); // Using email field for contact

                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("ID and Name are required.");
                    return;
                }

                using (var db = new DBU_LibrarySystem.Data.LibraryContext())
                {
                    if (db.Users.Any(u => u.UserId == id))
                    {
                        MessageBox.Show("Member ID already exists.");
                        return;
                    }

                    var member = new DBU_LibrarySystem.Models.User
                    {
                        UserId = id,
                        Name = name,
                        Role = "Student", // Default role
                        Password = "password123", // Assign default password for new members
                        ContactNumber = contact,
                        IsApproved = true
                    };

                    db.Users.Add(member);
                    db.SaveChanges();
                }

                MessageBox.Show("Member added successfully!");
                LoadRealData();
                txtID.Clear();
                txtName.Clear();
                txtEmail.Clear();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (ex.InnerException != null) msg += "\nInner: " + ex.InnerException.Message;
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRealData();
        }
    }
}
