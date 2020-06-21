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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            populateData();
            first_name_tb.Focus();
        }

        SqlConnection con = new SqlConnection("Data Source = desktop-iumas6g; Initial Catalog = POS; Integrated Security = True");

        private void populateData()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Customer", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            customers_dgv.DataSource = dt;
            con.Close();
        }

        private void updateRecord()
        {

            SqlCommand cmd = new SqlCommand("update Customer set first_name = @f,last_name=@l, phone_no= @p, card_no= @c,Email=@e where customer_id=@i", con);
            con.Open();
            string id = id_tb.Text;
            string first_name = first_name_tb.Text;
            string last_name = last_name_tb.Text;
            string phone = Phone_tb.Text;
            string card = card_tb.Text;
            string email = email_tb.Text;

            cmd.Parameters.AddWithValue("@i", id);
            cmd.Parameters.AddWithValue("@f", first_name);
            cmd.Parameters.AddWithValue("@l", last_name);
            cmd.Parameters.AddWithValue("@p", phone);
            cmd.Parameters.AddWithValue("@c", card);
            cmd.Parameters.AddWithValue("@e", email);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated");
            con.Close();
            populateData();
        }

        private void logout_lbl_Click(object sender, EventArgs e)
        {

            admin_login home = new admin_login();
            home.Show();
            this.Hide();
        }

        private void home_pic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string search = search_tb.Text;
            SqlCommand cmd = new SqlCommand("Select * from Customer where first_name Like '%" + search + "%' ", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            customers_dgv.DataSource = dt;
            con.Close();
        }


        private void update_btn_Click(object sender, EventArgs e)
        {
            updateRecord();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = id_tb.Text;
            SqlCommand cmd = new SqlCommand("delete from Customer where customer_id= @n", con);
            cmd.Parameters.AddWithValue("@n", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted");
            con.Close();
            populateData();
        }

        private void Product_save_btn_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string first_name = first_name_tb.Text;
            string last_name = last_name_tb.Text;
            string phone = Phone_tb.Text;
            string card = card_tb.Text;
            string email = email_tb.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Customer(first_name,last_name,phone_no,card_no,Email) values(@f,@l,@p, @c, @e)", con);

            cmd.Parameters.AddWithValue("@f", first_name);
            cmd.Parameters.AddWithValue("@l", last_name);
            cmd.Parameters.AddWithValue("@p", phone);
            cmd.Parameters.AddWithValue("@c", card);
            cmd.Parameters.AddWithValue("@e", email);

            cmd.ExecuteNonQuery();
            MessageBox.Show("You Record have been successfuly Saved.");
            con.Close();
            populateData();
        }

        private void customers_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) //means if some records are present
            {
                DataGridViewRow dgvRow = customers_dgv.Rows[e.RowIndex];  //we have selected the current row
                id_tb.Text = dgvRow.Cells[0].Value.ToString();
                first_name_tb.Text = dgvRow.Cells[1].Value.ToString();
                last_name_tb.Text = dgvRow.Cells[2].Value.ToString();
                Phone_tb.Text = dgvRow.Cells[3].Value.ToString();
                card_tb.Text = dgvRow.Cells[4].Value.ToString();
                email_tb.Text = dgvRow.Cells[5].Value.ToString();

            }
        }
    }
}
