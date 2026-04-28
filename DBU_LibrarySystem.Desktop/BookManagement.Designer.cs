namespace DBU_LibrarySystem
{
    partial class BookManagement
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

        #region Windows Form Designer generated code

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
            panel5 = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button8 = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            button7 = new System.Windows.Forms.Button();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1362, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(241, 25);
            label1.TabIndex = 1;
            label1.Text = "DBU Library | Admin Console";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(264, 601);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(12, 29);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(217, 34);
            button1.TabIndex = 0;
            button1.Text = "Book Management";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Location = new System.Drawing.Point(12, 83);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(217, 34);
            button2.TabIndex = 1;
            button2.Text = "Member Management";
            button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = System.Windows.Forms.Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Location = new System.Drawing.Point(12, 140);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(217, 34);
            button3.TabIndex = 2;
            button3.Text = "User Management";
            button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Cursor = System.Windows.Forms.Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Location = new System.Drawing.Point(12, 196);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(217, 34);
            button4.TabIndex = 3;
            button4.Text = "BorrowReturn";
            button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Cursor = System.Windows.Forms.Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.Location = new System.Drawing.Point(12, 251);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(217, 34);
            button5.TabIndex = 4;
            button5.Text = "Reports";
            button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Cursor = System.Windows.Forms.Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button6.Location = new System.Drawing.Point(12, 305);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(217, 34);
            button6.TabIndex = 5;
            button6.Text = "Search";
            button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label2);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(264, 55);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1098, 601);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            label2.Location = new System.Drawing.Point(27, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(298, 38);
            label2.TabIndex = 0;
            label2.Text = "Book Management";
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.White;
            panel4.Controls.Add(button7);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label3);
            panel4.Location = new System.Drawing.Point(41, 90);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(1026, 150);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.White;
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(button8);
            panel5.Location = new System.Drawing.Point(41, 260);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(1026, 320);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.FromArgb(44, 127, 184);
            label3.Location = new System.Drawing.Point(19, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 25);
            label3.TabIndex = 0;
            label3.Text = "Add New Book";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(19, 50);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ISBN";
            textBox1.Size = new System.Drawing.Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(225, 50);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Book Title";
            textBox2.Size = new System.Drawing.Size(250, 31);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(525, 50);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Author";
            textBox3.Size = new System.Drawing.Size(200, 31);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(775, 50);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Quantity";
            textBox4.Size = new System.Drawing.Size(100, 31);
            textBox4.TabIndex = 4;
            // 
            // button7
            // 
            button7.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            button7.ForeColor = System.Drawing.Color.White;
            button7.Location = new System.Drawing.Point(19, 100);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(208, 34);
            button7.TabIndex = 5;
            button7.Text = "Add Book";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = System.Drawing.Color.FromArgb(44, 127, 184);
            button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            button8.ForeColor = System.Drawing.Color.White;
            button8.Location = new System.Drawing.Point(19, 20);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(208, 34);
            button8.TabIndex = 4;
            button8.Text = "Refresh Book List";
            button8.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colID, colTitle, colAuthor, colStock });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new System.Drawing.Point(19, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new System.Drawing.Size(987, 230);
            dataGridView1.TabIndex = 5;
            // 
            // colID
            // 
            colID.HeaderText = "ISBN";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Title";
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colAuthor
            // 
            colAuthor.HeaderText = "Author";
            colAuthor.Name = "colAuthor";
            colAuthor.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.HeaderText = "Stock available";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // BookManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1362, 656);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BookManagement";
            Text = "DBU Library - Book Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
    }
}
