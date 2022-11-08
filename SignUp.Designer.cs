namespace PRG_282_Project
{
    partial class SignUp
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
            this.userNametb = new System.Windows.Forms.TextBox();
            this.Confirmtb = new System.Windows.Forms.TextBox();
            this.Passwordtb = new System.Windows.Forms.TextBox();
            this.SignUpbtn = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblCPass = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSignup = new System.Windows.Forms.Label();
            this.lblSignupWeb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNametb
            // 
            this.userNametb.Location = new System.Drawing.Point(229, 95);
            this.userNametb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userNametb.Name = "userNametb";
            this.userNametb.Size = new System.Drawing.Size(152, 20);
            this.userNametb.TabIndex = 0;
            this.userNametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Confirmtb
            // 
            this.Confirmtb.Location = new System.Drawing.Point(229, 188);
            this.Confirmtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Confirmtb.Name = "Confirmtb";
            this.Confirmtb.PasswordChar = '*';
            this.Confirmtb.Size = new System.Drawing.Size(152, 20);
            this.Confirmtb.TabIndex = 1;
            this.Confirmtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Passwordtb
            // 
            this.Passwordtb.Location = new System.Drawing.Point(229, 143);
            this.Passwordtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Passwordtb.Name = "Passwordtb";
            this.Passwordtb.PasswordChar = '*';
            this.Passwordtb.Size = new System.Drawing.Size(152, 20);
            this.Passwordtb.TabIndex = 2;
            this.Passwordtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.BackColor = System.Drawing.Color.Maroon;
            this.SignUpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbtn.ForeColor = System.Drawing.Color.White;
            this.SignUpbtn.Location = new System.Drawing.Point(277, 255);
            this.SignUpbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.Size = new System.Drawing.Size(104, 29);
            this.SignUpbtn.TabIndex = 3;
            this.SignUpbtn.Text = "Sign Up";
            this.SignUpbtn.UseVisualStyleBackColor = false;
            this.SignUpbtn.Click += new System.EventHandler(this.SignUpbtn_click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(72, 99);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(82, 16);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(75, 147);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(79, 16);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password:";
            // 
            // lblCPass
            // 
            this.lblCPass.AutoSize = true;
            this.lblCPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPass.Location = new System.Drawing.Point(75, 188);
            this.lblCPass.Name = "lblCPass";
            this.lblCPass.Size = new System.Drawing.Size(135, 16);
            this.lblCPass.TabIndex = 6;
            this.lblCPass.Text = "Confirm Password:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblSignupWeb);
            this.panel1.Location = new System.Drawing.Point(0, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 45);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(0, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 24);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(0, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 21);
            this.panel3.TabIndex = 9;
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignup.Location = new System.Drawing.Point(174, 9);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(124, 20);
            this.lblSignup.TabIndex = 10;
            this.lblSignup.Text = "Sign Up Form ";
            this.lblSignup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSignupWeb
            // 
            this.lblSignupWeb.AutoSize = true;
            this.lblSignupWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignupWeb.ForeColor = System.Drawing.Color.White;
            this.lblSignupWeb.Location = new System.Drawing.Point(161, 15);
            this.lblSignupWeb.Name = "lblSignupWeb";
            this.lblSignupWeb.Size = new System.Drawing.Size(181, 15);
            this.lblSignupWeb.TabIndex = 1;
            this.lblSignupWeb.Text = "www.belgiumcampus.ac.za";
            this.lblSignupWeb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 412);
            this.Controls.Add(this.lblSignup);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.SignUpbtn);
            this.Controls.Add(this.Passwordtb);
            this.Controls.Add(this.Confirmtb);
            this.Controls.Add(this.userNametb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNametb;
        private System.Windows.Forms.TextBox Confirmtb;
        private System.Windows.Forms.TextBox Passwordtb;
        private System.Windows.Forms.Button SignUpbtn;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblCPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.Label lblSignupWeb;
    }
}