﻿using System;
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
    public partial class SalesWindow : Form
    {
        public SalesWindow()
        {
            InitializeComponent();
            FillCustomer();
            FillComboBox();
            FillQuantity();  //now fill quantity after combo
           // populateData();
        }

        int saveID = 0;    //as our order will be saved multiple times so it will help in avoiding it
        SqlConnection con = new SqlConnection("Data Source = desktop-iumas6g; Initial Catalog = POS; Integrated Security = True");

        //filling products and quantity
        void FillComboBox()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select pr_name from Product order by pr_name ASC", con);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product_cb.Items.Add(reader["pr_name"]);
            }
            con.Close();
            reader.Close();
        }


        //getting quantity of selected Produdct
        void FillQuantity()
        {
            string quantity = "15";

            for(int i = 0; i< Int16.Parse(quantity); ++i)
            {
                quantity_cb.Items.Add(i+1);
            }

        }

        void FillCustomer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select customer_id from Customer order by customer_id ASC", con);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                customer_cb.Items.Add(reader["customer_id"]);
            }
            con.Close();
            reader.Close();
        }

        private void SalesWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

       
        //Populate Data
         private void populateData()
        {
            con.Open();
            string query = "select i.order_id, p.pr_name as 'Product', d.quantity, i.order_date, p.price*d.quantity as 'Price' from investment i inner join orderDetails d on i.order_id = d.order_id inner join Product p on d.product_id = p.product_id ";
            SqlDataAdapter adapter = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            salesWindow_dgv.DataSource = dt;
            con.Close();
        }


        //delete all of the given order id
        private void reset_btn_Click(object sender, EventArgs e)
        {
            con.Open();

            string id = id_tb.Text;   
            SqlCommand cmd = new SqlCommand("delete from orderDetails where order_id = @n", con);
            cmd.Parameters.AddWithValue("@n", id);
            cmd.ExecuteNonQuery();
                                                        //DELETING RECORDS FROM BOTH TABLES
            cmd = new SqlCommand("delete from investment where order_id = @n", con);
            cmd.Parameters.AddWithValue("@n", id);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Deleted");
            con.Close();
        }

        private void Product_save_btn_Click(object sender, EventArgs e)
        {
            string customer_id = this.customer_cb.GetItemText(this.customer_cb.SelectedItem);
            string product = this.Product_cb.GetItemText(this.Product_cb.SelectedItem);
            string quantity = this.quantity_cb.GetItemText(this.quantity_cb.SelectedItem);
            string OName = this.orderName_tb.Text;
            string date = DateTime.UtcNow.ToString("yyyy-MM-dd");  //getting date
            string ProductId = getPID(product);   //getting id
            SqlCommand cmd;
            if (saveID == 0)
            {
                con.Open();
                cmd = new SqlCommand("insert into investment(order_date, customer_id, order_name)  values(@a, @b, @c)", con);

                cmd.Parameters.AddWithValue("@a", date);
                cmd.Parameters.AddWithValue("@b", customer_id);
                cmd.Parameters.AddWithValue("@c", OName);
                cmd.ExecuteNonQuery();
                con.Close();
                saveID++;
            }
           

            string orderId = getOID(OName);

            con.Open();
            cmd = new SqlCommand("insert into orderDetails(order_id, product_id,quantity) values(@a, @b, @c)", con);

            cmd.Parameters.AddWithValue("@a", orderId);
            cmd.Parameters.AddWithValue("@b", ProductId);
            cmd.Parameters.AddWithValue("@c", quantity);
            cmd.ExecuteNonQuery();

            MessageBox.Show("successfuly Selected");
            con.Close();
            populateData();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            saveID = 0;
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            saveID = 0;  //again setting it to 0 for new order
        }

        string getPID(string n)
        {
            string name = n;
            string id = "0";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select product_id from Product where pr_name ='" + name + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                id = dt.Rows[0][0].ToString();
            }
            catch
            {
                MessageBox.Show("Add some Data First");
            }

            con.Close();
            return id;
        }

        string getOID(string n)
        {
            string name = n;
            string id = "0";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select order_id from investment where order_name ='" + name + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                id = dt.Rows[0][0].ToString();
            }
            catch
            {
                MessageBox.Show("Add some Data First");
            }

            con.Close();
            return id;
        }
    }
}
