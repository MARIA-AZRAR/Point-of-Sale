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
    public partial class SalesWindow : Form
    {
        public SalesWindow()
        {
            InitializeComponent();
             FillComboBox();
            FillQuantity();  //now fill quantity after combo

        }


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

        private void SalesWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
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

        string getID(string n)
        {
            string name = n;
            string id = "0";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select manufacturer_id from manufacturer where name ='" + name + "'", con);
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

        //Populate Data
        private void populateData()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select p.product_id,p.pr_name,p.price, p.units, m.name as 'Manufacturer' from Product p inner join manufacturer m on p.manufacturer_id = m.manufacturer_id", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            products_dgv.DataSource = dt;
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
    }
}
