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
    public partial class CustomerOrderCarParts : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SKV3JG3\SQLEXPRESS;Initial Catalog=CPMS_DB;Integrated Security=True");

        public CustomerOrderCarParts()
        {
            InitializeComponent();
        }


        public void Clear()
        {
            txt_carp_name.Clear();
            txt_carp_modelno.Clear();
            txt_carp_price.Clear();
            cbox_carp_payment.Text = "";
        }

        private bool isValidCarInfo()
        {

            String cpname, cpmodelno, cp_payment;

            cpname = txt_carp_name.Text;
            cpmodelno = txt_carp_modelno.Text;
            cp_payment = cbox_carp_payment.Text;

            if (cpname.Trim() == string.Empty)
            {
                MessageBox.Show("Car Part Name is required!", "Error!");
                return false;
            }
            if (cpmodelno.Trim() == string.Empty)
            {
                MessageBox.Show("Part Model No is required!", "Error!");
                return false;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(txt_carp_price.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Digits [Price]..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_carp_price.Clear();
                txt_carp_price.Focus();
                return false;
            }
            if (cp_payment.Trim() == string.Empty)
            {
                MessageBox.Show("Payment Type is required!", "Error!");
                return false;
            }


            return true;
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {


            String cpname, cpmodelno, cp_price, cp_payment, cusid, status, co_date;


            cpname = txt_carp_name.Text;
            cpmodelno = txt_carp_modelno.Text;
            cp_price = txt_carp_price.Text;
            cp_payment = cbox_carp_payment.Text;
            cusid = CustomerLogin.recusername;
            status = "Pending";
            co_date = DateTime.Now.ToShortDateString();



            if (isValidCarInfo())
            {

                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into tbl_order_car_parts (name,modelno,price,payment,cusid,status,odate) values ('" + cpname + "','" + cpmodelno + "','" + cp_price + "','" + cp_payment + "','" + cusid + "','" + status + "','" + co_date + "')";



                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New CAR Parts Successfully Purchased", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("New CAR Parts Not Purchased \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                    this.Hide();
                }

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
