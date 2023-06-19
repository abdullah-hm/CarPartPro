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
    public partial class CustomerSearchCar : Form
    {
        public CustomerSearchCar()
        {
            InitializeComponent();
        }

        private void btn_search_car_parts_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSearchCarParts cscp = new CustomerSearchCarParts();
            cscp.Show();
        }

        private void btn_order_status_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerOrderStatus cos = new CustomerOrderStatus();
            cos.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage wp = new WelcomePage();
            wp.Show();
        }

        private void car_list_groupbox_Enter(object sender, EventArgs e)
        {

        }

        public void Display()
        {
            Car_DB.DisplayAndSearch("SELECT crid, name, brand, year, type, color, price, status FROM tbl_car", dgv_car);
        }

        private void CustomerSearchCar_Load(object sender, EventArgs e)
        {
            lbl_username.Text = CustomerLogin.recusername;
           
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            Car_DB.DisplayAndSearch("SELECT crid, name, brand, year, type, color, price, status FROM tbl_car WHERE " +
               "crid LIKE'%" + txt_search.Text + "%'" +
               "OR " +
               "name LIKE'%" + txt_search.Text + "%'" +
               "OR " +
               "brand LIKE'%" + txt_search.Text + "%'" +
               "OR " +
               "year LIKE'%" + txt_search.Text + "%'" +
                "OR " +
               "type LIKE'%" + txt_search.Text + "%'" +
               "OR " +
               "color LIKE'%" + txt_search.Text + "%'" +
               "OR " +
               "price LIKE'%" + txt_search.Text + "%'" +
               "OR " +
               "status LIKE'%" + txt_search.Text + "%'",
               dgv_car);
        }

        private void dgv_car_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Display();
        }

        private void btn_add_new_car_Click(object sender, EventArgs e)
        {
            CustomerOrderCar coc = new CustomerOrderCar();
            coc.ShowDialog();
        }

        private void btn_search_car_Click(object sender, EventArgs e)
        {

        }
    }
}
