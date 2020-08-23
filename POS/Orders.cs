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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            FillOrders();
        }

        SqlConnection con = new SqlConnection("Data Source = desktop-iumas6g; Initial Catalog = POS; Integrated Security = True");
        string orderIDS;

        //filling products and quantity
        void FillOrders()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select order_id from investment order by order_id ASC", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            orders_cb.Items.Clear();

            while (reader.Read())
            {
                orders_cb.Items.Add(reader["order_id"]);
            }
            con.Close();
            reader.Close();
        }

        private void home_pic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void logout_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_login login = new admin_login();
            login.Show();
        }

        private void Order_Show_btn_Click(object sender, EventArgs e)
        {
            orderIDS = this.orders_cb.GetItemText(this.orders_cb.SelectedItem);
            populateData();

            string query1 = "Select SUM(price) as 'Price' from orderDetails where order_id = '" + orderIDS + "'";
            string query2 = "select c.first_name, c.last_name, c.Email, c.phone_no from investment i inner join Customer c on i.customer_id = c.customer_id where  i.order_id = '" + orderIDS + "'";
            con.Open();
            //getting Total price
            SqlCommand cmd = new SqlCommand(query1, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string TotalPrice = dt.Rows[0][0].ToString();

            cmd = new SqlCommand(query2, con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            first_name_tb.Text = dt.Rows[0][0].ToString();
            last_name_tb.Text = dt.Rows[0][1].ToString();
            email_tb.Text = dt.Rows[0][2].ToString();
            Phone_tb.Text = dt.Rows[0][3].ToString();

            totalPrice_tb.Text = TotalPrice;

            con.Close();

        }

        //Populate Data
        private void populateData()
        {
            con.Open();
            string query = "select p.pr_name as 'Product', d.quantity, i.order_date, d.price from investment i inner join orderDetails d on i.order_id = d.order_id inner join Product p on d.product_id = p.product_id where i.order_id = '" + orderIDS + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Orders_dgv.DataSource = dt;
            con.Close();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = orders_cb.GetItemText(orders_cb.SelectedItem);
            SqlCommand cmd = new SqlCommand("delete from orderDetails where order_id = @n", con);
            cmd.Parameters.AddWithValue("@n", id);
            cmd.ExecuteNonQuery();
            //DELETING RECORDS FROM BOTH TABLES
            cmd = new SqlCommand("delete from investment where order_id = @n", con);
            cmd.Parameters.AddWithValue("@n", id);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Deleted");
            con.Close();

            first_name_tb.Text = null;
            last_name_tb.Text = null;
            email_tb.Text = null;
            Phone_tb.Text = null;
            totalPrice_tb.Text = null;
            FillOrders();
            populateData();
        }
    }
}
