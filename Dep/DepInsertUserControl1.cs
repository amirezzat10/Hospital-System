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
    public partial class DepInsertUserControl1 : UserControl
    {
        public DepInsertUserControl1()
        {
            InitializeComponent();
        }

        private void kryptonTextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DepInsertUserControl1_MouseClick(object sender, MouseEventArgs e)
        {
            


        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AMIR;Initial Catalog=hospital;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Department values('"+DeptIDtxt.Text+"','"+DeptNametxt.Text+"')", con);
            con.Open();

        
            try
            {
                int NRowEff = cmd.ExecuteNonQuery();
                if (NRowEff > 0)
                {
                    MessageBox.Show("Data Inserted.");
                    DeptIDtxt.Clear();
                    DeptNametxt.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with your data");


            }
            con.Close();
        }

        private void DepInsertUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void DeptNametxt_Click(object sender, EventArgs e)
        {
            DeptNametxt.Text = "";
        }

        private void DeptIDtxt_Click(object sender, EventArgs e)
        {
            DeptIDtxt.Text = "";
        }
    }
}
