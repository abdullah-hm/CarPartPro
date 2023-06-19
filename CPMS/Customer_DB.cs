using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace CPMS
{
    class Customer_DB
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


        // add new customer records
        public static void AddCustomer(Customer cus)
        {
             
            string sql = "INSERT INTO tbl_customer VALUES (@Customerfullname, @Customermobileno, @Customernic, @Customeraddress, @Customerdob, @Customerusername, @Customerpassword)";

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Customerfullname", SqlDbType.VarChar).Value = cus.fullname;
            cmd.Parameters.Add("@Customermobileno", SqlDbType.VarChar).Value = cus.mobileno;
            cmd.Parameters.Add("@Customernic", SqlDbType.VarChar).Value = cus.nic;
            cmd.Parameters.Add("@Customeraddress", SqlDbType.VarChar).Value = cus.address;
            cmd.Parameters.Add("@Customerdob", SqlDbType.VarChar).Value = cus.dob;
            cmd.Parameters.Add("@Customerusername", SqlDbType.VarChar).Value = cus.username;
            cmd.Parameters.Add("@Customerpassword", SqlDbType.VarChar).Value = cus.password;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Customer Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("New Customer Not Added \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        // update the existing data
        public static void UpdateCustomer(Customer cus, string id)
        {
            int cid;
            cid = Int32.Parse(id);

            string sql = "UPDATE tbl_customer SET fullname = @Customerfullname,  mobileno = @Customermobileno, nic = @Customernic, address = @Customeraddress, dob = @Customerdob, username = @Customerusername, pwd = @Customerpassword WHERE cid = '"+ id +"' ";

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Customerid", SqlDbType.VarChar).Value = cid;
            cmd.Parameters.Add("@Customerfullname", SqlDbType.VarChar).Value = cus.fullname;
            cmd.Parameters.Add("@Customermobileno", SqlDbType.VarChar).Value = cus.mobileno;
            cmd.Parameters.Add("@Customernic", SqlDbType.VarChar).Value = cus.nic;
            cmd.Parameters.Add("@Customeraddress", SqlDbType.VarChar).Value = cus.address;
            cmd.Parameters.Add("@Customerdob", SqlDbType.VarChar).Value = cus.dob;
            cmd.Parameters.Add("@Customerusername", SqlDbType.VarChar).Value = cus.username;
            cmd.Parameters.Add("@Customerpassword", SqlDbType.VarChar).Value = cus.password;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Info Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Customer Info Not Updated \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }


        // delete existing records
        public static void DeleteCustomer(string id)
        {
            string sql = "DELETE FROM tbl_customer WHERE cid = @Customercid";

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Customercid", SqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Info Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Customer Info Not Deleted \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearch (string query, DataGridView dgv)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            con.Close();
        }

    }
}
