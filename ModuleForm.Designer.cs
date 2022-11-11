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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsertCourse = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSearchCourseID = new System.Windows.Forms.Button();
            this.txtSearchCourseID = new System.Windows.Forms.TextBox();
            this.lblSearchCourseID = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(888, 35);
            this.panel1.TabIndex = 0;
            // 
            // lblLoginWeb
            // 
            this.lblLoginWeb.AutoSize = true;
            this.lblLoginWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginWeb.ForeColor = System.Drawing.Color.White;
            this.lblLoginWeb.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblLoginWeb.Location = new System.Drawing.Point(374, 10);
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
            this.panel2.Size = new System.Drawing.Size(888, 28);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(-1, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(888, 20);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblCourseName);
            this.groupBox1.Controls.Add(this.lblCourseID);
            this.groupBox1.Location = new System.Drawing.Point(45, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 228);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(450, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 255);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnInsertCourse
            // 
            this.btnInsertCourse.BackColor = System.Drawing.Color.Maroon;
            this.btnInsertCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCourse.ForeColor = System.Drawing.Color.White;
            this.btnInsertCourse.Location = new System.Drawing.Point(45, 283);
            this.btnInsertCourse.Name = "btnInsertCourse";
            this.btnInsertCourse.Size = new System.Drawing.Size(105, 50);
            this.btnInsertCourse.TabIndex = 5;
            this.btnInsertCourse.Text = "Insert Course";
            this.btnInsertCourse.UseVisualStyleBackColor = false;
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCourse.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCourse.Location = new System.Drawing.Point(168, 283);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(105, 50);
            this.btnRemoveCourse.TabIndex = 6;
            this.btnRemoveCourse.Text = "Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdateCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCourse.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCourse.Location = new System.Drawing.Point(288, 283);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(105, 50);
            this.btnUpdateCourse.TabIndex = 7;
            this.btnUpdateCourse.Text = "Update Course";
            this.btnUpdateCourse.UseVisualStyleBackColor = false;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.Location = new System.Drawing.Point(7, 56);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(100, 20);
            this.lblCourseID.TabIndex = 0;
            this.lblCourseID.Text = "Course ID: ";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(6, 111);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(122, 20);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(7, 165);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(143, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 20);
            this.textBox3.TabIndex = 5;
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
            // 
            // txtSearchCourseID
            // 
            this.txtSearchCourseID.Location = new System.Drawing.Point(586, 37);
            this.txtSearchCourseID.Name = "txtSearchCourseID";
            this.txtSearchCourseID.Size = new System.Drawing.Size(138, 20);
            this.txtSearchCourseID.TabIndex = 9;
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
            // ModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 458);
            this.Controls.Add(this.lblSearchCourseID);
            this.Controls.Add(this.txtSearchCourseID);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSearchCourseID;
        private System.Windows.Forms.TextBox txtSearchCourseID;
        private System.Windows.Forms.Label lblSearchCourseID;
    }
}