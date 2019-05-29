using Stafford_University.classes;
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
    public partial class course : Form
    {
        public course()
        {
            InitializeComponent();
        }

        insertCou cu = new insertCou();

        private void course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffordUniversityDataSet5.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.staffordUniversityDataSet5.course);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cu.cou_id = int.Parse(cou_id.Text);
            cu.cou_name = cou_name.Text;
            cu.status = status.Text;
            cu.fees = int.Parse(fee.Text);
            cu.duration = duration.Text;
           


            bool done = cu.insert(cu);
            if (done == true)
            {
                MessageBox.Show("Successfully Added");
                cou_id.Text = "";
                cou_name.Text = "";
                status.Text = "";
                fee.Text = "";
                duration.Text = "";
            }
            else
            {
                MessageBox.Show("Error found ! ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }
    }
}
