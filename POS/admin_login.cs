using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
            admin_password_tb.UseSystemPasswordChar = true;
        }
        SqlConnection con = new SqlConnection("Data Source = desktop-iumas6g; Initial Catalog = POS; Integrated Security = True");

        private void home_pic_Click(object sender, EventArgs e)
        {
            admin_login home = new admin_login();
            home.Show();
            this.Hide();
        }

        private void A_login_button_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Admin where userame='" + adminName_tb.Text + "'and A_password='" + admin_password_tb.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Welcome Admin you have successfully logged in!");
                this.Hide();
                Dashboard dash = new Dashboard();
                dash.Show();
            }
            else
            {
                MessageBox.Show("Invalid Identity");
            }
            con.Close();
        }

        private void showPass_cb_CheckedChanged(object sender, EventArgs e)
        {

            if (showPass_cb.Checked)
            {
                admin_password_tb.UseSystemPasswordChar = false;
            }
            else
            {
                admin_password_tb.UseSystemPasswordChar = true;
            }
        }
    }
}
