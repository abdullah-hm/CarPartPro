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
    public partial class AdminDashboard : Form
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SKV3JG3\SQLEXPRESS;Initial Catalog=CPMS_DB;Integrated Security=True");
            try
            {
                connect.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Connect Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connect;
        }

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage wp = new WelcomePage();
            wp.Show();

        }
        private void label6_Click(object sender, EventArgs e)
        {

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

        public int total_orders, car_orders, parts_orders;
        public decimal total_sales = 0, car_sales = 0, car_parts_sales = 0 ;

        public void Car()
        {

            GetConnection();
            SqlConnection con = GetConnection();
            string query = "select Count(*) from tbl_car";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable _car = new DataTable();
            sda.Fill(_car);

            res_total_car.Text = _car.Rows[0][0].ToString();
        }

        public void CarInStock()
        {

            GetConnection();
            SqlConnection con = GetConnection();
            string query = "select Count(*) from tbl_car where status='in stock'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            res_total_car_in_stock.Text = dt.Rows[0][0].ToString();
        }

        public void CarOutOfStock()
        {

            GetConnection();
            SqlConnection con = GetConnection();
            string query = "select Count(*) from tbl_car where status='out stock'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            res_total_car_out_of_stock.Text = dt.Rows[0][0].ToString();
        }

        public void CarParts()
        {

            GetConnection();
            SqlConnection con = GetConnection();
            string query = "select Count(*) from tbl_car_parts";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            res_total_car_parts.Text = dt.Rows[0][0].ToString();
        }

        public void CarPartsInStock()
        {

            GetConnection();
            SqlConnection con = GetConnection();
            string query = "select Count(*) from tbl_car_parts where status='in stock'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            res_total_car_parts_in_stock.Text = dt.Rows[0][0].ToString();
        }
        public void CarPartsOutStock()
        {

            GetConnection();
            SqlConnection con = GetConnection();
            string query = "select Count(*) from tbl_car_parts where status='out stock'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            res_total_car_parts_out_of_stock.Text = dt.Rows[0][0].ToString();
        }
        public void CarOrders()
        {

            GetConnection();
            SqlConnection con = GetConnection();
            string query = "select Count(*) from tbl_order_car";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            res_total_car_orders.Text = dt.Rows[0][0].ToString();
            car_orders = Int32.Parse(res_total_car_orders.Text);
        }

        public void PartsOrders()
        {

            GetConnection();
            SqlConnection con = GetConnection();
            string query = "select Count(*) from tbl_order_car_parts";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            res_total_car_parts_orders.Text = dt.Rows[0][0].ToString();
            parts_orders = Int32.Parse(res_total_car_parts_orders.Text);
        }

        public void Orders()
        {
            total_orders = car_orders + parts_orders;
            res_total_orders.Text = total_orders.ToString();
        }

        public void Customers()
        {

            // display all the customer 
            GetConnection();
            SqlConnection con = GetConnection();
            string query = "select Count(*) from tbl_customer";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable _car = new DataTable();
            sda.Fill(_car);

            res_total_customers.Text = _car.Rows[0][0].ToString();
        }

        public void CarSales()
        {
            // total sales mean order_car price + order_status AND order_parts price + order_status

            GetConnection();
            SqlConnection con = GetConnection();
            string query = "SELECT SUM(price) FROM tbl_order_car WHERE price > 0 AND status='Delivered'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable _car = new DataTable();
            sda.Fill(_car);

            res_total_car_sales.Text = _car.Rows[0][0].ToString();
            car_sales = decimal.Parse(res_total_car_sales.Text);
        }

        public void CarPartsSales()
        {
            // total sales mean order_car price + order_status AND order_parts price + order_status

            GetConnection();
            SqlConnection con = GetConnection();
            string query = "SELECT SUM(price) FROM tbl_order_car_parts WHERE price > 0 AND status='Delivered'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable _car = new DataTable();
            sda.Fill(_car);

            res_total_car_parts_sales.Text = _car.Rows[0][0].ToString();
            car_parts_sales = decimal.Parse(res_total_car_parts_sales.Text);
        }

        

        public void TotalSales()
        {
            // total sales mean order_car price + order_status AND order_parts price + order_status

            total_sales = car_sales + car_parts_sales;
            res_total_sales.Text = total_sales.ToString();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            Car();
            CarInStock();
            CarOutOfStock();
            CarParts();
            CarPartsInStock();
            CarPartsOutStock();
            CarOrders();
            PartsOrders();
            Orders();
            Customers();
            CarSales();
            CarPartsSales();
            TotalSales();
        }


    }
}
