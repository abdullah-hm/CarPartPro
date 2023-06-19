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
    public partial class AdminManageCustomerOrders : Form
    {
         
        public AdminManageCustomerOrders()
        {
            InitializeComponent();
           
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage wp = new WelcomePage();
            wp.Show();
        }

        private void btn_manage_car_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageCar amc = new AdminManageCar();
            amc.Show();
        }

        private void btn_manage_car_parts_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageCarParts amcp = new AdminManageCarParts();
            amcp.Show();
        }

        private void btn_manage_customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageCustomer amcr = new AdminManageCustomer();
            amcr.Show();
        }

        private void btn_generate_reports_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminGenerateReports agr = new AdminGenerateReports();
            agr.Show();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
        }

        public void DisplayOrderCar()
        {
            Car_DB.DisplayAndSearch("SELECT ocid, name, brand, price, payment, cusid, status, odate FROM tbl_order_car", dgv_car_c);
        }

        public void DisplayOrderCarParts()
        {
            Car_DB.DisplayAndSearch("SELECT ocpid, name, modelno, price, payment, cusid, status, odate FROM tbl_order_car_parts", dgv_car_p);
        }

        private void AdminManageCustomerOrders_Load(object sender, EventArgs e)
        {
            DisplayOrderCar();
            DisplayOrderCarParts();
        }

         

        private void txt_search_c_TextChanged(object sender, EventArgs e)
        {
            Car_DB.DisplayAndSearch("SELECT * FROM tbl_order_car WHERE " +
               "ocid LIKE'%" + txt_search_c.Text + "%'" +
               "OR " +
               "name LIKE'%" + txt_search_c.Text + "%'" +
               "OR " +
               "brand LIKE'%" + txt_search_c.Text + "%'" +
               "OR " +
               "price LIKE'%" + txt_search_c.Text + "%'" +
                "OR " +
               "payment LIKE'%" + txt_search_c.Text + "%'" +
               "OR " +
               "cusid LIKE'%" + txt_search_c.Text + "%'" +
               "OR " +
               "status LIKE'%" + txt_search_c.Text + "%'" +
               "OR " +
               "odate LIKE'%" + txt_search_c.Text + "%'",
               dgv_car_c);
        }

        private void txt_search_p_TextChanged(object sender, EventArgs e)
        {
            Car_DB.DisplayAndSearch("SELECT ocpid, name, modelno, price, payment, cusid, status, odate FROM tbl_order_car_parts WHERE " +
              "ocpid LIKE'%" + txt_search_p.Text + "%'" +
              "OR " +
              "name LIKE'%" + txt_search_p.Text + "%'" +
              "OR " +
              "modelno LIKE'%" + txt_search_p.Text + "%'" +
              "OR " +
              "price LIKE'%" + txt_search_p.Text + "%'" +
               "OR " +
              "payment LIKE'%" + txt_search_p.Text + "%'" +
              "OR " +
              "cusid LIKE'%" + txt_search_p.Text + "%'" +
              "OR " +
              "status LIKE'%" + txt_search_p.Text + "%'" +
              "OR " +
              "odate LIKE'%" + txt_search_p.Text + "%'",
              dgv_car_p);
        }

        private void btn_update_oc_status_Click(object sender, EventArgs e)
        {
             
            AdminUpdateCarOrders auco = new AdminUpdateCarOrders();
            auco.ShowDialog();
        }

        private void btn_update_op_status_Click(object sender, EventArgs e)
        {
            AdminUpdateCarPartsOrders aucpo = new AdminUpdateCarPartsOrders();
            aucpo.ShowDialog();

        }

        private void dgv_car_c_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_car_p_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
