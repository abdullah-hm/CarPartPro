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
    public partial class ForgetPassword : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SKV3JG3\SQLEXPRESS;Initial Catalog=CPMS_DB;Integrated Security=True");

        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_nic.Clear();
            txt_mobileno.Clear(); ;
            txt_new_password.Clear();
            txt_con_password.Clear();

            txt_nic.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerLogin cl = new CustomerLogin();
            cl.Show();
        }

        private bool isvalidInfo()
        {
            if (txt_nic.Text.Trim() == string.Empty)
            {
                MessageBox.Show("NIC is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_mobileno.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Mobile No is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(System.Text.RegularExpressions.Regex.IsMatch(txt_mobileno.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numbers.!.[Mobile No]!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mobileno.Clear();
                txt_mobileno.Focus();
                return false;
            }
            
            if (txt_new_password.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("New Password is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
             if (txt_con_password.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Confirm Password is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool isCorrectPassword()
        {

            String new_password, con_password;
            new_password = txt_new_password.Text;
            con_password = txt_con_password.Text;

            if (new_password != con_password)
            {
                MessageBox.Show("New Password & Confirm Password Does not Match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_new_password.Clear();
                txt_con_password.Clear();
                txt_new_password.Focus();
                return false;
            }
            else
            {
                return true;
            }


        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            String nic, mobileno, new_password, con_password;

            nic = txt_nic.Text;
            mobileno = txt_mobileno.Text;
            new_password = txt_new_password.Text;
            con_password = txt_con_password.Text;

            if (isvalidInfo())
            {
                if (isCorrectPassword())
                {
                    // get the username to check
                    String password_recovery_query = "SELECT cid FROM tbl_customer WHERE mobileno ='" + mobileno + "' AND nic ='" + nic + "' ";

                    
                    SqlDataAdapter sdap = new SqlDataAdapter(password_recovery_query, connect);

                    DataTable datb = new DataTable();
                    sdap.Fill(datb);

                    if (datb.Rows.Count > 0)
                    {
                        connect.Open();
                        SqlCommand cmd = connect.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update tbl_customer  set pwd='" + con_password + "' where mobileno ='" + mobileno + "' AND nic ='" + nic + "' ";
                        // update the existing record. 

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New Password Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      

                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Not Updated..! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                            this.Hide();
                            CustomerLogin cl = new CustomerLogin();
                            cl.Show();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid NIC Or Mobile No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_nic.Clear();
                        txt_mobileno.Clear(); ;
                        txt_new_password.Clear();
                        txt_con_password.Clear();
                    }

                }
                 

            }


        }
    }
}
