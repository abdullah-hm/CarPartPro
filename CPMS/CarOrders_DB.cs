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
    class CarOrders_DB
    {
        class CarPurchase_DB
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

            // insert car details to the database
            public static void PurchaseCar(CarOrders pc)
            {


                pc.status = "Pending";
                pc.odate = DateTime.Now.ToShortDateString();

                string sql = "INSERT INTO tbl_order_car VALUES (@CarPurchasecid, @CarPurchasecrid, @CarPurchasecrname, @CarPurchaseprice, @CarPurchasenoc, @CarPurchasetotal, @CarPurchasepayment, @Carstatus, @CarPurchaseodate)";

                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;


                cmd.Parameters.Add("@CarPurchasecid", SqlDbType.Int).Value = CustomerLogin.recusername;

                cmd.Parameters.Add("@CarPurchasecrid", SqlDbType.Int).Value = pc.crid;

                cmd.Parameters.Add("@CarPurchasecrname", SqlDbType.VarChar).Value = pc.crname;

                cmd.Parameters.Add("@CarPurchaseprice", SqlDbType.Decimal).Value = pc.price;

                cmd.Parameters.Add("@CarPurchasenoc", SqlDbType.Int).Value = pc.noc;

                pc.total = pc.noc * pc.price;
                cmd.Parameters.Add("@CarPurchasetotal", SqlDbType.Decimal).Value = pc.total;

                cmd.Parameters.Add("@CarPurchasepayment", SqlDbType.VarChar).Value = pc.payment;

                cmd.Parameters.Add("@CarPurchasestatus", SqlDbType.VarChar).Value = pc.status;

                cmd.Parameters.Add("@CarPurchaseodate", SqlDbType.VarChar).Value = pc.odate;



                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New CAR Order Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("New CAR Order Not Added \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

            }

             
 
             

        }
    }
}
