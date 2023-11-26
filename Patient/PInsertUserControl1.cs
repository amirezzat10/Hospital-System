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
    public partial class PInsertUserControl1 : UserControl
    {
        public PInsertUserControl1()
        {
            InitializeComponent();
        }

        private void PInsertUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AMIR;Initial Catalog=hospital;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into patient values('" + kryptonTextBox2.Text + "','" + kryptonTextBox1.Text + "','" + kryptonTextBox6.Text + "','" + kryptonTextBox7.Text + "','" + kryptonTextBox4.Text + "','" + kryptonTextBox5.Text + "','" + kryptonTextBox8.Text + "','" + kryptonTextBox3.Text + "','" + kryptonTextBox9.Text + "')", con);
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
