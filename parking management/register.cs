using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace parking_management
{
    public partial class register : Form
    {
        readonly string cs = @"Data Source=SOHARAB\SQLEXPRESS;Initial Catalog=userDB;Integrated Security=True;TrustServerCertificate=True";
        public register()
        {
            InitializeComponent();

        }

        private void registerButtom_Click(object sender, EventArgs e)
        {
            // EMPTY FIELD CHECK
            if (textBox1.Text == "" || textBox2.Text == "" ||
               textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else
            {

                SqlConnection con = new SqlConnection(cs);

                con.Open();

                // CHECK USER EXISTS
                string checkQuery = "SELECT COUNT(*) FROM usersInfo WHERE username=@u";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);

                checkCmd.Parameters.AddWithValue("@u", textBox1.Text);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Account Already Created");
                }
                else
                {
                    // PASSWORD MATCH CHECK
                    if (textBox3.Text == textBox4.Text)
                    {
                        string query = "INSERT INTO usersInfo(username,password,email) VALUES(@u,@p,@e)";

                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@u", textBox1.Text);
                        cmd.Parameters.AddWithValue("@e", textBox2.Text);
                        cmd.Parameters.AddWithValue("@p", textBox3.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registration Successful");

                        login l = new login();

                        l.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password Not Match");
                    }
                }


                con.Close();
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            login l = new login();

            l.Show();

            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = false;
                textBox4.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
                textBox4.UseSystemPasswordChar = true;
            }
        }

  

        private void register_Load(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
            textBox4.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
