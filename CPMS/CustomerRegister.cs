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
    public partial class CustomerRegister : Form
    {


        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SKV3JG3\SQLEXPRESS;Initial Catalog=CPMS_DB;Integrated Security=True");


        public CustomerRegister()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerLogin cl = new CustomerLogin();
            cl.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fullname.Clear();
            txt_mobileno.Clear();
            txt_nic.Clear();
            txt_address.Clear();
            dtp_dob.Text = "";
            txt_username.Clear();
            txt_password.Clear();
            txt_con_password.Clear();

            txt_fullname.Focus();
        }


        // all input fields are required
        private bool isValidRegistration()
        {

            String fullname, mobileno, nic, address, username, password, con_password;


            fullname = txt_fullname.Text;
            mobileno = txt_mobileno.Text;
            nic = txt_nic.Text;
            address = txt_address.Text;
            username = txt_username.Text;
            password = txt_password.Text;
            con_password = txt_con_password.Text;

            if (fullname.Trim() == string.Empty)
            {
                MessageBox.Show("Full Name is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (mobileno.Trim() == string.Empty)
            {

                MessageBox.Show("Mobile Number is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!txt_username.Text.Contains("@") && !txt_username.Text.Contains("."))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (System.Text.RegularExpressions.Regex.IsMatch(txt_mobileno.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numbers..[Mobile No]!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mobileno.Clear();
                txt_mobileno.Focus();
                return false;
            }

            if (nic.Trim() == string.Empty)
            {
                MessageBox.Show("NIC No is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (address.Trim() == string.Empty)
            {
                MessageBox.Show("Address is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username.Trim() == string.Empty)
            {
                MessageBox.Show("UserName is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (password.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (con_password.Trim() == string.Empty)
            {
                MessageBox.Show("Confirm Password is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // check new password and confirm password are same or not
        private bool isCorrectPassword()
        {

            String password, con_password;
            password = txt_password.Text;
            con_password = txt_con_password.Text;

            if (password != con_password)
            {
                MessageBox.Show("New Password & Confirm Password Does not Match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_con_password.Clear();
                txt_con_password.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }

        // check the username is already exist is the database
        private bool isUserNameExist()
        {

            String check_username;

            check_username = txt_username.Text;

            String isUserNameExist_query = "SELECT * FROM tbl_customer WHERE username ='" + check_username + "'";

            SqlDataAdapter sdap = new SqlDataAdapter(isUserNameExist_query, connect);

            DataTable datb = new DataTable();
            sdap.Fill(datb);

            if (datb.Rows.Count > 0)
            {
                MessageBox.Show("UserName Already Exist! [Try New UserName]", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Clear();
                txt_username.Focus();
                return false;

            }
            else
            {
                return true;
            }
        }

        // clear the input fields values 
        public void Clear()
        {
            txt_fullname.Clear();
            txt_mobileno.Clear();
            txt_nic.Clear();
            txt_address.Clear();
            dtp_dob.Text = "";
            txt_username.Clear();
            txt_password.Clear();
            txt_con_password.Clear();

        }


        private void btn_register_Click(object sender, EventArgs e)
        {

            String fullname, mobileno, nic, address, dob, username, con_password;


            fullname = txt_fullname.Text;
            mobileno = txt_mobileno.Text;
            nic = txt_nic.Text;
            address = txt_address.Text;
            dob = dtp_dob.Text;
            username = txt_username.Text;
            con_password = txt_con_password.Text;



            if (isValidRegistration())
            {
                if (isUserNameExist())
                {

                    if (isCorrectPassword())
                    {

                        Customer cus = new Customer(fullname, mobileno, nic, address, dob, username, con_password);
                        Customer_DB.AddCustomer(cus);
                        this.Hide();
                        CustomerLogin cl = new CustomerLogin();
                        cl.Show();
                        Clear();

                    }
                }


            }


        }

        private void customer_reg_groupbox_Enter(object sender, EventArgs e)
        {
            connect.Close();
        }
    }
}
