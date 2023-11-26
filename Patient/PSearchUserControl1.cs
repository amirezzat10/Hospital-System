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
    public partial class PSearchUserControl1 : UserControl
    {
        public PSearchUserControl1()
        {
            InitializeComponent();
        }

        private void PSearchUserControl1_Load(object sender, EventArgs e)
        {
            var select = "SELECT * FROM patient";
            var c = new SqlConnection("Data Source=AMIR;Initial Catalog=hospital;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
