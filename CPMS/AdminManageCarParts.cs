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
    public partial class AdminManageCarParts : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SKV3JG3\SQLEXPRESS;Initial Catalog=CPMS_DB;Integrated Security=True");

        AdminAddCarParts aacp;

        public AdminManageCarParts()
        {
            InitializeComponent();
            aacp = new AdminAddCarParts(this);
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


        public void Display()
        {
            CarParts_DB.DisplayAndSearch("SELECT cpid, cname, pname, modelno, color, price, status FROM tbl_car_parts", dgv_car_parts);
        }

       

        private void btn_add_new_car_parts_Click(object sender, EventArgs e)
        {
            aacp.Clear();
            aacp.ShowDialog();
        }

        private void AdminManageCarParts_Load(object sender, EventArgs e)
        {
            Display();
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

        private void dgv_car_parts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                // Edit Operation of Admin Car Data
                aacp.Clear();
                aacp.cpid = dgv_car_parts.Rows[e.RowIndex].Cells[2].Value.ToString();
                aacp.pcarname = dgv_car_parts.Rows[e.RowIndex].Cells[3].Value.ToString();
                aacp.ppartname = dgv_car_parts.Rows[e.RowIndex].Cells[4].Value.ToString();
                aacp.pmodelno = dgv_car_parts.Rows[e.RowIndex].Cells[5].Value.ToString();
                aacp.pcolor = dgv_car_parts.Rows[e.RowIndex].Cells[6].Value.ToString();
                aacp.pprice = dgv_car_parts.Rows[e.RowIndex].Cells[7].Value.ToString();
                aacp.pstatus = dgv_car_parts.Rows[e.RowIndex].Cells[8].Value.ToString();
                aacp.UpdateInfo();
                aacp.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                // Delete Operation of Admin CAR Data
                if (MessageBox.Show("Do you want to delete this CAR Parts record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CarParts_DB.DeleteCarParts(dgv_car_parts.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }

        }
    }
}
