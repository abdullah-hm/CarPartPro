using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPMS
{
    public partial class AdminAddCarParts : Form
    {

        private readonly AdminManageCarParts _parent;
        public string cpid, pcarname, ppartname, pmodelno, pcolor, pprice, pstatus;

        public AdminAddCarParts(AdminManageCarParts parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void AdminAddCarParts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPMS_DBDataSet.tbl_car' table. You can move, or remove it, as needed.
            this.tbl_carTableAdapter.Fill(this.cPMS_DBDataSet.tbl_car);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_carTableAdapter.FillBy(this.cPMS_DBDataSet.tbl_car);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cbox_car_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // set existing values to the input fields
        public void UpdateInfo()
        {
            admin_add_car_parts_groupbox.Text = "ADMIN UPDATE CAR PARTS DETAILS";
            btn_add.Text = "Update";

            cbox_car_name.Text = pcarname;
            txt_parts_name.Text = ppartname;
            txt_parts_modelno.Text = pmodelno;
            cbox_parts_color.Text = pcolor;
            txt_parts_price.Text = pprice;
            cbox_parts_status.Text = pstatus;
        }

        // clear the input fields values
        public void Clear()
        {
            cbox_car_name.Text = "";
            txt_parts_name.Clear();
            txt_parts_modelno.Clear();
            cbox_parts_color.Text = "";
            txt_parts_price.Clear();
            cbox_parts_status.Text = "";

            admin_add_car_parts_groupbox.Text = "ADMIN ADD CAR PARTS DETAILS";
            btn_add.Text = "Save";
        }

        // all fields are required and price must be digit
        private bool isValidCarInfo()
        {

            String pcarname, ppartname, pmodelno, pcolor, pprice, pstatus;

            pcarname = cbox_car_name.Text;
            ppartname = txt_parts_name.Text;
            pmodelno = txt_parts_modelno.Text;
            pcolor = cbox_parts_color.Text;
            pprice = txt_parts_price.Text;
            pstatus = cbox_parts_status.Text;

            if (pcarname.Trim() == string.Empty)
            {
                MessageBox.Show("Car Name is required!", "Error!");
                return false;
            }
            if (ppartname.Trim() == string.Empty)
            {
                MessageBox.Show("Parts Name is required!", "Error!");
                return false;
            }
            if (pmodelno.Trim() == string.Empty)
            {
                MessageBox.Show("Parts Model No is required!", "Error!");
                return false;
            }

            if (pcolor.Trim() == string.Empty)
            {
                MessageBox.Show("Parts Color is required!", "Error!");
                return false;
            }
            if (pprice.Trim() == string.Empty)
            {
                MessageBox.Show("Part Price is required!", "Error!");
                return false;
            }
            
            if (pstatus.Trim() == string.Empty)
            {
                MessageBox.Show("Parts Status is required!", "Error!");
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_parts_price.Text, "[^0-9]"))

            {
                MessageBox.Show("Please Enter Only Digits [Price]..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_parts_price.Clear();
                txt_parts_price.Focus();
                return false;
            }


            return true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String pcarname, ppartname, pmodelno, pcolor, pprice, pstatus;

            pcarname = cbox_car_name.Text;
            ppartname = txt_parts_name.Text;
            pmodelno = txt_parts_modelno.Text;
            pcolor = cbox_parts_color.Text;
            pprice = txt_parts_price.Text;
            pstatus = cbox_parts_status.Text;



            if (isValidCarInfo())
            {
                
                if (btn_add.Text == "Save")
                {
                    CarParts cp = new CarParts(pcarname, ppartname, pmodelno, pcolor, pprice, pstatus);
                    CarParts_DB.AddCarParts(cp);
                    this.Hide();
                    Clear();
                }

                if (btn_add.Text == "Update")
                {

                    CarParts cp = new CarParts(pcarname, ppartname, pmodelno, pcolor, pprice, pstatus);
                    CarParts_DB.UpdateCarParts(cp, cpid);
                    this.Hide();
                    Clear();
                }

                _parent.Display();

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cbox_car_name.Text = "";
            txt_parts_name.Clear();
            txt_parts_modelno.Clear();
            cbox_parts_color.Text = "";
            txt_parts_price.Clear();
            cbox_parts_status.Text = "";

            cbox_car_name.Focus();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clear();
        }

        
    }
}
