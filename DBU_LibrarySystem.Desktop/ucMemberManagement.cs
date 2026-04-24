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
            dataGridViewPending.Rows.Clear();
            
            // Set up columns for pending if not done
            if(dataGridViewPending.Columns.Count == 0) {
                dataGridViewPending.Columns.Add("ID", "ID");
                dataGridViewPending.Columns.Add("Name", "Name");
                dataGridViewPending.Columns.Add("Contact", "Contact");
            }
            if(dataGridView1.Columns.Count == 0) {
                dataGridView1.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Contact", "Contact");
            }

            using (var db = new DBU_LibrarySystem.Data.LibraryContext())
            {
                var allUsers = db.Users.Where(u => u.Role == "Student" || u.Role == "Employee").ToList();
                foreach (var u in allUsers)
                {
                    if (u.IsApproved)
                        dataGridView1.Rows.Add(u.UserId, u.Name, u.ContactNumber ?? "N/A");
                    else
                        dataGridViewPending.Rows.Add(u.UserId, u.Name, u.ContactNumber ?? "N/A");
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
                        Role = "Student",
                        Password = "password123",
                        ContactNumber = contact,
                        IDCardImagePath = idPath,
                        IsApproved = string.IsNullOrEmpty(idPath) // Auto-approve if no ID path provided (direct admin add)
                    };

                    db.Users.Add(member);
                    db.SaveChanges();
                }

                MessageBox.Show(txtIDCardPath.Text != "" ? "Registration submitted for approval!" : "Member added successfully!");
                LoadRealData();
                txtID.Clear();
                txtName.Clear();
                txtEmail.Clear();
                txtIDCardPath.Clear();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (ex.InnerException != null) msg += "\nInner: " + ex.InnerException.Message;
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewID_Click(object sender, EventArgs e)
        {
            if (dataGridViewPending.CurrentRow == null) return;
            string userId = dataGridViewPending.CurrentRow.Cells[0].Value.ToString();

            using (var db = new DBU_LibrarySystem.Data.LibraryContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserId == userId);
                if (user != null && !string.IsNullOrEmpty(user.IDCardImagePath))
                {
                    try { System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(user.IDCardImagePath) { UseShellExecute = true }); }
                    catch { MessageBox.Show("Could not open ID Card image."); }
                }
                else MessageBox.Show("No ID Card image uploaded.");
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dataGridViewPending.CurrentRow == null) return;
            string userId = dataGridViewPending.CurrentRow.Cells[0].Value.ToString();

            try
            {
                using (var db = new DBU_LibrarySystem.Data.LibraryContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserId == userId);
                    if (user != null)
                    {
                        user.IsApproved = true;
                        db.SaveChanges();
                        MessageBox.Show($"Student {user.Name} approved successfully!");
                        LoadRealData();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRealData();
        }
    }
}
