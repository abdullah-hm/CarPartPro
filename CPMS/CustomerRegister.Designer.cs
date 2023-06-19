﻿
namespace CPMS
{
    partial class CustomerRegister
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
            this.customer_reg_groupbox = new System.Windows.Forms.GroupBox();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_con_password = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_con_password = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.txt_mobileno = new System.Windows.Forms.TextBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_nic = new System.Windows.Forms.Label();
            this.lbl_mobileno = new System.Windows.Forms.Label();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.customer_reg_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_reg_groupbox
            // 
            this.customer_reg_groupbox.Controls.Add(this.dtp_dob);
            this.customer_reg_groupbox.Controls.Add(this.btn_login);
            this.customer_reg_groupbox.Controls.Add(this.btn_clear);
            this.customer_reg_groupbox.Controls.Add(this.btn_register);
            this.customer_reg_groupbox.Controls.Add(this.txt_con_password);
            this.customer_reg_groupbox.Controls.Add(this.txt_password);
            this.customer_reg_groupbox.Controls.Add(this.lbl_con_password);
            this.customer_reg_groupbox.Controls.Add(this.lbl_password);
            this.customer_reg_groupbox.Controls.Add(this.txt_address);
            this.customer_reg_groupbox.Controls.Add(this.txt_username);
            this.customer_reg_groupbox.Controls.Add(this.txt_nic);
            this.customer_reg_groupbox.Controls.Add(this.txt_mobileno);
            this.customer_reg_groupbox.Controls.Add(this.txt_fullname);
            this.customer_reg_groupbox.Controls.Add(this.lbl_address);
            this.customer_reg_groupbox.Controls.Add(this.lbl_dob);
            this.customer_reg_groupbox.Controls.Add(this.lbl_username);
            this.customer_reg_groupbox.Controls.Add(this.lbl_nic);
            this.customer_reg_groupbox.Controls.Add(this.lbl_mobileno);
            this.customer_reg_groupbox.Controls.Add(this.lbl_fullname);
            this.customer_reg_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_reg_groupbox.ForeColor = System.Drawing.Color.Yellow;
            this.customer_reg_groupbox.Location = new System.Drawing.Point(12, 12);
            this.customer_reg_groupbox.Name = "customer_reg_groupbox";
            this.customer_reg_groupbox.Size = new System.Drawing.Size(554, 490);
            this.customer_reg_groupbox.TabIndex = 0;
            this.customer_reg_groupbox.TabStop = false;
            this.customer_reg_groupbox.Text = "C U S T O M E R    R E G I S T E R";
            this.customer_reg_groupbox.Enter += new System.EventHandler(this.customer_reg_groupbox_Enter);
            // 
            // dtp_dob
            // 
            this.dtp_dob.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dob.CalendarForeColor = System.Drawing.Color.White;
            this.dtp_dob.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtp_dob.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtp_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dob.Location = new System.Drawing.Point(20, 241);
            this.dtp_dob.MaxDate = new System.DateTime(2022, 1, 30, 0, 0, 0, 0);
            this.dtp_dob.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(245, 22);
            this.dtp_dob.TabIndex = 5;
            this.dtp_dob.Value = new System.DateTime(2022, 1, 21, 0, 0, 0, 0);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Lime;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(20, 430);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(258, 35);
            this.btn_login.TabIndex = 11;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Yellow;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(284, 430);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(251, 35);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Aqua;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.Black;
            this.btn_register.Location = new System.Drawing.Point(20, 380);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(515, 35);
            this.btn_register.TabIndex = 9;
            this.btn_register.Text = "R e g i s t e r";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_con_password
            // 
            this.txt_con_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_con_password.ForeColor = System.Drawing.Color.White;
            this.txt_con_password.Location = new System.Drawing.Point(286, 318);
            this.txt_con_password.Name = "txt_con_password";
            this.txt_con_password.Size = new System.Drawing.Size(249, 26);
            this.txt_con_password.TabIndex = 8;
            this.txt_con_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_con_password.UseSystemPasswordChar = true;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(20, 318);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(245, 26);
            this.txt_password.TabIndex = 7;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // lbl_con_password
            // 
            this.lbl_con_password.AutoSize = true;
            this.lbl_con_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_con_password.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_con_password.Location = new System.Drawing.Point(282, 295);
            this.lbl_con_password.Name = "lbl_con_password";
            this.lbl_con_password.Size = new System.Drawing.Size(158, 20);
            this.lbl_con_password.TabIndex = 8;
            this.lbl_con_password.Text = "Confirm Password:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_password.Location = new System.Drawing.Point(16, 295);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(91, 20);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Password:";
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_address.ForeColor = System.Drawing.Color.White;
            this.txt_address.Location = new System.Drawing.Point(284, 161);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(251, 26);
            this.txt_address.TabIndex = 4;
            this.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_username.ForeColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(284, 241);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(251, 26);
            this.txt_username.TabIndex = 6;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nic
            // 
            this.txt_nic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_nic.ForeColor = System.Drawing.Color.White;
            this.txt_nic.Location = new System.Drawing.Point(20, 161);
            this.txt_nic.MaxLength = 12;
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(245, 26);
            this.txt_nic.TabIndex = 3;
            this.txt_nic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_mobileno
            // 
            this.txt_mobileno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_mobileno.ForeColor = System.Drawing.Color.White;
            this.txt_mobileno.Location = new System.Drawing.Point(284, 82);
            this.txt_mobileno.MaxLength = 10;
            this.txt_mobileno.Name = "txt_mobileno";
            this.txt_mobileno.Size = new System.Drawing.Size(251, 26);
            this.txt_mobileno.TabIndex = 2;
            this.txt_mobileno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_fullname
            // 
            this.txt_fullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_fullname.ForeColor = System.Drawing.Color.White;
            this.txt_fullname.Location = new System.Drawing.Point(20, 82);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(245, 26);
            this.txt_fullname.TabIndex = 1;
            this.txt_fullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_address.Location = new System.Drawing.Point(280, 138);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(80, 20);
            this.lbl_address.TabIndex = 4;
            this.lbl_address.Text = "Address:";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_dob.Location = new System.Drawing.Point(16, 218);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(52, 20);
            this.lbl_dob.TabIndex = 5;
            this.lbl_dob.Text = "DOB:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_username.Location = new System.Drawing.Point(280, 218);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(103, 20);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "User Name:";
            // 
            // lbl_nic
            // 
            this.lbl_nic.AutoSize = true;
            this.lbl_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nic.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_nic.Location = new System.Drawing.Point(16, 138);
            this.lbl_nic.Name = "lbl_nic";
            this.lbl_nic.Size = new System.Drawing.Size(44, 20);
            this.lbl_nic.TabIndex = 3;
            this.lbl_nic.Text = "NIC:";
            // 
            // lbl_mobileno
            // 
            this.lbl_mobileno.AutoSize = true;
            this.lbl_mobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobileno.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_mobileno.Location = new System.Drawing.Point(280, 59);
            this.lbl_mobileno.Name = "lbl_mobileno";
            this.lbl_mobileno.Size = new System.Drawing.Size(93, 20);
            this.lbl_mobileno.TabIndex = 2;
            this.lbl_mobileno.Text = "Mobile No:";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_fullname.Location = new System.Drawing.Point(16, 59);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(94, 20);
            this.lbl_fullname.TabIndex = 1;
            this.lbl_fullname.Text = "Full Name:";
            // 
            // CustomerRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(580, 514);
            this.Controls.Add(this.customer_reg_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Register";
            this.customer_reg_groupbox.ResumeLayout(false);
            this.customer_reg_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox customer_reg_groupbox;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.TextBox txt_mobileno;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_nic;
        private System.Windows.Forms.Label lbl_mobileno;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.TextBox txt_con_password;
        private System.Windows.Forms.Label lbl_con_password;
    }
}