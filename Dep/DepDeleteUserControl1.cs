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
    public partial class DepDeleteUserControl1 : UserControl
    {
        public DepDeleteUserControl1()
        {
            InitializeComponent();
        }

        private void docInsertUserCon1_Load(object sender, EventArgs e)
        {

        }

        private void DepDeleteUserControl1_Load(object sender, EventArgs e)
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
                    namelbl.Text = sdr[0].ToString();
                    IDlbl.Text = sdr[1].ToString();
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

            SqlCommand cmd = new SqlCommand("delete from Department where dept_id='"+kryptonComboBox1.Text+"' ", conn);
            conn.Open();

            int NRowEff = cmd.ExecuteNonQuery();
            if (NRowEff > 0)
            {
                MessageBox.Show("Data Deleted.");


            }
        }
    }
}
