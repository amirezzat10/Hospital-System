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
    public partial class DocDeleteUserCon : UserControl
    {
        public DocDeleteUserCon()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DocDeleteUserCon_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=AMIR;Initial Catalog=hospital;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("select id from Doctor", conn);

                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    kryptonComboBox1.Items.Add(sdr["id"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=AMIR;Initial Catalog=hospital;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("select * from Doctor where id = '" + kryptonComboBox1.Text + "'", conn);

                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    label12.Text = sdr[0].ToString();
                    label11.Text = sdr[1].ToString();
                    label13.Text = sdr[2].ToString();
                    label14.Text = sdr[3].ToString();
                    label15.Text = sdr[4].ToString();
                    label16.Text = sdr[5].ToString();
                    label17.Text = sdr[6].ToString();
                    label18.Text = sdr[7].ToString();

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
            SqlConnection conn = new SqlConnection(@"Data Source=AMIR;Initial Catalog=hospital;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("delete from Doctor where id='" + kryptonComboBox1.Text + "' ", conn);
            conn.Open();

            int NRowEff = cmd.ExecuteNonQuery();
            if (NRowEff > 0)
            {
                MessageBox.Show("Data Deleted.");


            }
        }
    }
}
