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
    public partial class CustomerOrderStatus : Form
    {
        public CustomerOrderStatus()
        {
            InitializeComponent();
        }

        private void btn_search_car_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSearchCar csc = new CustomerSearchCar();
            csc.Show();
        }

        

        private void btn_search_car_parts_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSearchCarParts cscp = new CustomerSearchCarParts();
            cscp.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage wp = new WelcomePage();
            wp.Show();
        }

        public void DisplayOrderCar()
        {
            string username;
            username = CustomerLogin.recusername;
            Car_DB.DisplayAndSearch("SELECT ocid, name, brand, price, payment, cusid, status, odate FROM tbl_order_car WHERE cusid='" + username + "'", dgv_car_c);
        }

        public void DisplayOrderCarParts()
        {
            string username;
            username = CustomerLogin.recusername;

            Car_DB.DisplayAndSearch("SELECT ocpid, name, modelno, price, payment, cusid, status, odate FROM tbl_order_car_parts WHERE cusid='"+username+"' ", dgv_car_p);
        }

        private void CustomerOrderStatus_Load(object sender, EventArgs e)
        {
            DisplayOrderCar();
            DisplayOrderCarParts();
            lbl_username.Text = CustomerLogin.recusername;
        }

         

        
    }
}
