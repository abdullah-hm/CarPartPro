
namespace CPMS
{
    partial class CustomerOrderCar
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
            this.components = new System.ComponentModel.Container();
            this.admin_add_car_groupbox = new System.Windows.Forms.GroupBox();
            this.cbox_car_payment = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_buy = new System.Windows.Forms.Button();
            this.txt_car_price = new System.Windows.Forms.TextBox();
            this.txt_car_brand = new System.Windows.Forms.TextBox();
            this.lbl_car_payment = new System.Windows.Forms.Label();
            this.lbl_car_price = new System.Windows.Forms.Label();
            this.lbl_car_brand = new System.Windows.Forms.Label();
            this.lbl_car_name = new System.Windows.Forms.Label();
            this.cbox_car_name = new System.Windows.Forms.ComboBox();
            this.cPMS_DBDataSet = new CPMS.CPMS_DBDataSet();
            this.cPMSDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPMSDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cPMSDBDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblcarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_carTableAdapter = new CPMS.CPMS_DBDataSetTableAdapters.tbl_carTableAdapter();
            this.admin_add_car_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPMS_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPMSDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPMSDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPMSDBDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_add_car_groupbox
            // 
            this.admin_add_car_groupbox.Controls.Add(this.cbox_car_name);
            this.admin_add_car_groupbox.Controls.Add(this.cbox_car_payment);
            this.admin_add_car_groupbox.Controls.Add(this.btn_close);
            this.admin_add_car_groupbox.Controls.Add(this.btn_clear);
            this.admin_add_car_groupbox.Controls.Add(this.btn_buy);
            this.admin_add_car_groupbox.Controls.Add(this.txt_car_price);
            this.admin_add_car_groupbox.Controls.Add(this.txt_car_brand);
            this.admin_add_car_groupbox.Controls.Add(this.lbl_car_payment);
            this.admin_add_car_groupbox.Controls.Add(this.lbl_car_price);
            this.admin_add_car_groupbox.Controls.Add(this.lbl_car_brand);
            this.admin_add_car_groupbox.Controls.Add(this.lbl_car_name);
            this.admin_add_car_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_add_car_groupbox.ForeColor = System.Drawing.Color.Yellow;
            this.admin_add_car_groupbox.Location = new System.Drawing.Point(13, 15);
            this.admin_add_car_groupbox.Name = "admin_add_car_groupbox";
            this.admin_add_car_groupbox.Size = new System.Drawing.Size(554, 303);
            this.admin_add_car_groupbox.TabIndex = 3;
            this.admin_add_car_groupbox.TabStop = false;
            this.admin_add_car_groupbox.Text = "C U S T O M E R    B U Y   N E W    C A R";
            // 
            // cbox_car_payment
            // 
            this.cbox_car_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbox_car_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_car_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_car_payment.ForeColor = System.Drawing.Color.White;
            this.cbox_car_payment.FormattingEnabled = true;
            this.cbox_car_payment.Items.AddRange(new object[] {
            "Card",
            "Cash"});
            this.cbox_car_payment.Location = new System.Drawing.Point(285, 140);
            this.cbox_car_payment.Name = "cbox_car_payment";
            this.cbox_car_payment.Size = new System.Drawing.Size(251, 24);
            this.cbox_car_payment.TabIndex = 4;
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
            // txt_car_price
            // 
            this.txt_car_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_car_price.ForeColor = System.Drawing.Color.White;
            this.txt_car_price.Location = new System.Drawing.Point(20, 140);
            this.txt_car_price.Name = "txt_car_price";
            this.txt_car_price.Size = new System.Drawing.Size(251, 26);
            this.txt_car_price.TabIndex = 3;
            this.txt_car_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_car_brand
            // 
            this.txt_car_brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_car_brand.ForeColor = System.Drawing.Color.White;
            this.txt_car_brand.Location = new System.Drawing.Point(285, 69);
            this.txt_car_brand.Name = "txt_car_brand";
            this.txt_car_brand.Size = new System.Drawing.Size(251, 26);
            this.txt_car_brand.TabIndex = 2;
            this.txt_car_brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_car_payment
            // 
            this.lbl_car_payment.AutoSize = true;
            this.lbl_car_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_car_payment.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_car_payment.Location = new System.Drawing.Point(281, 117);
            this.lbl_car_payment.Name = "lbl_car_payment";
            this.lbl_car_payment.Size = new System.Drawing.Size(126, 20);
            this.lbl_car_payment.TabIndex = 4;
            this.lbl_car_payment.Text = "Payment Type:";
            // 
            // lbl_car_price
            // 
            this.lbl_car_price.AutoSize = true;
            this.lbl_car_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_car_price.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_car_price.Location = new System.Drawing.Point(21, 117);
            this.lbl_car_price.Name = "lbl_car_price";
            this.lbl_car_price.Size = new System.Drawing.Size(121, 20);
            this.lbl_car_price.TabIndex = 6;
            this.lbl_car_price.Text = "Car Price(Rs):";
            // 
            // lbl_car_brand
            // 
            this.lbl_car_brand.AutoSize = true;
            this.lbl_car_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_car_brand.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_car_brand.Location = new System.Drawing.Point(281, 46);
            this.lbl_car_brand.Name = "lbl_car_brand";
            this.lbl_car_brand.Size = new System.Drawing.Size(95, 20);
            this.lbl_car_brand.TabIndex = 2;
            this.lbl_car_brand.Text = "Car Brand:";
            // 
            // lbl_car_name
            // 
            this.lbl_car_name.AutoSize = true;
            this.lbl_car_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_car_name.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_car_name.Location = new System.Drawing.Point(16, 46);
            this.lbl_car_name.Name = "lbl_car_name";
            this.lbl_car_name.Size = new System.Drawing.Size(93, 20);
            this.lbl_car_name.TabIndex = 1;
            this.lbl_car_name.Text = "Car Name:";
            // 
            // cbox_car_name
            // 
            this.cbox_car_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbox_car_name.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblcarBindingSource, "name", true));
            this.cbox_car_name.DataSource = this.tblcarBindingSource;
            this.cbox_car_name.DisplayMember = "name";
            this.cbox_car_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_car_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_car_name.ForeColor = System.Drawing.Color.White;
            this.cbox_car_name.FormattingEnabled = true;
            this.cbox_car_name.Location = new System.Drawing.Point(19, 72);
            this.cbox_car_name.Name = "cbox_car_name";
            this.cbox_car_name.Size = new System.Drawing.Size(252, 24);
            this.cbox_car_name.TabIndex = 8;
            this.cbox_car_name.ValueMember = "name";
            // 
            // cPMS_DBDataSet
            // 
            this.cPMS_DBDataSet.DataSetName = "CPMS_DBDataSet";
            this.cPMS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cPMSDBDataSetBindingSource
            // 
            this.cPMSDBDataSetBindingSource.DataSource = this.cPMS_DBDataSet;
            this.cPMSDBDataSetBindingSource.Position = 0;
            // 
            // cPMSDBDataSetBindingSource1
            // 
            this.cPMSDBDataSetBindingSource1.DataSource = this.cPMS_DBDataSet;
            this.cPMSDBDataSetBindingSource1.Position = 0;
            // 
            // cPMSDBDataSetBindingSource2
            // 
            this.cPMSDBDataSetBindingSource2.DataSource = this.cPMS_DBDataSet;
            this.cPMSDBDataSetBindingSource2.Position = 0;
            // 
            // tblcarBindingSource
            // 
            this.tblcarBindingSource.DataMember = "tbl_car";
            this.tblcarBindingSource.DataSource = this.cPMSDBDataSetBindingSource;
            // 
            // tbl_carTableAdapter
            // 
            this.tbl_carTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerOrderCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(580, 329);
            this.Controls.Add(this.admin_add_car_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerOrderCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CustomerOrderCar_Load);
            this.admin_add_car_groupbox.ResumeLayout(false);
            this.admin_add_car_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPMS_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPMSDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPMSDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPMSDBDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox admin_add_car_groupbox;
        private System.Windows.Forms.ComboBox cbox_car_payment;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.TextBox txt_car_price;
        private System.Windows.Forms.TextBox txt_car_brand;
        private System.Windows.Forms.Label lbl_car_payment;
        private System.Windows.Forms.Label lbl_car_price;
        private System.Windows.Forms.Label lbl_car_brand;
        private System.Windows.Forms.Label lbl_car_name;
        private System.Windows.Forms.ComboBox cbox_car_name;
        private CPMS_DBDataSet cPMS_DBDataSet;
        private System.Windows.Forms.BindingSource cPMSDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource cPMSDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource cPMSDBDataSetBindingSource2;
        private System.Windows.Forms.BindingSource tblcarBindingSource;
        private CPMS_DBDataSetTableAdapters.tbl_carTableAdapter tbl_carTableAdapter;
    }
}