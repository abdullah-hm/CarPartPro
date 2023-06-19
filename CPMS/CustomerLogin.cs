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
    public partial class CustomerLogin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SKV3JG3\SQLEXPRESS;Initial Catalog=CPMS_DB;Integrated Security=True");


        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRegister cr = new CustomerRegister();
            cr.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }

        private void lbl_link_forget_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetPassword fp = new ForgetPassword();
            fp.Show();
        }

        private bool isvalidlogin()
        {
            if (txt_username.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Customer UserName is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!txt_username.Text.Contains("@") && !txt_username.Text.Contains("."))
            {
                MessageBox.Show("Invalid Email Address", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Focus();
                return false;
            }
            
            if (txt_password.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Customer Password is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static string username;


        public static string recusername
        {
            get { return username; }
            set { username = value; }
        }



        private void btn_login_Click(object sender, EventArgs e)
        {
            String username;
            String password;

            username = txt_username.Text;
            password = txt_password.Text;

            if (isvalidlogin())
            {

                try
                {
                    String login_querry = "SELECT * FROM tbl_customer WHERE username ='" + username + "' AND pwd ='" + password + "' ";

                    SqlDataAdapter sdap = new SqlDataAdapter(login_querry, connect);

                    DataTable datb = new DataTable();
                    sdap.Fill(datb);



                    if (datb.Rows.Count > 0)
                    {
                        recusername = username;
                        this.Hide();
                        CustomerSearchCar csc = new CustomerSearchCar();
                        csc.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Clear();
                        txt_password.Clear();
                    }

                }
                catch
                {
                    MessageBox.Show("Database Not Connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }
        }
    }
}
