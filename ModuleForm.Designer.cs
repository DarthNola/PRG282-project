namespace PRG_282_Project
{
    partial class ModuleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoginWeb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsertCourse = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnSearchCourseID = new System.Windows.Forms.Button();
            this.txtSearchCourseID = new System.Windows.Forms.TextBox();
            this.lblSearchCourseID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblLoginWeb);
            this.panel1.Location = new System.Drawing.Point(-1, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 35);
            this.panel1.TabIndex = 0;
            // 
            // lblLoginWeb
            // 
            this.lblLoginWeb.AutoSize = true;
            this.lblLoginWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginWeb.ForeColor = System.Drawing.Color.White;
            this.lblLoginWeb.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblLoginWeb.Location = new System.Drawing.Point(592, 10);
            this.lblLoginWeb.Name = "lblLoginWeb";
            this.lblLoginWeb.Size = new System.Drawing.Size(181, 15);
            this.lblLoginWeb.TabIndex = 2;
            this.lblLoginWeb.Text = "www.belgiumcampus.ac.za";
            this.lblLoginWeb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(-1, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 28);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(-1, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1312, 20);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtCourseName);
            this.groupBox1.Controls.Add(this.txtCourseID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblCourseName);
            this.groupBox1.Controls.Add(this.lblCourseID);
            this.groupBox1.Location = new System.Drawing.Point(45, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Details";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(143, 143);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(122, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(143, 89);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(122, 20);
            this.txtCourseName.TabIndex = 4;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(143, 34);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(122, 20);
            this.txtCourseID.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(7, 143);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(6, 89);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(122, 20);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.Location = new System.Drawing.Point(7, 34);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(100, 20);
            this.lblCourseID.TabIndex = 0;
            this.lblCourseID.Text = "Course ID: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(450, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(829, 255);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnInsertCourse
            // 
            this.btnInsertCourse.BackColor = System.Drawing.Color.Maroon;
            this.btnInsertCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCourse.ForeColor = System.Drawing.Color.White;
            this.btnInsertCourse.Location = new System.Drawing.Point(47, 322);
            this.btnInsertCourse.Name = "btnInsertCourse";
            this.btnInsertCourse.Size = new System.Drawing.Size(105, 50);
            this.btnInsertCourse.TabIndex = 5;
            this.btnInsertCourse.Text = "Insert Course";
            this.btnInsertCourse.UseVisualStyleBackColor = false;
            this.btnInsertCourse.Click += new System.EventHandler(this.btnInsertCourse_Click);
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCourse.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCourse.Location = new System.Drawing.Point(170, 322);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(105, 50);
            this.btnRemoveCourse.TabIndex = 6;
            this.btnRemoveCourse.Text = "Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = false;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdateCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCourse.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCourse.Location = new System.Drawing.Point(290, 322);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(105, 50);
            this.btnUpdateCourse.TabIndex = 7;
            this.btnUpdateCourse.Text = "Update Course";
            this.btnUpdateCourse.UseVisualStyleBackColor = false;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnSearchCourseID
            // 
            this.btnSearchCourseID.BackColor = System.Drawing.Color.Maroon;
            this.btnSearchCourseID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchCourseID.BackgroundImage")));
            this.btnSearchCourseID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchCourseID.Location = new System.Drawing.Point(730, 33);
            this.btnSearchCourseID.Name = "btnSearchCourseID";
            this.btnSearchCourseID.Size = new System.Drawing.Size(42, 27);
            this.btnSearchCourseID.TabIndex = 8;
            this.btnSearchCourseID.UseVisualStyleBackColor = false;
            this.btnSearchCourseID.Click += new System.EventHandler(this.btnSearchCourseID_Click);
            // 
            // txtSearchCourseID
            // 
            this.txtSearchCourseID.Location = new System.Drawing.Point(586, 37);
            this.txtSearchCourseID.Name = "txtSearchCourseID";
            this.txtSearchCourseID.Size = new System.Drawing.Size(138, 20);
            this.txtSearchCourseID.TabIndex = 9;
            this.txtSearchCourseID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchCourseID_KeyUp);
            // 
            // lblSearchCourseID
            // 
            this.lblSearchCourseID.AutoSize = true;
            this.lblSearchCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCourseID.Location = new System.Drawing.Point(447, 38);
            this.lblSearchCourseID.Name = "lblSearchCourseID";
            this.lblSearchCourseID.Size = new System.Drawing.Size(133, 16);
            this.lblSearchCourseID.TabIndex = 10;
            this.lblSearchCourseID.Text = "Search by Course ID:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(1196, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 42);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Link To Course:";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(143, 196);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(122, 20);
            this.txtLink.TabIndex = 5;
            // 
            // ModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 458);
            this.Controls.Add(this.lblSearchCourseID);
            this.Controls.Add(this.txtSearchCourseID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchCourseID);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.btnInsertCourse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ModuleForm";
            this.Text = "ModuleForm";
            this.Load += new System.EventHandler(this.ModuleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoginWeb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsertCourse;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button btnSearchCourseID;
        private System.Windows.Forms.TextBox txtSearchCourseID;
        private System.Windows.Forms.Label lblSearchCourseID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label1;
    }
}