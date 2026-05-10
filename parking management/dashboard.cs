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

namespace parking_management
{
    public partial class dashboard : Form
    {
        public string username;
        string cs= @"Data Source=SOHARAB\SQLEXPRESS;Initial Catalog=userDB;Integrated Security=True;TrustServerCertificate=True";
        private Label labelUsername;

        public dashboard()
        {
            InitializeComponent();

        }
        // LOAD ALL DATA
        void LoadData()
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM Parking";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            label10.Text ="Welcome,"+ username;

            LoadData();
            SlotCalculation();
        }

        private void button1_Click(object sender, EventArgs e)//Add booking
        {
            add a = new add();

            a.username = username;

            a.Show();

            this.Hide();
           // this.Close();

        }

        private void button2_Click(object sender, EventArgs e)//update booking
        {
          update u= new update();
           u.username = username;
            u.Show();
            this.Hide();
              //  this.Close();
        }

        private void button3_Click(object sender, EventArgs e)//delete booking
        {
            delete d = new delete();

            d.username = username;
            d.Show();

           this.Hide();
            //this.Close();

        }

        private void button4_Click(object sender, EventArgs e)//payment
        {
            Form1 f = new Form1();

            f.username = username;
            f.Show();

           this.Hide();
          //  this.Close();


        }

        private void button5_Click(object sender, EventArgs e)//search booking
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM Parking WHERE UPPER(VehicleNumber)=UPPER(@v)";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            da.SelectCommand.Parameters.AddWithValue("@v", textBox1.Text);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Vehicle Found");
            }
            else
            {
                MessageBox.Show("Vehicle Not Found");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login l = new login();

            l.Show();

           this.Hide();
            //this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        //slot calculation
        void SlotCalculation()
        {
            SqlConnection con = new SqlConnection(cs);

            con.Open();

            string query = "SELECT COUNT(*) FROM Parking";

            SqlCommand cmd = new SqlCommand(query, con);

            int occupied = (int)cmd.ExecuteScalar();

            int total = 100;

            int available = total - occupied;

            // SHOW VALUES IN LABELS
            label7.Text = total.ToString();

            label8.Text = occupied.ToString();

            label9.Text = available.ToString();

            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            LoadData();
        }
    }
}
