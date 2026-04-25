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
            cmbMember.Items.Clear();
            
            using (var db = new DBU_LibrarySystem.Data.LibraryContext())
            {
                // Load System Users for the list
                var users = db.Users.ToList();
                foreach (var u in users)
                {
                    dataGridView1.Rows.Add(u.UserId, u.UserId, u.Role);
                }

                // Load all possible Members for the dropdown (to create/update their accounts)
                _allMembers = db.Users.Where(u => u.Role == "Student" || u.Role == "Employee" || u.Role == "Librarian").ToList();
                foreach (var m in _allMembers)
                {
                    cmbMember.Items.Add($"{m.Name} ({m.UserId})");
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMember.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Member first.");
                    return;
                }

                string selectedText = cmbMember.SelectedItem.ToString();
                // Extract UserId from "Name (UserId)"
                string username = selectedText.Substring(selectedText.LastIndexOf('(') + 1).TrimEnd(')');
                
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
