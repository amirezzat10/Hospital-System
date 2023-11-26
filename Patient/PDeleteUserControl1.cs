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
    public partial class PDeleteUserControl1 : UserControl
    {
        public PDeleteUserControl1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PDeleteUserControl1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=AMIR;Initial Catalog=hospital;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("select patientID from patient", conn);

                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    comboBox1.Items.Add(sdr["patientID"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection conn = new SqlConnection(@"Data Source=AMIR;Initial Catalog=hospital;Integrated Security=True");

            //    SqlCommand cmd = new SqlCommand("select * from patient where  = '" + comboBox1.Text + "'", conn);

            //    conn.Open();

            //    SqlDataReader sdr = cmd.ExecuteReader();

            //    if (sdr.Read())
            //    {
            //        label9.Text = sdr[0].ToString();
            //        label11.Text = sdr[1].ToString();
            //        label12.Text = sdr[2].ToString();
            //        label13.Text = sdr[3].ToString();
            //        label14.Text = sdr[4].ToString();
            //        label15.Text = sdr[5].ToString();
            //        label16.Text = sdr[6].ToString();


            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Error");

            //    MessageBox.Show(ex.ToString());
            //}
        }
    }
}
