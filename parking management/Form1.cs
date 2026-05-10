using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace parking_management
{



    public partial class Form1 : Form
    {
        public string username;

        bool isPlaceholder = true;
        string conStr = @"Data Source=SOHARAB\SQLEXPRESS;Initial Catalog=userDB;Integrated Security=True;TrustServerCertificate=True";
        private DateTimePicker timePicker;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Bkash", "Naghad", "Card" });
            comboBox1.SelectedIndex = 0;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Text = "DHA-1234";
            textBox1.ForeColor = Color.Gray;
            isPlaceholder = true;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // If placeholder is active and user starts typing
            if (isPlaceholder)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                isPlaceholder = false;
                return;
            }

            // If user deletes everything → restore placeholder
            if (textBox1.Text == "")
            {
                isPlaceholder = true;
                textBox1.Text = "DHA-1234";
                textBox1.ForeColor = Color.Gray;

                // Keep cursor at start
                textBox1.SelectionStart = 0;
            }

        }
        private void enter_Click(object sender, EventArgs e)
        {
            string vehicle = textBox1.Text.ToUpper();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                string query = @"SELECT TOP 1 *
                         FROM Parking
                         WHERE UPPER(VehicleNumber)=UPPER(@v)
                        AND (status='not paid' OR status IS NULL)
                         ORDER BY Id DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue("@v", vehicle);

                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;

                    // Show exit time picker
                    dateTimePicker1.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Vehicle not found!");
                }
            }
        }






        private void UpdateExitTime()
        {
            string vehicle = textBox1.Text.ToUpper();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                string query = @"UPDATE Parking
                         SET ExitTime=@exit
                        WHERE UPPER(VehicleNumber)=UPPER(@v)
                         AND (status='not paid' OR status IS NULL)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@exit", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@v", vehicle);

                cmd.ExecuteNonQuery();
            }
        }







        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void confirm_Click(object sender, EventArgs e)
        {
            string vehicle = textBox1.Text.ToUpper();

            // Remove BDT text
            string costText = textBoxTotalCost.Text.Replace("BDT", "").Trim();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                string query = @"UPDATE Parking
                         SET TotalCost=@cost,
                             status='paid'
                         WHERE UPPER(VehicleNumber)=UPPER(@v)
                         AND (status='not paid' OR status IS NULL)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@cost", costText);
                cmd.Parameters.AddWithValue("@v", vehicle);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Payment Successful!");

                // Refresh Grid
                string refreshQuery = @"SELECT TOP 1 *
                                FROM Parking
                               WHERE UPPER(VehicleNumber)=UPPER(@v)
                                ORDER BY Id DESC";

                SqlDataAdapter da = new SqlDataAdapter(refreshQuery, con);

                da.SelectCommand.Parameters.AddWithValue("@v", vehicle);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            // Fix: Cast sender to DateTimePicker before accessing Format and CustomFormat
            DateTimePicker picker = sender as DateTimePicker;
            if (picker != null)
            {
                picker.Format = DateTimePickerFormat.Custom;
                picker.CustomFormat = "HH:mm:ss"; // 24-hour format with seconds
            }
        }
        private void calculate_Click(object sender, EventArgs e)
        {
            string vehicle = textBox1.Text.ToUpper();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                string query = @"SELECT TOP 1 EntryTime
                         FROM Parking
                         WHERE UPPER(VehicleNumber)=UPPER(@v)
                         AND (status='not paid' OR status IS NULL)
                         ORDER BY Id DESC";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@v", vehicle);

                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Vehicle not found!");
                    return;
                }

                DateTime entryTime = Convert.ToDateTime(result);

                // User selected exit time
                DateTime exitTime = dateTimePicker1.Value;

                // Update DB exit time
                UpdateExitTime();

                TimeSpan diff = exitTime - entryTime;

               // double hours = Math.Ceiling(diff.TotalHours);
                double hours =diff.TotalHours;

                double rate = 100;

                double total = hours * rate;

                //textBoxTotalCost.Text = total.ToString() + " BDT";
                textBoxTotalCost.Text = ((int)total).ToString() + " BDT";

                // Refresh grid
                string refreshQuery = @"SELECT TOP 1 *
                                FROM Parking
                                WHERE UPPER(VehicleNumber)=UPPER(@v)
                                ORDER BY Id DESC";

                SqlDataAdapter da = new SqlDataAdapter(refreshQuery, con);

                da.SelectCommand.Parameters.AddWithValue("@v", vehicle);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Directly call the calculate_Click handler instead of trying to attach an event to 'calculate'
            calculate_Click(sender, e);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.username = username;

            d.Show();
            this.Hide();
          //  this.Close();
        }
    }
}
