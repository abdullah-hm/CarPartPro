using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CPMS
{
    public partial class AdminManageCar : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SKV3JG3\SQLEXPRESS;Initial Catalog=CPMS_DB;Integrated Security=True");

        AdminAddCar aacr;

        public AdminManageCar()
        {
            InitializeComponent();
            aacr = new AdminAddCar(this);
        }

        public void Display()
        {
            Car_DB.DisplayAndSearch("SELECT crid, name, brand, year, type, color, price, status FROM tbl_car", dgv_car);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage wp = new WelcomePage();
            wp.Show();
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

        private void btn_manage_customer_orders_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageCustomerOrders amco = new AdminManageCustomerOrders();
            amco.Show();
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


        private void btn_add_new_car_Click(object sender, EventArgs e)
        {
            aacr.Clear();
            aacr.ShowDialog();
        }

        private void AdminManageCar_Load(object sender, EventArgs e)
        {
            Display();
        }

        

        private void txt_search_TextChanged_1(object sender, EventArgs e)
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

        private void dgv_car_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                // Edit Operation of Admin Car Data
                aacr.Clear();
                aacr.crid = dgv_car.Rows[e.RowIndex].Cells[2].Value.ToString();
                aacr.name = dgv_car.Rows[e.RowIndex].Cells[3].Value.ToString();
                aacr.brand = dgv_car.Rows[e.RowIndex].Cells[4].Value.ToString();
                aacr.year = dgv_car.Rows[e.RowIndex].Cells[5].Value.ToString();
                aacr.type = dgv_car.Rows[e.RowIndex].Cells[6].Value.ToString();
                aacr.color = dgv_car.Rows[e.RowIndex].Cells[7].Value.ToString();
                aacr.price = dgv_car.Rows[e.RowIndex].Cells[8].Value.ToString();
                aacr.status = dgv_car.Rows[e.RowIndex].Cells[9].Value.ToString();
                aacr.UpdateInfo();
                aacr.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                // Delete Operation of Admin CAR Data
                if (MessageBox.Show("Do you want to delete this CAR record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Car_DB.DeleteCar(dgv_car.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
