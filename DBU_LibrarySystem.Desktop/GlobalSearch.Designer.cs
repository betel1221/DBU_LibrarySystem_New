namespace DBU_LibrarySystem
{
    partial class GlobalSearch
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            button6 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            btnSearch = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            panel5 = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // panel1
            panel1.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Size = new System.Drawing.Size(1362, 55);
            // label1
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 19);
            label1.Size = new System.Drawing.Size(241, 25);
            label1.Text = "DBU Library | Admin Console";
            // panel2
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 55);
            panel2.Size = new System.Drawing.Size(264, 601);
            // button1
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new System.Drawing.Point(12, 29);
            button1.Size = new System.Drawing.Size(217, 34);
            button1.Text = "Book Management";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // button2
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new System.Drawing.Point(12, 83);
            button2.Size = new System.Drawing.Size(217, 34);
            button2.Text = "Member Management";
            button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // button3
            button3.Cursor = System.Windows.Forms.Cursors.Hand;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.Location = new System.Drawing.Point(12, 140);
            button3.Size = new System.Drawing.Size(217, 34);
            button3.Text = "User Management";
            button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // button4
            button4.Cursor = System.Windows.Forms.Cursors.Hand;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.Location = new System.Drawing.Point(12, 196);
            button4.Size = new System.Drawing.Size(217, 34);
            button4.Text = "BorrowReturn";
            button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // button5
            button5.Cursor = System.Windows.Forms.Cursors.Hand;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button5.Location = new System.Drawing.Point(12, 251);
            button5.Size = new System.Drawing.Size(217, 34);
            button5.Text = "Reports";
            button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // button6
            button6.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            button6.ForeColor = System.Drawing.Color.White;
            button6.Cursor = System.Windows.Forms.Cursors.Hand;
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
            button6.Location = new System.Drawing.Point(12, 305);
            button6.Size = new System.Drawing.Size(217, 34);
            button6.Text = "Search";
            button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // panel3
            panel3.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label2);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(264, 55);
            panel3.Size = new System.Drawing.Size(1098, 601);
            // label2
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            label2.Location = new System.Drawing.Point(27, 23);
            label2.Size = new System.Drawing.Size(199, 38);
            label2.Text = "Global Search";
            // panel4
            panel4.BackColor = System.Drawing.Color.White;
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(txtSearch);
            panel4.Location = new System.Drawing.Point(41, 80);
            panel4.Size = new System.Drawing.Size(1026, 100);
            // txtSearch
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            txtSearch.Location = new System.Drawing.Point(20, 25);
            txtSearch.PlaceholderText = "Search for Books (Title/ISBN) or Members (Name/ID)...";
            txtSearch.Size = new System.Drawing.Size(750, 45);
            // btnSearch
            btnSearch.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnSearch.Location = new System.Drawing.Point(800, 25);
            btnSearch.Size = new System.Drawing.Size(200, 45);
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // panel5
            panel5.BackColor = System.Drawing.Color.White;
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new System.Drawing.Point(41, 200);
            panel5.Size = new System.Drawing.Size(1026, 380);
            // dataGridView1
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Type, ID, Details, Status });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new System.Drawing.Point(20, 20);
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new System.Drawing.Size(986, 340);
            // Type
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            // ID
            ID.HeaderText = "ID/ISBN";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // Details
            Details.HeaderText = "Details";
            Details.Name = "Details";
            Details.ReadOnly = true;
            // Status
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // GlobalSearch
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1362, 656);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GlobalSearch";
            Text = "DBU Library - Global Search";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}