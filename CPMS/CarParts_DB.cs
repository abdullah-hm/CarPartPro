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
    class CarParts_DB
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


        // add car parts
        public static void AddCarParts(CarParts cp)
        {

            string sql = "INSERT INTO tbl_car_parts VALUES (@CarPartscname, @CarPartspname, @CarPartsmodelno, @CarPartscolor, @CarPartsprice, @CarPartsstatus)";

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@CarPartscname", SqlDbType.VarChar).Value = cp.carname;
            cmd.Parameters.Add("@CarPartspname", SqlDbType.VarChar).Value = cp.partname;
            cmd.Parameters.Add("@CarPartsmodelno", SqlDbType.VarChar).Value = cp.modelno;
            cmd.Parameters.Add("@CarPartscolor", SqlDbType.VarChar).Value = cp.color;
            cmd.Parameters.Add("@CarPartsprice", SqlDbType.VarChar).Value = cp.price;
            cmd.Parameters.Add("@CarPartsstatus", SqlDbType.VarChar).Value = cp.status;
        
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("New CAR Parts Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("New CAR Parts Not Added \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        // update existing car parts details
        public static void UpdateCarParts(CarParts cp, string id)
        {

            int cpid;
            cpid = Int32.Parse(id);

            string sql = "UPDATE tbl_car_parts SET cname = @CarPartscname,  pname = @CarPartspname, modelno = @CarPartsmodelno, color = @CarPartscolor, price = @CarPartsprice, status = @CarPartsstatus WHERE cpid ='"+id+"' ";

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;


            cmd.Parameters.Add("@Carid", SqlDbType.VarChar).Value = cpid;
            cmd.Parameters.Add("@CarPartscname", SqlDbType.VarChar).Value = cp.carname;
            cmd.Parameters.Add("@CarPartspname", SqlDbType.VarChar).Value = cp.partname;
            cmd.Parameters.Add("@CarPartsmodelno", SqlDbType.VarChar).Value = cp.modelno;
            cmd.Parameters.Add("@CarPartscolor", SqlDbType.VarChar).Value = cp.color;
            cmd.Parameters.Add("@CarPartsprice", SqlDbType.VarChar).Value = cp.price;
            cmd.Parameters.Add("@CarPartsstatus", SqlDbType.VarChar).Value = cp.status;



            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("CAR Parts Info Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("CAR Parts Info Not Updated \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        // delete existing car parts details 
        public static void DeleteCarParts(string id)
        {
            string sql = "DELETE FROM tbl_car_parts WHERE cpid = @CarPartsid";

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@CarPartsid", SqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("CAR Parts Info Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("CAR Parts Info Not Deleted \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

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
