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
    public partial class DepUpdateUserControl1 : UserControl
    {
        public DepUpdateUserControl1()
        {
            InitializeComponent();
        }

        private void kryptonTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kryptonTextBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void DepUpdateUserControl1_Load(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=AMIR;Initial Catalog=hospital;Integrated Security=True");
          
                SqlCommand cmd = new SqlCommand("select dept_id from Department", conn);

                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    kryptonComboBox1.Items.Add(sdr["dept_id"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }

        private void DepUpdateUserControl1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=AMIR;Initial Catalog=hospital;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("select dept_name,dept_id from Department where dept_id = '" + kryptonComboBox1.Text + "'", conn);

                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    kryptonTextBox1.Text = sdr[0].ToString();
                    kryptonTextBox2.Text = sdr[1].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error");

                MessageBox.Show(ex.ToString());
            }
            
           


        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=AMIR;Initial Catalog=hospital;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update Department set dept_id ='"+ kryptonTextBox2 .Text+ "', dept_name='"+ kryptonTextBox1.Text+"' where dept_id = '"+kryptonComboBox1.Text+"' ", con);
            con.Open();


            try
            {
                int NRowEff = cmd.ExecuteNonQuery();
                if (NRowEff > 0)
                {
                    MessageBox.Show("Data Updated.");
                    kryptonTextBox1.Clear();
                    kryptonTextBox2.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with your data");


            }
            con.Close();


        }
    }
}
