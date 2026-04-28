using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucUserAuthentication : UserControl
    {
        public ucUserAuthentication()
        {
            InitializeComponent();
            this.AutoScroll = true;
            ThemeHelper.ApplyTheme(this);
            LoadRealData();
        }

        private void LoadRealData()
        {
            try
            {
                dataGridView1.Rows.Clear();
                
                if(dataGridView1.Columns.Count == 0) {
                    dataGridView1.Columns.Add("ID", "User ID");
                    dataGridView1.Columns.Add("Username", "Username");
                    dataGridView1.Columns.Add("Role", "Role");
                }

                using (var db = new DBU_LibrarySystem.Data.LibraryContext())
                {
                    var users = db.Users.ToList();
                    foreach (var u in users)
                    {
                        dataGridView1.Rows.Add(u.UserId, u.UserId, u.Role);
                    }
                }
            }
            catch (Exception ex)
            {
                // Silent
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtMemberID.Text.Trim();
                
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter a Member ID.");
                    return;
                }
                
                string password = txtPassword.Text.Trim();
                string role = cmbRole.SelectedItem?.ToString() ?? "Student";

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Password is required.");
                    return;
                }

                using (var db = new DBU_LibrarySystem.Data.LibraryContext())
                {
                    var existingUser = db.Users.FirstOrDefault(u => u.UserId == username);
                    if (existingUser != null)
                    {
                        existingUser.Password = password;
                        existingUser.Role = role;
                        existingUser.IsApproved = true;
                        db.SaveChanges();
                        MessageBox.Show($"Account updated for {existingUser.Name}!");
                    }
                    else
                    {
                        MessageBox.Show("Selected member not found in the database.");
                    }
                }

                LoadRealData();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRealData();
        }
    }
}
