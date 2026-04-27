using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;
using Microsoft.EntityFrameworkCore;
using System.IO;
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
                txtIDCardPath.Visible = true;
                btnBrowseID.Visible = true;
                lblDepartment.Visible = true;
                lblIDCard.Visible = true;
            }
            else
            {
                txtID.PlaceholderText = "Staff ID";
                txtEmail.PlaceholderText = "Staff Email/Phone";
                txtDepartment.Visible = false;
                txtIDCardPath.Visible = false;
                btnBrowseID.Visible = false;
                lblDepartment.Visible = false;
                lblIDCard.Visible = false;
            }
        }

        private void LoadRealData()
        {
            try
            {
                dataGridView1.Rows.Clear();
                
                if(dataGridView1.Columns.Count == 0) {
                    dataGridView1.Columns.Add("ID", "Member ID");
                    dataGridView1.Columns.Add("Name", "Full Name");
                    dataGridView1.Columns.Add("Role", "Role");
                    dataGridView1.Columns.Add("Department", "Department");
                    dataGridView1.Columns.Add("Contact", "Contact");
                }

                using (var db = new DBU_LibrarySystem.Data.LibraryContext())
                {
                    var members = db.Users
                        .Where(u => u.Role == "Student" || u.Role == "Employee" || u.Role == "Librarian")
                        .OrderBy(u => u.Name)
                        .ToList();

                    foreach (var m in members)
                    {
                        string dept = m.Role == "Student" ? m.Department : "N/A";
                        dataGridView1.Rows.Add(m.UserId, m.Name, m.Role, dept ?? "N/A", m.ContactNumber ?? "N/A");
                    }
                }
            }
            catch (Exception ex)
            {
                // Silent catch or simple log
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

                    var member = new DBU_LibrarySystem.Models.User
                    {
                        UserId = id,
                        Name = name,
                        Role = role,
                        Password = "dbu" + id, 
                        ContactNumber = contact,
                        IDCardImagePath = role == "Student" ? idPath : null,
                        Department = role == "Student" ? department : null,
                        IsApproved = true 
                    };

                    db.Users.Add(member);
                    db.SaveChanges();
                }

                MessageBox.Show($"Member registered successfully!\n\nLogin Username: {name}\nDefault Password: dbu{id}", "Registration Success");
                
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
        }

        private void btnCaptureID_Click(object sender, EventArgs e)
        {
            using (var cam = new CameraCaptureForm())
            {
                if (cam.ShowDialog() == DialogResult.OK)
                {
                    txtIDCardPath.Text = cam.CapturedFilePath;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRealData();
        }
    }
}
