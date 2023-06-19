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
    public partial class AdminManageCustomer : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SKV3JG3\SQLEXPRESS;Initial Catalog=CPMS_DB;Integrated Security=True");

        AdminAddCustomer aac;



        public AdminManageCustomer()
        {
            InitializeComponent();
            aac = new AdminAddCustomer(this);
        }

        public void Display()
        {
            Customer_DB.DisplayAndSearch("SELECT cid, fullname, mobileno, nic, address, dob, username, pwd FROM tbl_customer", dgv_customer);
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





        private void customer_list_groupbox_Enter(object sender, EventArgs e)
        {



        }



        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                // Edit Operation of Admin Manage Customer Data
                aac.Clear();
                aac.cid = dgv_customer.Rows[e.RowIndex].Cells[2].Value.ToString();
                aac.fullname = dgv_customer.Rows[e.RowIndex].Cells[3].Value.ToString();
                aac.mobileno = dgv_customer.Rows[e.RowIndex].Cells[4].Value.ToString();
                aac.nic = dgv_customer.Rows[e.RowIndex].Cells[5].Value.ToString();
                aac.address = dgv_customer.Rows[e.RowIndex].Cells[6].Value.ToString();
                aac.dob = dgv_customer.Rows[e.RowIndex].Cells[7].Value.ToString();
                aac.username = dgv_customer.Rows[e.RowIndex].Cells[8].Value.ToString();
                aac.password = dgv_customer.Rows[e.RowIndex].Cells[9].Value.ToString();
                aac.UpdateInfo();
                aac.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                // Delete Operation of Admin Manage Customer Data
                if(MessageBox.Show("Do you want to delete this customer record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Customer_DB.DeleteCustomer(dgv_customer.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }


        private void btn_add_new_customer_Click_1(object sender, EventArgs e)
        {
            aac.Clear();
            aac.ShowDialog();
        }

        private void AdminManageCustomer_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            Customer_DB.DisplayAndSearch("SELECT cid, fullname, mobileno, nic, address, dob, username, pwd FROM tbl_customer WHERE " +
                "cid LIKE'%" + txt_search.Text + "%'" +
                "OR " +
                "fullname LIKE'%" + txt_search.Text + "%'" +
                "OR " +
                "mobileno LIKE'%" + txt_search.Text + "%'" +
                "OR " +
                "nic LIKE'%" + txt_search.Text + "%'" +
                 "OR " +
                "address LIKE'%" + txt_search.Text + "%'" +
                "OR " +
                "dob LIKE'%" + txt_search.Text + "%'" +
                "OR " +
                "username LIKE'%" + txt_search.Text + "%'" +
                "OR " +
                "pwd LIKE'%" + txt_search.Text + "%'",
                dgv_customer);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
