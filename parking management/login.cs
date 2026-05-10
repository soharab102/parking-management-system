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
    public partial class login : Form
    {
        private readonly string cs = @"Data Source=SOHARAB\SQLEXPRESS;Initial Catalog=userDB;Integrated Security=True;TrustServerCertificate=True";

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

        public login()
        {
            InitializeComponent();
            textBox1 = usernameTB;
            textBox2 = passwordTB;
        }

        private void login_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);

                con.Open();

                string query = "SELECT COUNT(*) FROM usersInfo WHERE username=@u AND password=@p";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@u", textBox1.Text);
                cmd.Parameters.AddWithValue("@p", textBox2.Text);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Login Successful");

                    dashboard d = new dashboard();

                    d.username = textBox1.Text;

                    d.Show();

                    this.Hide();
                    //this.Close();
                }

                else
                {
                    MessageBox.Show("Account Not Found. Please Register First");
                }

                con.Close();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            register r = new register();

            r.Show();

           this.Hide();
          //this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         if(checkBox1.Checked)
            {
                passwordTB.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTB.UseSystemPasswordChar = true;
            }
        }
    }
}
