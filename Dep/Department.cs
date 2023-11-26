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
    public partial class Department : KryptonForm
    {
        public Department()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            depInsertUserControl11.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            depDeleteUserControl11.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            depUpdateUserControl11.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            depSearchUserControl11.BringToFront();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubSystems subform = new SubSystems();
            subform.Show();
        }

        private void Department_Load(object sender, EventArgs e)
        {

        }
    }
}
