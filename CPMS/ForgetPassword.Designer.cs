
namespace CPMS
{
    partial class ForgetPassword
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
            this.forget_password_groupbox = new System.Windows.Forms.GroupBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_con_password = new System.Windows.Forms.TextBox();
            this.lbl_con_password = new System.Windows.Forms.Label();
            this.txt_new_password = new System.Windows.Forms.TextBox();
            this.lbl_new_password = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_mobileno = new System.Windows.Forms.TextBox();
            this.lbl_mobileno = new System.Windows.Forms.Label();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.lbl_nic = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.forget_password_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // forget_password_groupbox
            // 
            this.forget_password_groupbox.Controls.Add(this.btn_login);
            this.forget_password_groupbox.Controls.Add(this.txt_con_password);
            this.forget_password_groupbox.Controls.Add(this.lbl_con_password);
            this.forget_password_groupbox.Controls.Add(this.txt_new_password);
            this.forget_password_groupbox.Controls.Add(this.lbl_new_password);
            this.forget_password_groupbox.Controls.Add(this.btn_clear);
            this.forget_password_groupbox.Controls.Add(this.btn_submit);
            this.forget_password_groupbox.Controls.Add(this.txt_mobileno);
            this.forget_password_groupbox.Controls.Add(this.lbl_mobileno);
            this.forget_password_groupbox.Controls.Add(this.txt_nic);
            this.forget_password_groupbox.Controls.Add(this.lbl_nic);
            this.forget_password_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forget_password_groupbox.ForeColor = System.Drawing.Color.Red;
            this.forget_password_groupbox.Location = new System.Drawing.Point(12, 12);
            this.forget_password_groupbox.Name = "forget_password_groupbox";
            this.forget_password_groupbox.Size = new System.Drawing.Size(353, 422);
            this.forget_password_groupbox.TabIndex = 0;
            this.forget_password_groupbox.TabStop = false;
            this.forget_password_groupbox.Text = "CUSTOMER PASSWORD RECOVERY";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Lime;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(32, 367);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(140, 35);
            this.btn_login.TabIndex = 12;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_con_password
            // 
            this.txt_con_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_con_password.ForeColor = System.Drawing.Color.White;
            this.txt_con_password.Location = new System.Drawing.Point(32, 279);
            this.txt_con_password.Name = "txt_con_password";
            this.txt_con_password.Size = new System.Drawing.Size(287, 26);
            this.txt_con_password.TabIndex = 4;
            this.txt_con_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_con_password.UseSystemPasswordChar = true;
            // 
            // lbl_con_password
            // 
            this.lbl_con_password.AutoSize = true;
            this.lbl_con_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_con_password.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_con_password.Location = new System.Drawing.Point(30, 256);
            this.lbl_con_password.Name = "lbl_con_password";
            this.lbl_con_password.Size = new System.Drawing.Size(158, 20);
            this.lbl_con_password.TabIndex = 4;
            this.lbl_con_password.Text = "Confirm Password:";
            // 
            // txt_new_password
            // 
            this.txt_new_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_new_password.ForeColor = System.Drawing.Color.White;
            this.txt_new_password.Location = new System.Drawing.Point(32, 208);
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.Size = new System.Drawing.Size(287, 26);
            this.txt_new_password.TabIndex = 3;
            this.txt_new_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_new_password.UseSystemPasswordChar = true;
            // 
            // lbl_new_password
            // 
            this.lbl_new_password.AutoSize = true;
            this.lbl_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_password.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_new_password.Location = new System.Drawing.Point(30, 185);
            this.lbl_new_password.Name = "lbl_new_password";
            this.lbl_new_password.Size = new System.Drawing.Size(130, 20);
            this.lbl_new_password.TabIndex = 3;
            this.lbl_new_password.Text = "New Password:";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Yellow;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(179, 367);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(140, 35);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Aqua;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.Black;
            this.btn_submit.Location = new System.Drawing.Point(32, 326);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(287, 35);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_mobileno
            // 
            this.txt_mobileno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_mobileno.ForeColor = System.Drawing.Color.White;
            this.txt_mobileno.Location = new System.Drawing.Point(32, 137);
            this.txt_mobileno.MaxLength = 10;
            this.txt_mobileno.Name = "txt_mobileno";
            this.txt_mobileno.Size = new System.Drawing.Size(287, 26);
            this.txt_mobileno.TabIndex = 2;
            this.txt_mobileno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_mobileno
            // 
            this.lbl_mobileno.AutoSize = true;
            this.lbl_mobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobileno.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_mobileno.Location = new System.Drawing.Point(28, 114);
            this.lbl_mobileno.Name = "lbl_mobileno";
            this.lbl_mobileno.Size = new System.Drawing.Size(93, 20);
            this.lbl_mobileno.TabIndex = 2;
            this.lbl_mobileno.Text = "Mobile No:";
            // 
            // txt_nic
            // 
            this.txt_nic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_nic.ForeColor = System.Drawing.Color.White;
            this.txt_nic.Location = new System.Drawing.Point(32, 71);
            this.txt_nic.MaxLength = 12;
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(287, 26);
            this.txt_nic.TabIndex = 1;
            this.txt_nic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nic
            // 
            this.lbl_nic.AutoSize = true;
            this.lbl_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nic.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_nic.Location = new System.Drawing.Point(28, 48);
            this.lbl_nic.Name = "lbl_nic";
            this.lbl_nic.Size = new System.Drawing.Size(44, 20);
            this.lbl_nic.TabIndex = 1;
            this.lbl_nic.Text = "NIC:";
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(378, 447);
            this.Controls.Add(this.forget_password_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.forget_password_groupbox.ResumeLayout(false);
            this.forget_password_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox forget_password_groupbox;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_mobileno;
        private System.Windows.Forms.Label lbl_mobileno;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.Label lbl_nic;
        private System.Windows.Forms.TextBox txt_new_password;
        private System.Windows.Forms.Label lbl_new_password;
        private System.Windows.Forms.TextBox txt_con_password;
        private System.Windows.Forms.Label lbl_con_password;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_login;
    }
}