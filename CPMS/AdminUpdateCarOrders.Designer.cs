
namespace CPMS
{
    partial class AdminUpdateCarOrders
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
            this.cbox_odr_status = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_odr_id = new System.Windows.Forms.TextBox();
            this.lbl_odr_status = new System.Windows.Forms.Label();
            this.lbl_odr_id = new System.Windows.Forms.Label();
            this.admin_add_car_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_add_car_groupbox
            // 
            this.admin_add_car_groupbox.Controls.Add(this.cbox_odr_status);
            this.admin_add_car_groupbox.Controls.Add(this.btn_close);
            this.admin_add_car_groupbox.Controls.Add(this.btn_clear);
            this.admin_add_car_groupbox.Controls.Add(this.btn_update);
            this.admin_add_car_groupbox.Controls.Add(this.txt_odr_id);
            this.admin_add_car_groupbox.Controls.Add(this.lbl_odr_status);
            this.admin_add_car_groupbox.Controls.Add(this.lbl_odr_id);
            this.admin_add_car_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_add_car_groupbox.ForeColor = System.Drawing.Color.Yellow;
            this.admin_add_car_groupbox.Location = new System.Drawing.Point(34, 32);
            this.admin_add_car_groupbox.Name = "admin_add_car_groupbox";
            this.admin_add_car_groupbox.Size = new System.Drawing.Size(406, 411);
            this.admin_add_car_groupbox.TabIndex = 4;
            this.admin_add_car_groupbox.TabStop = false;
            this.admin_add_car_groupbox.Text = "A D M I N    U P D A T E    C A R    O R D E R S";
            // 
            // cbox_odr_status
            // 
            this.cbox_odr_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbox_odr_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_odr_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_odr_status.ForeColor = System.Drawing.Color.White;
            this.cbox_odr_status.FormattingEnabled = true;
            this.cbox_odr_status.IntegralHeight = false;
            this.cbox_odr_status.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Rejected",
            "Delivered"});
            this.cbox_odr_status.Location = new System.Drawing.Point(66, 189);
            this.cbox_odr_status.Name = "cbox_odr_status";
            this.cbox_odr_status.Size = new System.Drawing.Size(251, 24);
            this.cbox_odr_status.TabIndex = 2;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(66, 334);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(251, 35);
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
            this.btn_clear.Location = new System.Drawing.Point(66, 293);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(251, 35);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Aqua;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(66, 252);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(251, 35);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_odr_id
            // 
            this.txt_odr_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_odr_id.ForeColor = System.Drawing.Color.White;
            this.txt_odr_id.Location = new System.Drawing.Point(66, 91);
            this.txt_odr_id.MaxLength = 4;
            this.txt_odr_id.Name = "txt_odr_id";
            this.txt_odr_id.Size = new System.Drawing.Size(251, 26);
            this.txt_odr_id.TabIndex = 1;
            this.txt_odr_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_odr_status
            // 
            this.lbl_odr_status.AutoSize = true;
            this.lbl_odr_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_odr_status.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_odr_status.Location = new System.Drawing.Point(124, 155);
            this.lbl_odr_status.Name = "lbl_odr_status";
            this.lbl_odr_status.Size = new System.Drawing.Size(123, 20);
            this.lbl_odr_status.TabIndex = 4;
            this.lbl_odr_status.Text = "Select Status:";
            // 
            // lbl_odr_id
            // 
            this.lbl_odr_id.AutoSize = true;
            this.lbl_odr_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_odr_id.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_odr_id.Location = new System.Drawing.Point(148, 59);
            this.lbl_odr_id.Name = "lbl_odr_id";
            this.lbl_odr_id.Size = new System.Drawing.Size(83, 20);
            this.lbl_odr_id.TabIndex = 1;
            this.lbl_odr_id.Text = "Order ID:";
            // 
            // AdminUpdateCarOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(477, 473);
            this.Controls.Add(this.admin_add_car_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminUpdateCarOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdminUpdateCarOrders_Load);
            this.admin_add_car_groupbox.ResumeLayout(false);
            this.admin_add_car_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox admin_add_car_groupbox;
        private System.Windows.Forms.ComboBox cbox_odr_status;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_odr_id;
        private System.Windows.Forms.Label lbl_odr_status;
        private System.Windows.Forms.Label lbl_odr_id;
    }
}