using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPMS
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_login_groupbox al = new admin_login_groupbox();
            al.Show();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerLogin cl = new CustomerLogin();
            cl.Show();
        }
    }
}
