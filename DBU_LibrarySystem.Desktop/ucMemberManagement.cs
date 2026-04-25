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
            
            // Set default view
            cmbRole.SelectedIndex = 0;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isStudent = cmbRole.SelectedIndex == 0;
            
            if (isStudent)
            {
                txtID.PlaceholderText = "Student ID";
                txtEmail.PlaceholderText = "Student Email";
                txtDepartment.Visible = true;
                txtOfficeNumber.Visible = false;
                txtIDCardPath.Visible = true;
                btnBrowseID.Visible = true;
            }
            else
            {
                txtID.PlaceholderText = "Staff ID";
                txtEmail.PlaceholderText = "Staff Email/Phone";
                txtDepartment.Visible = false;
                txtOfficeNumber.Visible = true;
                
                // Hide ID card logic for staff, or keep it. Let's hide it for staff.
                txtIDCardPath.Visible = false;
                btnBrowseID.Visible = false;
            }
        }

        private void LoadRealData()
        {
            dataGridView1.Rows.Clear();
            
            if(dataGridView1.Columns.Count == 0) {
                dataGridView1.Columns.Add("ID", "Member ID");
                dataGridView1.Columns.Add("Name", "Full Name");
                dataGridView1.Columns.Add("Role", "Role");
                dataGridView1.Columns.Add("DeptOffice", "Dept/Office");
                dataGridView1.Columns.Add("Contact", "Contact");
            }

            using (var db = new DBU_LibrarySystem.Data.LibraryContext())
            {
                // All Student/Employee roles are considered 'Members'
                var members = db.Users
                    .Where(u => u.Role == "Student" || u.Role == "Employee" || u.Role == "Librarian")
                    .OrderBy(u => u.Name)
                    .ToList();

                foreach (var m in members)
                {
                    string deptOffice = m.Role == "Student" ? m.Department : m.OfficeNumber;
                    dataGridView1.Rows.Add(m.UserId, m.Name, m.Role, deptOffice ?? "N/A", m.ContactNumber ?? "N/A");
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
                string department = txtDepartment.Text.Trim();
                string officeNumber = txtOfficeNumber.Text.Trim();
                string role = cmbRole.SelectedIndex == 0 ? "Student" : "Librarian";

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
                        Role = role,
                        Password = "123456", // Default secure-ish password
                        ContactNumber = contact,
                        IDCardImagePath = role == "Student" ? idPath : null,
                        Department = role == "Student" ? department : null,
                        OfficeNumber = role != "Student" ? officeNumber : null,
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
            txtDepartment.Clear();
            txtOfficeNumber.Clear();
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
