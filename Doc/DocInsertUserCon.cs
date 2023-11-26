using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_System
{
    public partial class DocInsertUserCon : UserControl
    {
        public DocInsertUserCon()
        {
            InitializeComponent();
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DocInsertUserCon_Load(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void kryptonTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void kryptonTextBox3_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void kryptonTextBox4_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void kryptonTextBox5_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void kryptonTextBox6_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void kryptonTextBox7_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void kryptonTextBox8_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void DocInsertUserCon_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kryptonTextBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AMIR;Initial Catalog=hospital;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Doctor values('" + kryptonTextBox2.Text + "','" + kryptonTextBox1.Text + "','" + kryptonTextBox3.Text + "','" + kryptonTextBox4.Text + "','" + kryptonTextBox5.Text + "','" + kryptonTextBox6.Text + "','" + kryptonTextBox7.Text + "','" + kryptonTextBox8.Text + "')", con);
            con.Open();


            try
            {
                int NRowEff = cmd.ExecuteNonQuery();
                if (NRowEff > 0)
                {
                    MessageBox.Show("Data Inserted.");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with your data");
                MessageBox.Show(ex.ToString());


            }
            con.Close();
        }
    }
}
