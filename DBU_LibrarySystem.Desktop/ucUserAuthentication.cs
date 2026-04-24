using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucUserAuthentication : UserControl
    {
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
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string role = cmbRole.SelectedItem?.ToString() ?? "Student";

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and password are required.");
                    return;
                }

                using (var db = new DBU_LibrarySystem.Data.LibraryContext())
                {
                    var existingUser = db.Users.FirstOrDefault(u => u.UserId == username);
                    if (existingUser != null)
                    {
                        // Update existing user or error? 
                        // The note says: "For students, the Username must match their Member ID."
                        // So if they already exist as a member, we just update their password.
                        existingUser.Password = password;
                        existingUser.Role = role;
                    }
                    else
                    {
                        var user = new DBU_LibrarySystem.Models.User
                        {
                            UserId = username,
                            Name = username, // Default name to username if not found
                            Password = password,
                            Role = role,
                            IsApproved = true
                        };
                        db.Users.Add(user);
                    }
                    db.SaveChanges();
                }

                MessageBox.Show("Account created/updated successfully!");
                LoadRealData();
                txtUsername.Clear();
                txtPassword.Clear();
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
