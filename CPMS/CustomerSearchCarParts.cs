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
    public partial class CustomerSearchCarParts : Form
    {
        public CustomerSearchCarParts()
        {
            InitializeComponent();
        }

        private void btn_search_car_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSearchCar csc = new CustomerSearchCar();
            csc.Show();
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
        public void Display()
        {
            CarParts_DB.DisplayAndSearch("SELECT cpid, cname, pname, modelno, color, price, status FROM tbl_car_parts", dgv_car_parts);
        }
        private void CustomerSearchCarParts_Load(object sender, EventArgs e)
        {
           
            lbl_username.Text = CustomerLogin.recusername;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            CarParts_DB.DisplayAndSearch("SELECT * FROM tbl_car_parts WHERE " +
             "cpid LIKE'%" + txt_search.Text + "%'" +
             "OR " +
             "cname LIKE'%" + txt_search.Text + "%'" +
             "OR " +
             "pname LIKE'%" + txt_search.Text + "%'" +
             "OR " +
             "modelno LIKE'%" + txt_search.Text + "%'" +
             "OR " +
             "color LIKE'%" + txt_search.Text + "%'" +
             "OR " +
             "price LIKE'%" + txt_search.Text + "%'" +
             "OR " +
             "status LIKE'%" + txt_search.Text + "%'",
             dgv_car_parts);
        }

        private void btn_add_new_car_Click(object sender, EventArgs e)
        {
            CustomerOrderCarParts cocp = new CustomerOrderCarParts();
            cocp.ShowDialog();
        }

        private void dgv_car_parts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Display();
        }
    }
}
