namespace PRG_282_Project
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnModuleForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenuWeb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnStudentForm = new System.Windows.Forms.Button();
            this.picBoxMenu = new System.Windows.Forms.PictureBox();
            this.groupBoxLecturers = new System.Windows.Forms.GroupBox();
            this.dataGridViewLecturers = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenu)).BeginInit();
            this.groupBoxLecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModuleForm
            // 
            this.btnModuleForm.BackColor = System.Drawing.Color.Maroon;
            this.btnModuleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModuleForm.ForeColor = System.Drawing.Color.White;
            this.btnModuleForm.Image = ((System.Drawing.Image)(resources.GetObject("btnModuleForm.Image")));
            this.btnModuleForm.Location = new System.Drawing.Point(85, 234);
            this.btnModuleForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnModuleForm.Name = "btnModuleForm";
            this.btnModuleForm.Size = new System.Drawing.Size(559, 68);
            this.btnModuleForm.TabIndex = 1;
            this.btnModuleForm.Text = "Module";
            this.btnModuleForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModuleForm.UseVisualStyleBackColor = false;
            this.btnModuleForm.Click += new System.EventHandler(this.btnModuleForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(85, 335);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(559, 69);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit ";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblMenuWeb);
            this.panel1.Location = new System.Drawing.Point(-1, 459);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 48);
            this.panel1.TabIndex = 3;
            // 
            // lblMenuWeb
            // 
            this.lblMenuWeb.AutoSize = true;
            this.lblMenuWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuWeb.ForeColor = System.Drawing.Color.White;
            this.lblMenuWeb.Location = new System.Drawing.Point(452, 16);
            this.lblMenuWeb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuWeb.Name = "lblMenuWeb";
            this.lblMenuWeb.Size = new System.Drawing.Size(212, 18);
            this.lblMenuWeb.TabIndex = 0;
            this.lblMenuWeb.Text = "www.belgiumcampus.ac.za";
            this.lblMenuWeb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(-1, 448);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 23);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(-1, 431);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1155, 21);
            this.panel3.TabIndex = 5;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(321, 59);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(77, 29);
            this.lblMenu.TabIndex = 7;
            this.lblMenu.Text = "Menu";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStudentForm
            // 
            this.btnStudentForm.BackColor = System.Drawing.Color.Maroon;
            this.btnStudentForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnStudentForm.ForeColor = System.Drawing.Color.White;
            this.btnStudentForm.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentForm.Image")));
            this.btnStudentForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStudentForm.Location = new System.Drawing.Point(88, 122);
            this.btnStudentForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentForm.Name = "btnStudentForm";
            this.btnStudentForm.Size = new System.Drawing.Size(556, 70);
            this.btnStudentForm.TabIndex = 8;
            this.btnStudentForm.Text = "Student";
            this.btnStudentForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudentForm.UseVisualStyleBackColor = false;
            this.btnStudentForm.Click += new System.EventHandler(this.btnStudentForm_Click);
            // 
            // picBoxMenu
            // 
            this.picBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMenu.Image")));
            this.picBoxMenu.Location = new System.Drawing.Point(16, 15);
            this.picBoxMenu.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxMenu.Name = "picBoxMenu";
            this.picBoxMenu.Size = new System.Drawing.Size(136, 74);
            this.picBoxMenu.TabIndex = 9;
            this.picBoxMenu.TabStop = false;
            // 
            // groupBoxLecturers
            // 
            this.groupBoxLecturers.BackColor = System.Drawing.Color.Gold;
            this.groupBoxLecturers.Controls.Add(this.dataGridViewLecturers);
            this.groupBoxLecturers.Location = new System.Drawing.Point(652, 46);
            this.groupBoxLecturers.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLecturers.Name = "groupBoxLecturers";
            this.groupBoxLecturers.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLecturers.Size = new System.Drawing.Size(499, 358);
            this.groupBoxLecturers.TabIndex = 10;
            this.groupBoxLecturers.TabStop = false;
            this.groupBoxLecturers.Text = "Lecturers";
            // 
            // dataGridViewLecturers
            // 
            this.dataGridViewLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecturers.Location = new System.Drawing.Point(8, 23);
            this.dataGridViewLecturers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewLecturers.Name = "dataGridViewLecturers";
            this.dataGridViewLecturers.RowHeadersWidth = 51;
            this.dataGridViewLecturers.Size = new System.Drawing.Size(483, 279);
            this.dataGridViewLecturers.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 508);
            this.Controls.Add(this.groupBoxLecturers);
            this.Controls.Add(this.picBoxMenu);
            this.Controls.Add(this.btnStudentForm);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnModuleForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenu)).EndInit();
            this.groupBoxLecturers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModuleForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMenuWeb;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnStudentForm;
        private System.Windows.Forms.PictureBox picBoxMenu;
        private System.Windows.Forms.GroupBox groupBoxLecturers;
        private System.Windows.Forms.DataGridView dataGridViewLecturers;
    }
}