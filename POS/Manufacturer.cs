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
    public partial class Manufacturer : Form
    {
        public Manufacturer()
        {
            InitializeComponent();
            populateData();
            name_tb.Focus();
        }

        SqlConnection con = new SqlConnection("Data Source = desktop-iumas6g; Initial Catalog = POS; Integrated Security = True");

        private void populateData()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from manufacturer", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            manufacturer_dgv.DataSource = dt;
            con.Close();
        }


        private void logout_lbl_Click(object sender, EventArgs e)
        {

            admin_login home = new admin_login();
            home.Show();
            this.Hide();
            
        }

        private void home_pic_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void manufacturer_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string search = search_tb.Text;
            SqlCommand cmd = new SqlCommand("Select * from manufacturer where name Like '%" + search + "%' ", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            manufacturer_dgv.DataSource = dt;
            con.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string name = name_tb.Text;
            string address = address_tb.Text;
            string type = product_type_tb.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into manufacturer(name,address,product_type) values(@n, @a, @p)", con);

            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@a", address);
            cmd.Parameters.AddWithValue("@p", type);

            cmd.ExecuteNonQuery();
            MessageBox.Show("You Record have been successfuly Saved.");
            con.Close();
            populateData();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = id_tb.Text;
            SqlCommand cmd = new SqlCommand("delete from manufacturer where manufacurer_id= @n", con);
            cmd.Parameters.AddWithValue("@n", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted");
            con.Close();
            populateData();
        }
    }
}
