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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace parking_management
{
    public partial class update : Form
    {


       public  string username;
        string cs = @"Data Source=SOHARAB\SQLEXPRESS;Initial Catalog=userDB;Integrated Security=True;TrustServerCertificate=True";

        public update()
        {
            InitializeComponent();
        }

        private void update_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("A");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("C");
            comboBox1.Items.Add("D");
            comboBox1.Items.Add("E");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM Parking WHERE UPPER(VehicleNumber)=UPPER(@v)";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            // SEARCH TEXTBOX
            da.SelectCommand.Parameters.AddWithValue("@v", textBox4.Text);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                // SHOW DATA IN UPDATE FIELDS

                textBox1.Text = dt.Rows[0]["username"].ToString();

                textBox3.Text = dt.Rows[0]["EntryTime"].ToString();

                comboBox1.Text = dt.Rows[0]["slot"].ToString();
            }

            else
            {
                MessageBox.Show("Vehicle Not Found");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" ||
         comboBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");
            }

            else
            {
                SqlConnection con = new SqlConnection(cs);

                con.Open();

                string query = "UPDATE Parking SET username = @u, EntryTime = @e, slot = @s, ExitTime = NULL, TotalCost = NULL, status = NULL WHERE VehicleNumber = @v";

                SqlCommand cmd = new SqlCommand(query, con);

                // USERNAME
                cmd.Parameters.AddWithValue("@u", textBox1.Text);

                // ENTRY TIME
                cmd.Parameters.AddWithValue("@e", textBox3.Text);

                // SLOT
                cmd.Parameters.AddWithValue("@s", comboBox1.Text);

                // SEARCH VEHICLE
                cmd.Parameters.AddWithValue("@v", textBox4.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Updated Successfully");

                // SHOW UPDATED DATA
                string showQuery = "SELECT * FROM Parking WHERE VehicleNumber=@v";

                SqlDataAdapter da = new SqlDataAdapter(showQuery, con);

                da.SelectCommand.Parameters.AddWithValue("@v", textBox4.Text);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.username=username;
            d.Show();

           this.Hide();
               // this.Close();
        }
    }
}
