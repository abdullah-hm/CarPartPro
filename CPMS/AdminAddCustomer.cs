using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CPMS
{
    public partial class AdminAddCustomer : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SKV3JG3\SQLEXPRESS;Initial Catalog=CPMS_DB;Integrated Security=True");


        private readonly AdminManageCustomer _parent;
        
        // variable declarations 
        public string cid, fullname, mobileno, nic, address, dob, username, password;


        public AdminAddCustomer(AdminManageCustomer parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        // to update the existing record change the values
        public void UpdateInfo()
        {
            admin_add_customer_groupbox.Text = "ADMIN UPDATE CUSTOMER DETAILS";
            btn_add.Text = "Update";
            txt_fullname.Text = fullname;
            txt_mobileno.Text = mobileno;
            txt_nic.Text = nic;
            txt_address.Text = address;
            txt_username.Text = username;
            txt_password.Text = password;
            txt_con_password.Text = password;
        }

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
            admin_add_customer_groupbox.Text = "ADMIN ADD CUSTOMER DETAILS";
            btn_add.Text = "Save";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clear();
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

        // each fields informations are required
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


            if (System.Text.RegularExpressions.Regex.IsMatch(txt_mobileno.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numbers..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (!txt_username.Text.Contains("@") || !txt_username.Text.Contains("."))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // check new password and confirm passwords are same or not
        private bool isCorrectPassword()
        {

            String password, con_password;
            password = txt_password.Text;
            con_password = txt_con_password.Text;

            if (password != con_password)
            {
                MessageBox.Show("New Password & Confirm Password Does not Match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }


        }

        // check ther username already exist or not
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



        private void btn_add_Click(object sender, EventArgs e)
        {

            String fullname, nic, mobileno, address, dob, username, password;


            fullname = txt_fullname.Text;
            mobileno = txt_mobileno.Text;
            nic = txt_nic.Text;
            address = txt_address.Text;
            dob = dtp_dob.Text;
            username = txt_username.Text;
            password = txt_password.Text;



            if (isValidRegistration())
            {


                if (isCorrectPassword())
                {

                    if (isUserNameExist())
                    {

                        if (btn_add.Text == "Save")
                        {
                            Customer cus = new Customer(fullname, mobileno, nic, address, dob, username, password);
                            Customer_DB.AddCustomer(cus);
                            this.Hide();
                            Clear();
                        }
                    }

                    if (btn_add.Text == "Update")
                    {

                        Customer cus = new Customer(fullname, mobileno, nic, address, dob, username, password);
                        Customer_DB.UpdateCustomer(cus, cid);
                        this.Hide();
                        Clear();
                    }

                    _parent.Display();

                }

            }


        }
    }
}
