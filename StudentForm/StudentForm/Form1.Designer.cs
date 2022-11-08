namespace StudentForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert_Student = new System.Windows.Forms.Button();
            this.btnDelete_Student = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch_Student = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(119, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(259, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Details";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(131, 103);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(130, 23);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(130, 23);
            this.txtID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtModule);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtGender);
            this.groupBox2.Controls.Add(this.txtDOB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(646, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 221);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(381, 64);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(130, 23);
            this.txtAddress.TabIndex = 1;
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(381, 127);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(130, 23);
            this.txtModule.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(103, 152);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(130, 23);
            this.txtPhone.TabIndex = 1;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(103, 101);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(130, 23);
            this.txtGender.TabIndex = 1;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(103, 47);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(130, 23);
            this.txtDOB.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Class Module:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "DOB:";
            // 
            // btnInsert_Student
            // 
            this.btnInsert_Student.Location = new System.Drawing.Point(1125, 296);
            this.btnInsert_Student.Name = "btnInsert_Student";
            this.btnInsert_Student.Size = new System.Drawing.Size(107, 38);
            this.btnInsert_Student.TabIndex = 3;
            this.btnInsert_Student.Text = "Insert Student";
            this.btnInsert_Student.UseVisualStyleBackColor = true;
            this.btnInsert_Student.Click += new System.EventHandler(this.btnInsert_Student_Click);
            // 
            // btnDelete_Student
            // 
            this.btnDelete_Student.Location = new System.Drawing.Point(1125, 355);
            this.btnDelete_Student.Name = "btnDelete_Student";
            this.btnDelete_Student.Size = new System.Drawing.Size(107, 38);
            this.btnDelete_Student.TabIndex = 3;
            this.btnDelete_Student.Text = "Remove Student";
            this.btnDelete_Student.UseVisualStyleBackColor = true;
            this.btnDelete_Student.Click += new System.EventHandler(this.btnDelete_Student_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 38);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Return";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSearch_Student
            // 
            this.btnSearch_Student.Location = new System.Drawing.Point(55, 273);
            this.btnSearch_Student.Name = "btnSearch_Student";
            this.btnSearch_Student.Size = new System.Drawing.Size(107, 38);
            this.btnSearch_Student.TabIndex = 3;
            this.btnSearch_Student.Text = "Search Student";
            this.btnSearch_Student.UseVisualStyleBackColor = true;
            this.btnSearch_Student.Click += new System.EventHandler(this.btnSearch_Student_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(846, 212);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetInfo);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(27, 332);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 23);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up_Search);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1125, 423);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 38);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Details";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 557);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete_Student);
            this.Controls.Add(this.btnSearch_Student);
            this.Controls.Add(this.btnInsert_Student);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtID;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtAddress;
        private TextBox txtModule;
        private TextBox txtPhone;
        private TextBox txtGender;
        private TextBox txtDOB;
        private Button btnInsert_Student;
        private Button btnDelete_Student;
        private Button btnBack;
        private Button btnSearch_Student;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btnUpdate;
    }
}