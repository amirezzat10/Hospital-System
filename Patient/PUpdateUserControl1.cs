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
    public partial class PUpdateUserControl1 : UserControl
    {
        public PUpdateUserControl1()
        {
            InitializeComponent();
        }

        private void PUpdateUserControl1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=AMIR;Initial Catalog=hospital;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("select id from Doctor", conn);

                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    comboBox1.Items.Add(sdr["id"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }
    }
}
