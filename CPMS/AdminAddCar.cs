using System;
using System.Windows.Forms;

namespace CPMS
{
    public partial class AdminAddCar : Form
    {

        private readonly AdminManageCar _parent;
        public string crid, name, brand, year, type, color, price, status;

       

        public AdminAddCar(AdminManageCar parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        // set values and to update
        public void UpdateInfo()
        {
            admin_add_car_groupbox.Text = "ADMIN UPDATE CAR DETAILS";
            btn_add.Text = "Update";
            txt_car_name.Text = name;
            txt_car_brand.Text = brand;
            txt_car_year.Text = year;
            cbox_car_type.Text = type;
            cbox_car_color.Text = color;
            txt_car_price.Text = price;
            cbox_car_status.Text = status;
        }

        // clear input fields values
        public void Clear()
        {
            txt_car_name.Clear();
            txt_car_brand.Clear();
            txt_car_year.Clear();
            cbox_car_type.Text = "";
            cbox_car_color.Text = "";
            txt_car_price.Clear();
            cbox_car_status.Text = "";

            admin_add_car_groupbox.Text = "ADMIN ADD CAR DETAILS";
            btn_add.Text = "Save";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_car_name.Clear();
            txt_car_brand.Clear();
            txt_car_year.Clear();
            cbox_car_type.Text = "";
            cbox_car_color.Text = "";
            txt_car_price.Clear();
            cbox_car_status.Text = "";

            txt_car_name.Focus();
        }

        // all car input fields are reuired
        private bool isValidCarInfo()
        {

            String cname, cbrand, cyear, ctype, ccolor, cprice, cstatus;

            cname = txt_car_name.Text;
            cbrand = txt_car_brand.Text;
            cyear = txt_car_year.Text;
            ctype = cbox_car_type.Text;
            ccolor = cbox_car_color.Text;
            cprice = txt_car_price.Text;
            cstatus = cbox_car_status.Text;

            if (cname.Trim() == string.Empty)
            {
                MessageBox.Show("Car Name is required!", "Error!");
                return false;
            }
            if (cbrand.Trim() == string.Empty)
            {
                MessageBox.Show("Car Brand is required!", "Error!");
                return false;
            }
            if (cyear.Trim() == string.Empty)
            {
                MessageBox.Show("Car Manufacture Year is required!", "Error!");
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_car_year.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numbers [Year]..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_car_year.Clear();
                txt_car_year.Focus();
                return false;
            }
            if (ctype.Trim() == string.Empty)
            {
                MessageBox.Show("Car Type is required!", "Error!");
                return false;
            }
            if (ccolor.Trim() == string.Empty)
            {
                MessageBox.Show("Car Color is required!", "Error!");
                return false;
            }
            if (cprice.Trim() == string.Empty)
            {
                MessageBox.Show("Car Price is required!", "Error!");
                return false;
            }
            
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_car_price.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Digits [Price]..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_car_price.Clear();
                txt_car_price.Focus();
                return false;
            }
            if (cstatus.Trim() == string.Empty)
            {
                MessageBox.Show("Car Status is required!", "Error!");
                return false;
            }

            return true;
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            String cname, cbrand, cyear, ctype, ccolor, cprice, cstatus;

            cname = txt_car_name.Text;
            cbrand = txt_car_brand.Text;
            cyear = txt_car_year.Text;
            ctype = cbox_car_type.Text;
            ccolor = cbox_car_color.Text;
            cprice = txt_car_price.Text;
            cstatus = cbox_car_status.Text;



            if (isValidCarInfo())
            {

                // insert car records
                if (btn_add.Text == "Save")
                {
                    Car cr = new Car(cname, cbrand, cyear, ctype, ccolor, cprice, cstatus);
                    Car_DB.AddCar(cr);
                    this.Hide();
                    Clear();
                }

                // update existing car records
                if (btn_add.Text == "Update")
                {

                    Car cr = new Car(cname, cbrand, cyear, ctype, ccolor, cprice, cstatus);
                    Car_DB.UpdateCar(cr, crid);
                    this.Hide();
                    Clear();
                }

                _parent.Display();

            }
        }




    }
}
