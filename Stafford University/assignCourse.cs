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
    public partial class assignCourse : Form
    {
        public assignCourse()
        {
            InitializeComponent();
        }
        assignCouPro c = new assignCouPro();

        private void assignCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffordUniversityDataSet11.course_professor' table. You can move, or remove it, as needed.
            this.course_professorTableAdapter.Fill(this.staffordUniversityDataSet11.course_professor);
            // TODO: This line of code loads data into the 'staffordUniversityDataSet10.lec_table' table. You can move, or remove it, as needed.
            this.lec_tableTableAdapter.Fill(this.staffordUniversityDataSet10.lec_table);
            // TODO: This line of code loads data into the 'staffordUniversityDataSet9.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.staffordUniversityDataSet9.course);
            // TODO: This line of code loads data into the 'staffordUniversityDataSet8.courseForPro' table. You can move, or remove it, as needed.
           

        }

        private void button1_Click(object sender, EventArgs e)

        {
            MessageBox.Show("Fill out the form");

            c.id = int.Parse(id.Text);
            c.adddate= adddate.Text;
            c.status = status.Text;
            c.pro_id = int.Parse(pro_id.SelectedValue.ToString());
            c.cou_id = int.Parse(cou_id.SelectedValue.ToString());



            bool done = c.insert(c);
            if (done == true)
            {
                MessageBox.Show("Successfully Assigned");
               
            }
            else
            {
                MessageBox.Show("Error found ! Try again later ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
