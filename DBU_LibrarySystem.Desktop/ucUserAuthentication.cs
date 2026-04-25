using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucUserAuthentication : UserControl
    {
        private List<DBU_LibrarySystem.Models.User> _allMembers = new List<DBU_LibrarySystem.Models.User>();

        public ucUserAuthentication()
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
                // Load System Users for the list
                var users = db.Users.ToList();
                foreach (var u in users)
                {
                    dataGridView1.Rows.Add(u.UserId, u.UserId, u.Role);
                }
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
                        // Update existing user (Member already has an entry, we just update login details)
                        existingUser.Password = password;
                        existingUser.Role = role;
                        existingUser.IsApproved = true;
                        db.SaveChanges();
                        MessageBox.Show($"Account updated for {existingUser.Name}!");
                    }
                    else
                    {
                        // This case should ideally not happen if they are in the dropdown
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
