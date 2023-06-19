
namespace CPMS
{
    partial class AdminAddCarParts
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
            this.admin_add_car_parts_groupbox = new System.Windows.Forms.GroupBox();
            this.tblcarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPMS_DBDataSet = new CPMS.CPMS_DBDataSet();
            this.cbox_parts_status = new System.Windows.Forms.ComboBox();
            this.cbox_parts_color = new System.Windows.Forms.ComboBox();
            this.cbox_car_name = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_parts_status = new System.Windows.Forms.Label();
            this.txt_parts_price = new System.Windows.Forms.TextBox();
            this.txt_parts_modelno = new System.Windows.Forms.TextBox();
            this.txt_parts_name = new System.Windows.Forms.TextBox();
            this.lbl_parts_color = new System.Windows.Forms.Label();
            this.lbl_parts_price = new System.Windows.Forms.Label();
            this.lbl_parts_modelno = new System.Windows.Forms.Label();
            this.lbl_parts_name = new System.Windows.Forms.Label();
            this.lbl_car_name = new System.Windows.Forms.Label();
            this.tbl_carTableAdapter = new CPMS.CPMS_DBDataSetTableAdapters.tbl_carTableAdapter();
            this.admin_add_car_parts_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblcarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPMS_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_add_car_parts_groupbox
            // 
            this.admin_add_car_parts_groupbox.Controls.Add(this.cbox_parts_status);
            this.admin_add_car_parts_groupbox.Controls.Add(this.cbox_parts_color);
            this.admin_add_car_parts_groupbox.Controls.Add(this.cbox_car_name);
            this.admin_add_car_parts_groupbox.Controls.Add(this.btn_close);
            this.admin_add_car_parts_groupbox.Controls.Add(this.btn_clear);
            this.admin_add_car_parts_groupbox.Controls.Add(this.btn_add);
            this.admin_add_car_parts_groupbox.Controls.Add(this.lbl_parts_status);
            this.admin_add_car_parts_groupbox.Controls.Add(this.txt_parts_price);
            this.admin_add_car_parts_groupbox.Controls.Add(this.txt_parts_modelno);
            this.admin_add_car_parts_groupbox.Controls.Add(this.txt_parts_name);
            this.admin_add_car_parts_groupbox.Controls.Add(this.lbl_parts_color);
            this.admin_add_car_parts_groupbox.Controls.Add(this.lbl_parts_price);
            this.admin_add_car_parts_groupbox.Controls.Add(this.lbl_parts_modelno);
            this.admin_add_car_parts_groupbox.Controls.Add(this.lbl_parts_name);
            this.admin_add_car_parts_groupbox.Controls.Add(this.lbl_car_name);
            this.admin_add_car_parts_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_add_car_parts_groupbox.ForeColor = System.Drawing.Color.Yellow;
            this.admin_add_car_parts_groupbox.Location = new System.Drawing.Point(13, 15);
            this.admin_add_car_parts_groupbox.Name = "admin_add_car_parts_groupbox";
            this.admin_add_car_parts_groupbox.Size = new System.Drawing.Size(555, 396);
            this.admin_add_car_parts_groupbox.TabIndex = 3;
            this.admin_add_car_parts_groupbox.TabStop = false;
            this.admin_add_car_parts_groupbox.Text = "A D M I N    A D D    N E W    C A R    P A R T S";
            // 
            // tblcarBindingSource
            // 
            this.tblcarBindingSource.DataMember = "tbl_car";
            this.tblcarBindingSource.DataSource = this.cPMS_DBDataSet;
            // 
            // cPMS_DBDataSet
            // 
            this.cPMS_DBDataSet.DataSetName = "CPMS_DBDataSet";
            this.cPMS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbox_parts_status
            // 
            this.cbox_parts_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbox_parts_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_parts_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_parts_status.ForeColor = System.Drawing.Color.White;
            this.cbox_parts_status.FormattingEnabled = true;
            this.cbox_parts_status.Items.AddRange(new object[] {
            "in stock",
            "out stock"});
            this.cbox_parts_status.Location = new System.Drawing.Point(290, 231);
            this.cbox_parts_status.Name = "cbox_parts_status";
            this.cbox_parts_status.Size = new System.Drawing.Size(245, 24);
            this.cbox_parts_status.TabIndex = 5;
            // 
            // cbox_parts_color
            // 
            this.cbox_parts_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbox_parts_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_parts_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_parts_color.ForeColor = System.Drawing.Color.White;
            this.cbox_parts_color.FormattingEnabled = true;
            this.cbox_parts_color.Items.AddRange(new object[] {
            "Black",
            "White",
            "Blue",
            "Red",
            "Green",
            "Gray",
            "Yellow",
            "Purple",
            "Orange"});
            this.cbox_parts_color.Location = new System.Drawing.Point(20, 231);
            this.cbox_parts_color.Name = "cbox_parts_color";
            this.cbox_parts_color.Size = new System.Drawing.Size(245, 24);
            this.cbox_parts_color.TabIndex = 5;
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
            this.cbox_car_name.Location = new System.Drawing.Point(20, 85);
            this.cbox_car_name.Name = "cbox_car_name";
            this.cbox_car_name.Size = new System.Drawing.Size(245, 24);
            this.cbox_car_name.TabIndex = 1;
            this.cbox_car_name.ValueMember = "name";
            this.cbox_car_name.SelectedIndexChanged += new System.EventHandler(this.cbox_car_name_SelectedIndexChanged);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(20, 336);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(258, 35);
            this.btn_close.TabIndex = 10;
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
            this.btn_clear.Location = new System.Drawing.Point(284, 336);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(251, 35);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Aqua;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(20, 281);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(515, 35);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Save";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_parts_status
            // 
            this.lbl_parts_status.AutoSize = true;
            this.lbl_parts_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parts_status.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_parts_status.Location = new System.Drawing.Point(280, 208);
            this.lbl_parts_status.Name = "lbl_parts_status";
            this.lbl_parts_status.Size = new System.Drawing.Size(165, 20);
            this.lbl_parts_status.TabIndex = 6;
            this.lbl_parts_status.Text = "Parts Stock Status:";
            // 
            // txt_parts_price
            // 
            this.txt_parts_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_parts_price.ForeColor = System.Drawing.Color.White;
            this.txt_parts_price.Location = new System.Drawing.Point(284, 158);
            this.txt_parts_price.Name = "txt_parts_price";
            this.txt_parts_price.Size = new System.Drawing.Size(251, 26);
            this.txt_parts_price.TabIndex = 4;
            this.txt_parts_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_parts_modelno
            // 
            this.txt_parts_modelno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_parts_modelno.ForeColor = System.Drawing.Color.White;
            this.txt_parts_modelno.Location = new System.Drawing.Point(20, 158);
            this.txt_parts_modelno.MaxLength = 8;
            this.txt_parts_modelno.Name = "txt_parts_modelno";
            this.txt_parts_modelno.Size = new System.Drawing.Size(245, 26);
            this.txt_parts_modelno.TabIndex = 3;
            this.txt_parts_modelno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_parts_name
            // 
            this.txt_parts_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_parts_name.ForeColor = System.Drawing.Color.White;
            this.txt_parts_name.Location = new System.Drawing.Point(284, 82);
            this.txt_parts_name.Name = "txt_parts_name";
            this.txt_parts_name.Size = new System.Drawing.Size(251, 26);
            this.txt_parts_name.TabIndex = 2;
            this.txt_parts_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_parts_color
            // 
            this.lbl_parts_color.AutoSize = true;
            this.lbl_parts_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parts_color.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_parts_color.Location = new System.Drawing.Point(21, 208);
            this.lbl_parts_color.Name = "lbl_parts_color";
            this.lbl_parts_color.Size = new System.Drawing.Size(94, 20);
            this.lbl_parts_color.TabIndex = 5;
            this.lbl_parts_color.Text = "Part Color:";
            // 
            // lbl_parts_price
            // 
            this.lbl_parts_price.AutoSize = true;
            this.lbl_parts_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parts_price.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_parts_price.Location = new System.Drawing.Point(280, 135);
            this.lbl_parts_price.Name = "lbl_parts_price";
            this.lbl_parts_price.Size = new System.Drawing.Size(126, 20);
            this.lbl_parts_price.TabIndex = 4;
            this.lbl_parts_price.Text = "Part Price(Rs):";
            // 
            // lbl_parts_modelno
            // 
            this.lbl_parts_modelno.AutoSize = true;
            this.lbl_parts_modelno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parts_modelno.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_parts_modelno.Location = new System.Drawing.Point(21, 135);
            this.lbl_parts_modelno.Name = "lbl_parts_modelno";
            this.lbl_parts_modelno.Size = new System.Drawing.Size(127, 20);
            this.lbl_parts_modelno.TabIndex = 3;
            this.lbl_parts_modelno.Text = "Part Model No:";
            // 
            // lbl_parts_name
            // 
            this.lbl_parts_name.AutoSize = true;
            this.lbl_parts_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parts_name.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_parts_name.Location = new System.Drawing.Point(280, 59);
            this.lbl_parts_name.Name = "lbl_parts_name";
            this.lbl_parts_name.Size = new System.Drawing.Size(98, 20);
            this.lbl_parts_name.TabIndex = 2;
            this.lbl_parts_name.Text = "Part Name:";
            // 
            // lbl_car_name
            // 
            this.lbl_car_name.AutoSize = true;
            this.lbl_car_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_car_name.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_car_name.Location = new System.Drawing.Point(16, 59);
            this.lbl_car_name.Name = "lbl_car_name";
            this.lbl_car_name.Size = new System.Drawing.Size(93, 20);
            this.lbl_car_name.TabIndex = 1;
            this.lbl_car_name.Text = "Car Name:";
            // 
            // tbl_carTableAdapter
            // 
            this.tbl_carTableAdapter.ClearBeforeFill = true;
            // 
            // AdminAddCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(580, 427);
            this.Controls.Add(this.admin_add_car_parts_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminAddCarParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdminAddCarParts_Load);
            this.admin_add_car_parts_groupbox.ResumeLayout(false);
            this.admin_add_car_parts_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblcarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPMS_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox admin_add_car_parts_groupbox;
        private System.Windows.Forms.ComboBox cbox_parts_color;
        private System.Windows.Forms.ComboBox cbox_car_name;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_parts_status;
        private System.Windows.Forms.TextBox txt_parts_price;
        private System.Windows.Forms.TextBox txt_parts_modelno;
        private System.Windows.Forms.TextBox txt_parts_name;
        private System.Windows.Forms.Label lbl_parts_color;
        private System.Windows.Forms.Label lbl_parts_price;
        private System.Windows.Forms.Label lbl_parts_modelno;
        private System.Windows.Forms.Label lbl_parts_name;
        private System.Windows.Forms.Label lbl_car_name;
        private CPMS_DBDataSet cPMS_DBDataSet;
        private System.Windows.Forms.BindingSource tblcarBindingSource;
        private CPMS_DBDataSetTableAdapters.tbl_carTableAdapter tbl_carTableAdapter;
        private System.Windows.Forms.ComboBox cbox_parts_status;
    }
}