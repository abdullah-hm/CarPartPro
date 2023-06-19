
namespace CPMS
{
    partial class CustomerLogin
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
            this.customer_login_groupbox = new System.Windows.Forms.GroupBox();
            this.lbl_link_forget_password = new System.Windows.Forms.LinkLabel();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.customer_login_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_login_groupbox
            // 
            this.customer_login_groupbox.Controls.Add(this.lbl_link_forget_password);
            this.customer_login_groupbox.Controls.Add(this.btn_register);
            this.customer_login_groupbox.Controls.Add(this.btn_clear);
            this.customer_login_groupbox.Controls.Add(this.btn_login);
            this.customer_login_groupbox.Controls.Add(this.txt_password);
            this.customer_login_groupbox.Controls.Add(this.lbl_password);
            this.customer_login_groupbox.Controls.Add(this.txt_username);
            this.customer_login_groupbox.Controls.Add(this.lbl_username);
            this.customer_login_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_login_groupbox.ForeColor = System.Drawing.Color.OrangeRed;
            this.customer_login_groupbox.Location = new System.Drawing.Point(12, 12);
            this.customer_login_groupbox.Name = "customer_login_groupbox";
            this.customer_login_groupbox.Size = new System.Drawing.Size(353, 353);
            this.customer_login_groupbox.TabIndex = 0;
            this.customer_login_groupbox.TabStop = false;
            this.customer_login_groupbox.Text = "C U S T O M E R    L O G I N";
            // 
            // lbl_link_forget_password
            // 
            this.lbl_link_forget_password.AutoSize = true;
            this.lbl_link_forget_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_link_forget_password.LinkColor = System.Drawing.Color.White;
            this.lbl_link_forget_password.Location = new System.Drawing.Point(99, 200);
            this.lbl_link_forget_password.Name = "lbl_link_forget_password";
            this.lbl_link_forget_password.Size = new System.Drawing.Size(146, 18);
            this.lbl_link_forget_password.TabIndex = 6;
            this.lbl_link_forget_password.TabStop = true;
            this.lbl_link_forget_password.Text = "Forget Password?";
            this.lbl_link_forget_password.VisitedLinkColor = System.Drawing.Color.Aqua;
            this.lbl_link_forget_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_link_forget_password_LinkClicked);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Aqua;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.Black;
            this.btn_register.Location = new System.Drawing.Point(32, 287);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(136, 35);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Yellow;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(183, 287);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(136, 35);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Lime;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(32, 237);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(287, 35);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(32, 160);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(287, 26);
            this.txt_password.TabIndex = 2;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_password.Location = new System.Drawing.Point(28, 137);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(91, 20);
            this.lbl_password.TabIndex = 0;
            this.lbl_password.Text = "Password:";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_username.ForeColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(32, 82);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(287, 26);
            this.txt_username.TabIndex = 1;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_username.Location = new System.Drawing.Point(28, 59);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(103, 20);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "User Name:";
            // 
            // CustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(377, 377);
            this.Controls.Add(this.customer_login_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.customer_login_groupbox.ResumeLayout(false);
            this.customer_login_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox customer_login_groupbox;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.LinkLabel lbl_link_forget_password;
    }
}