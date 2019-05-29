using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stafford_University
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();  //Hide CUrrent Interface
            new login().Show(); //Show Login Interface
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           new interfaceforlecture().Show();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new helpscreen().Show();
        }
    }
}
