
namespace CPMS
{
    partial class CustomerOrderCarParts
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
            this.admin_add_car_groupbox = new System.Windows.Forms.GroupBox();
            this.cbox_carp_payment = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_buy = new System.Windows.Forms.Button();
            this.txt_carp_price = new System.Windows.Forms.TextBox();
            this.txt_carp_modelno = new System.Windows.Forms.TextBox();
            this.lbl_carp_payment = new System.Windows.Forms.Label();
            this.lbl_carp_price = new System.Windows.Forms.Label();
            this.lbl_carp_modelno = new System.Windows.Forms.Label();
            this.lbl_carp_name = new System.Windows.Forms.Label();
            this.txt_carp_name = new System.Windows.Forms.TextBox();
            this.admin_add_car_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_add_car_groupbox
            // 
            this.admin_add_car_groupbox.Controls.Add(this.cbox_carp_payment);
            this.admin_add_car_groupbox.Controls.Add(this.btn_close);
            this.admin_add_car_groupbox.Controls.Add(this.btn_clear);
            this.admin_add_car_groupbox.Controls.Add(this.btn_buy);
            this.admin_add_car_groupbox.Controls.Add(this.txt_carp_price);
            this.admin_add_car_groupbox.Controls.Add(this.txt_carp_name);
            this.admin_add_car_groupbox.Controls.Add(this.txt_carp_modelno);
            this.admin_add_car_groupbox.Controls.Add(this.lbl_carp_payment);
            this.admin_add_car_groupbox.Controls.Add(this.lbl_carp_price);
            this.admin_add_car_groupbox.Controls.Add(this.lbl_carp_modelno);
            this.admin_add_car_groupbox.Controls.Add(this.lbl_carp_name);
            this.admin_add_car_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_add_car_groupbox.ForeColor = System.Drawing.Color.Yellow;
            this.admin_add_car_groupbox.Location = new System.Drawing.Point(13, 13);
            this.admin_add_car_groupbox.Name = "admin_add_car_groupbox";
            this.admin_add_car_groupbox.Size = new System.Drawing.Size(554, 303);
            this.admin_add_car_groupbox.TabIndex = 4;
            this.admin_add_car_groupbox.TabStop = false;
            this.admin_add_car_groupbox.Text = "C U S T O M E R    B U Y   N E W    C A R   P A R T S";
            // 
            // cbox_carp_payment
            // 
            this.cbox_carp_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbox_carp_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_carp_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_carp_payment.ForeColor = System.Drawing.Color.White;
            this.cbox_carp_payment.FormattingEnabled = true;
            this.cbox_carp_payment.Items.AddRange(new object[] {
            "Card",
            "Cash"});
            this.cbox_carp_payment.Location = new System.Drawing.Point(285, 140);
            this.cbox_carp_payment.Name = "cbox_carp_payment";
            this.cbox_carp_payment.Size = new System.Drawing.Size(251, 24);
            this.cbox_carp_payment.TabIndex = 4;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(19, 247);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(252, 35);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Yellow;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(285, 247);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(251, 35);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.Aqua;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.ForeColor = System.Drawing.Color.Black;
            this.btn_buy.Location = new System.Drawing.Point(20, 196);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(516, 35);
            this.btn_buy.TabIndex = 5;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = false;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // txt_carp_price
            // 
            this.txt_carp_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_carp_price.ForeColor = System.Drawing.Color.White;
            this.txt_carp_price.Location = new System.Drawing.Point(20, 140);
            this.txt_carp_price.Name = "txt_carp_price";
            this.txt_carp_price.Size = new System.Drawing.Size(251, 26);
            this.txt_carp_price.TabIndex = 3;
            this.txt_carp_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_carp_modelno
            // 
            this.txt_carp_modelno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_carp_modelno.ForeColor = System.Drawing.Color.White;
            this.txt_carp_modelno.Location = new System.Drawing.Point(285, 69);
            this.txt_carp_modelno.Name = "txt_carp_modelno";
            this.txt_carp_modelno.Size = new System.Drawing.Size(251, 26);
            this.txt_carp_modelno.TabIndex = 2;
            this.txt_carp_modelno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_carp_payment
            // 
            this.lbl_carp_payment.AutoSize = true;
            this.lbl_carp_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carp_payment.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_carp_payment.Location = new System.Drawing.Point(281, 117);
            this.lbl_carp_payment.Name = "lbl_carp_payment";
            this.lbl_carp_payment.Size = new System.Drawing.Size(126, 20);
            this.lbl_carp_payment.TabIndex = 4;
            this.lbl_carp_payment.Text = "Payment Type:";
            // 
            // lbl_carp_price
            // 
            this.lbl_carp_price.AutoSize = true;
            this.lbl_carp_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carp_price.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_carp_price.Location = new System.Drawing.Point(21, 117);
            this.lbl_carp_price.Name = "lbl_carp_price";
            this.lbl_carp_price.Size = new System.Drawing.Size(121, 20);
            this.lbl_carp_price.TabIndex = 6;
            this.lbl_carp_price.Text = "Car Price(Rs):";
            // 
            // lbl_carp_modelno
            // 
            this.lbl_carp_modelno.AutoSize = true;
            this.lbl_carp_modelno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carp_modelno.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_carp_modelno.Location = new System.Drawing.Point(281, 46);
            this.lbl_carp_modelno.Name = "lbl_carp_modelno";
            this.lbl_carp_modelno.Size = new System.Drawing.Size(127, 20);
            this.lbl_carp_modelno.TabIndex = 2;
            this.lbl_carp_modelno.Text = "Part Model No:";
            // 
            // lbl_carp_name
            // 
            this.lbl_carp_name.AutoSize = true;
            this.lbl_carp_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carp_name.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_carp_name.Location = new System.Drawing.Point(16, 46);
            this.lbl_carp_name.Name = "lbl_carp_name";
            this.lbl_carp_name.Size = new System.Drawing.Size(131, 20);
            this.lbl_carp_name.TabIndex = 1;
            this.lbl_carp_name.Text = "Car Part Name:";
            // 
            // txt_carp_name
            // 
            this.txt_carp_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_carp_name.ForeColor = System.Drawing.Color.White;
            this.txt_carp_name.Location = new System.Drawing.Point(24, 69);
            this.txt_carp_name.Name = "txt_carp_name";
            this.txt_carp_name.Size = new System.Drawing.Size(251, 26);
            this.txt_carp_name.TabIndex = 2;
            this.txt_carp_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomerOrderCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(580, 329);
            this.Controls.Add(this.admin_add_car_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerOrderCarParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.admin_add_car_groupbox.ResumeLayout(false);
            this.admin_add_car_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox admin_add_car_groupbox;
        private System.Windows.Forms.ComboBox cbox_carp_payment;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.TextBox txt_carp_price;
        private System.Windows.Forms.TextBox txt_carp_modelno;
        private System.Windows.Forms.Label lbl_carp_payment;
        private System.Windows.Forms.Label lbl_carp_price;
        private System.Windows.Forms.Label lbl_carp_modelno;
        private System.Windows.Forms.Label lbl_carp_name;
        private System.Windows.Forms.TextBox txt_carp_name;
    }
}