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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            student lk = new student();
            lk.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            LecturePanel lk = new LecturePanel();
            lk.Show();
        }

        private void Course_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            course cu = new course();
            cu.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            login lg = new login();
            lg.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
           new assignCourse().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new catlog().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new assignStudents().Show();
        }
    }
}
