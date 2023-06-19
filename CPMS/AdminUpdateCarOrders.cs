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
    public partial class AdminUpdateCarOrders : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SKV3JG3\SQLEXPRESS;Initial Catalog=CPMS_DB;Integrated Security=True");


        public AdminUpdateCarOrders()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            cbox_odr_status.Text = "";
            txt_odr_id.Clear();

            txt_odr_id.Focus();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clear();
        }

        private bool isValidInfo()
        {

            String odrstatus;

            odrstatus = cbox_odr_status.Text;
          
             

            if (odrstatus.Trim() == string.Empty)
            {
                MessageBox.Show("Select Status is required!", "Error!");
                return false;
            }
            

            if (System.Text.RegularExpressions.Regex.IsMatch(txt_odr_id.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Digits [Order ID]..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_odr_id.Clear();
                txt_odr_id.Focus();
                return false;
            }
             

            return true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // update code goes here 

            string status, id;
             

            id = txt_odr_id.Text;
            status = cbox_odr_status.Text; 

            if (isValidInfo())
            {
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update tbl_order_car  set status='"+ status +"' where  ocid='"+id+"' ";


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Order No is Wrong \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                    this.Hide();
                }
            }

        }

        private void AdminUpdateCarOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
