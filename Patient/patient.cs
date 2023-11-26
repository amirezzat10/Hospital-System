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
    public partial class patient : KryptonForm
    {
        public patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pInsertUserControl11.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pSearchUserControl11.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pUpdateUserControl11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pDeleteUserControl11.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubSystems subform = new SubSystems();
            subform.Show();
        }
    }
}
