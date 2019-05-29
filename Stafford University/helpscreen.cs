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
    public partial class helpscreen : Form
    {
        public helpscreen()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new index().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new help1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new help2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new help3().Show();
        }
    }
}
