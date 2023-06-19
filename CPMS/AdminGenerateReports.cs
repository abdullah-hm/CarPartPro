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
    public partial class AdminGenerateReports : Form
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
        public AdminGenerateReports()
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

        private void btn_manage_customer_orders_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageCustomerOrders amco = new AdminManageCustomerOrders();
            amco.Show();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
        }

         

        private void AdminGenerateReports_Load(object sender, EventArgs e)
        {
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            GetConnection();
            SqlConnection con = GetConnection();
            string query = "select * from tbl_customer";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
        }

        private void btn_car_Click(object sender, EventArgs e)
        {
            GetConnection();
            SqlConnection con = GetConnection();
            string query = "select * from tbl_car";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
        }

        private void btn_car_parts_Click(object sender, EventArgs e)
        {
            GetConnection();
            SqlConnection con = GetConnection();
            string query = "select * from tbl_car_parts";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
        }

        private void btn_order_car_Click(object sender, EventArgs e)
        {
            GetConnection();
            SqlConnection con = GetConnection();
            string query = "select * from tbl_order_car";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
        }

        private void btn_order_car_parts_Click(object sender, EventArgs e)
        {
            GetConnection();
            SqlConnection con = GetConnection();
            string query = "select * from tbl_order_car_parts";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            try
            {
                dgv.SelectAll();
                DataObject copydata = dgv.GetClipboardContent();
                if (copydata != null) Clipboard.SetDataObject(copydata);
                Microsoft.Office.Interop.Excel.Application exlapp = new Microsoft.Office.Interop.Excel.Application();
                exlapp.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook xlWbk;
                Microsoft.Office.Interop.Excel.Worksheet xlsht;
                object lostdata = System.Reflection.Missing.Value;
                xlWbk = exlapp.Workbooks.Add(lostdata);

                xlsht = (Microsoft.Office.Interop.Excel.Worksheet)xlWbk.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range exlr = (Microsoft.Office.Interop.Excel.Range)xlsht.Cells[1, 1];
                exlr.Select();
                xlsht.PasteSpecial(exlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                MessageBox.Show("Successfully Exported", "Excel Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Excel Exporting Went Wrong..!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
        }
    }
}
