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
    class Car_DB
    {
        // to get database connection access
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

         
        // to perform insert query operation
        public static void AddCar(Car cr)
        {
            string sql = "INSERT INTO tbl_car VALUES (@Carname, @Carbrand, @Caryear, @Cartype, @Carcolor, @Carprice, @Carstatus)";

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Carname", SqlDbType.VarChar).Value = cr.name;
            cmd.Parameters.Add("@Carbrand", SqlDbType.VarChar).Value = cr.brand;
            cmd.Parameters.Add("@Caryear", SqlDbType.VarChar).Value = cr.year;
            cmd.Parameters.Add("@Cartype", SqlDbType.VarChar).Value = cr.type;
            cmd.Parameters.Add("@Carcolor", SqlDbType.VarChar).Value = cr.color;
            cmd.Parameters.Add("@Carprice", SqlDbType.VarChar).Value = cr.price;
            cmd.Parameters.Add("@Carstatus", SqlDbType.VarChar).Value = cr.status;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("New CAR Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("New CAR Not Added \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        // to perform update query operation
        public static void UpdateCar(Car cr, string id)
        {

            int crid;
            crid = Int32.Parse(id);

            string sql = "UPDATE tbl_car SET name = @Carname,  brand = @Carbrand, year = @Caryear, type = @Cartype, color = @Carcolor, price = @Carprice, status = @Carstatus WHERE crid = '" + id + "' ";

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Carid", SqlDbType.VarChar).Value = crid;
            cmd.Parameters.Add("@Carname", SqlDbType.VarChar).Value = cr.name;
            cmd.Parameters.Add("@Carbrand", SqlDbType.VarChar).Value = cr.brand;
            cmd.Parameters.Add("@Caryear", SqlDbType.VarChar).Value = cr.year;
            cmd.Parameters.Add("@Cartype", SqlDbType.VarChar).Value = cr.type;
            cmd.Parameters.Add("@Carcolor", SqlDbType.VarChar).Value = cr.color;
            cmd.Parameters.Add("@Carprice", SqlDbType.VarChar).Value = cr.price;
            cmd.Parameters.Add("@Carstatus", SqlDbType.VarChar).Value = cr.status;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("CAR Info Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("CAR Info Not Updated \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        // to perform delete query operation
        public static void DeleteCar(string id)
        {
            string sql = "DELETE FROM tbl_car WHERE crid = @Carid";

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Carid", SqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("CAR Info Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("CAR Info Not Deleted \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        // to perform display and search operation
        public static void DisplayAndSearch(string query, DataGridView dgv)
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
