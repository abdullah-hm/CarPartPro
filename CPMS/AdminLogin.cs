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
    public partial class admin_login_groupbox : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SKV3JG3\SQLEXPRESS;Initial Catalog=CPMS_DB;Integrated Security=True");

        public admin_login_groupbox()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }

        // this method checking the username and password fields values are empty
        private bool isvalidlogin()
        {
            if (txt_username.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Admin UserName is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Admin Password is required!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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
                    String login_query = "SELECT * FROM tbl_admin WHERE username ='" + username + "' AND pwd ='" + password + "' ";

                    SqlDataAdapter sdap = new SqlDataAdapter(login_query, connect);

                    DataTable datb = new DataTable();
                    sdap.Fill(datb);

                    if (datb.Rows.Count > 0)
                    {


                        this.Hide();
                        AdminDashboard ad = new AdminDashboard();
                        ad.Show();
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

        private void admin_login_groupbox_Load(object sender, EventArgs e)
        {

            //Admin login page groupbox code start here
        }
    }
}
