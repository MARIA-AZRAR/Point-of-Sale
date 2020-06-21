using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void products_pb_Click(object sender, EventArgs e)
        {
            Products prod = new Products();
            prod.Show();
            this.Hide();
        }

        private void home_pic_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void logout_lbl_Click(object sender, EventArgs e)
        {
            admin_login home = new admin_login();
            home.Show();
            this.Hide();
        }

        private void customer_pb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers customer = new Customers();
            customer.Show();
        }

        private void Manufacturer_pb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manufacturer manu = new Manufacturer();
            manu.Show();
        }
    }
}
