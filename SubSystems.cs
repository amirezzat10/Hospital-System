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

namespace Hospital_System
{
    public partial class SubSystems : KryptonForm
    {
        public SubSystems()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            patient p = new patient();
            p.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Department dp = new Department();
            dp.Show();

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Doctor D = new Doctor();
            D.Show();
            this.Hide();

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            patient p = new patient();
            p.Show();
            this.Hide();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Department dep = new Department();
            dep.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
