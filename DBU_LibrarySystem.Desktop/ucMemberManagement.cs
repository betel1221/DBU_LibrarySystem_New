using System;
using System.Data;
using System.Linq;
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
            
            if(dataGridView1.Columns.Count == 0) {
                dataGridView1.Columns.Add("ID", "Member ID");
                dataGridView1.Columns.Add("Name", "Full Name");
                dataGridView1.Columns.Add("Contact", "Contact");
                dataGridView1.Columns.Add("Role", "Role");
            }

            using (var db = new DBU_LibrarySystem.Data.LibraryContext())
            {
                // All Student/Employee roles are considered 'Members'
                var members = db.Users
                    .Where(u => u.Role == "Student" || u.Role == "Employee")
                    .OrderBy(u => u.Name)
                    .ToList();

                foreach (var m in members)
                {
                    dataGridView1.Rows.Add(m.UserId, m.Name, m.ContactNumber ?? "N/A", m.Role);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text.Trim();
                string name = txtName.Text.Trim();
                string contact = txtEmail.Text.Trim();
                string idPath = txtIDCardPath.Text.Trim();

                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Member ID and Name are required.");
                    return;
                }

                using (var db = new DBU_LibrarySystem.Data.LibraryContext())
                {
                    if (db.Users.Any(u => u.UserId == id))
                    {
                        MessageBox.Show("Member ID already exists.");
                        return;
                    }

                    // Automatic User Creation (One-Step Registration)
                    var member = new DBU_LibrarySystem.Models.User
                    {
                        UserId = id,
                        Name = name,
                        Role = "Student", // Default to Student
                        Password = "123456", // Default secure-ish password
                        ContactNumber = contact,
                        IDCardImagePath = idPath,
                        IsApproved = true // Auto-approved as requested
                    };

                    db.Users.Add(member);
                    db.SaveChanges();
                }

                MessageBox.Show($"Member registered successfully!\n\nLogin Username: {id}\nDefault Password: 123456", "Registration Success");
                
                LoadRealData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering member: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtIDCardPath.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRealData();
        }

        // Methods below are kept for compatibility if needed elsewhere, but marked as empty
        private void btnViewID_Click(object sender, EventArgs e) { }
        private void btnApprove_Click(object sender, EventArgs e) { }
    }
}
