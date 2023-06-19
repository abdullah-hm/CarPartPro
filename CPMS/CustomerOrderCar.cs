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
    public partial class CustomerOrderCar : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SKV3JG3\SQLEXPRESS;Initial Catalog=CPMS_DB;Integrated Security=True");

        public CustomerOrderCar()
        {
            InitializeComponent();
        }



        public void Clear()
        {
            cbox_car_name.Text = "";
            txt_car_brand.Clear();
            txt_car_price.Clear();
            cbox_car_payment.Text = "";
        }



        private bool isValidCarInfo()
        {

            String cname, cbrand, cpayment;

            cname = cbox_car_name.Text;
            cbrand = txt_car_brand.Text;
            cpayment = cbox_car_payment.Text;

            if (cname.Trim() == string.Empty)
            {
                MessageBox.Show("Car Name is required!", "Error!");
                return false;
            }
            if (cbrand.Trim() == string.Empty)
            {
                MessageBox.Show("Car Brand is required!", "Error!");
                return false;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(txt_car_price.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Digits [Price]..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_car_price.Clear();
                txt_car_price.Focus();
                return false;
            }
            if (cpayment.Trim() == string.Empty)
            {
                MessageBox.Show("Payment Type is required!", "Error!");
                return false;
            }


            return true;
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            String cname, cbrand, cprice, cpayment, cusid, cstatus, co_date;


            cname = cbox_car_name.Text;
            cbrand = txt_car_brand.Text;
            cprice = txt_car_price.Text;
            cpayment = cbox_car_payment.Text;
            cusid = CustomerLogin.recusername;
            cstatus = "Pending";
            co_date = DateTime.Now.ToShortDateString();



            if (isValidCarInfo())
            {

                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into tbl_order_car (name,brand,price,payment,cusid,status,odate) values ('" + cname + "','" + cbrand + "','" + cprice + "','" + cpayment + "','" + cusid + "','" + cstatus + "','" + co_date + "')";



                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New CAR Successfully Purchased", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("New CAR Not Purchased \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close(); 
                    this.Hide(); 
                }

            }
        }

        private void CustomerOrderCar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPMS_DBDataSet.tbl_car' table. You can move, or remove it, as needed.
            this.tbl_carTableAdapter.Fill(this.cPMS_DBDataSet.tbl_car);

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
