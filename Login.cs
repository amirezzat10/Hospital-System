using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;


namespace Hospital_System
{
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SubSystems f2 = new SubSystems();
            f2.Show();

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AMIR;Initial Catalog=hospital;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from admin where username ='" + kryptonTextBox1.Text + "'and password = '" + kryptonTextBox2.Text + "'", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                SubSystems f2 = new SubSystems();
                f2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Username or Password \nPlease try again");
            }

            con.Close();
            
           

        }
    }
}
