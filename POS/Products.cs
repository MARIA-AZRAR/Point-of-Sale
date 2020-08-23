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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            populateData();
            FillComboBox();

            name_tb.Focus();
        }
        SqlConnection con = new SqlConnection("Data Source = desktop-iumas6g; Initial Catalog = POS; Integrated Security = True");

        void FillComboBox()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select name from manufacturer order by name ASC", con);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                manufacturer_cb.Items.Add(reader["name"]);
            }
            con.Close();
            reader.Close();
        }

        private void dashboard_intro_lbl_Click(object sender, EventArgs e)
        {

        }
        private void populateData()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Product",con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            products_dgv.DataSource = dt;
            con.Close();
        }


        private void search_btn_Click(object sender, EventArgs e)
        {
          
        }

        private void Product_save_btn_Click(object sender, EventArgs e)
        {
            string name = name_tb.Text;
            string price = Price_tb.Text; 
            string units = unit_tb.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Product(pr_name,price,units) values(@a, @b, @c)", con);

            cmd.Parameters.AddWithValue("@a", name);
            cmd.Parameters.AddWithValue("@b", price);
            cmd.Parameters.AddWithValue("@c", units);
 
            cmd.ExecuteNonQuery();
            MessageBox.Show("You Record have been successfuly Saved.");
            con.Close();
            populateData();
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {  
            con.Open();
            string search = search_tb.Text;
            SqlCommand cmd = new SqlCommand("Select * from Product where pr_name Like '%"+search+"%' ", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            products_dgv.DataSource = dt;
            con.Close();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = id_tb.Text;
            SqlCommand cmd = new SqlCommand("delete from Product where product_id= @n", con);
            cmd.Parameters.AddWithValue("@n", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted");
            con.Close();
            populateData();
        }

        private void updateRecord()
        {
           
            SqlCommand cmd = new SqlCommand("update Product set pr_name = @n, price= @p, units= @u where product_id=@i", con);
            con.Open();
            string id = id_tb.Text;
            string name = name_tb.Text;
            string price = Price_tb.Text;
            string units= unit_tb.Text;

            cmd.Parameters.AddWithValue("@i", id);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@p", price);
            cmd.Parameters.AddWithValue("@u", units);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated");
            con.Close();
            populateData();
        }

        private void products_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e) //to show records on text box
        {
            if(e.RowIndex != -1) //means if some records are present
            {
                DataGridViewRow dgvRow = products_dgv.Rows[e.RowIndex];  //we have selected the current row
                id_tb.Text = dgvRow.Cells[0].Value.ToString();
                name_tb.Text = dgvRow.Cells[1].Value.ToString();
                Price_tb.Text = dgvRow.Cells[2].Value.ToString();
                unit_tb.Text = dgvRow.Cells[3].Value.ToString();

            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            updateRecord();
        }

        private void home_pic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void logout_lbl_Click(object sender, EventArgs e)
        {
            admin_login home = new admin_login();
            home.Show();
            this.Hide();
        }

        private void Product_name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
