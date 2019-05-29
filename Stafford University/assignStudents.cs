using Stafford_University.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stafford_University
{
    public partial class assignStudents : Form
    {
        public assignStudents()
        {
            InitializeComponent();
            view();
        }
        public void view()
        {
            string conn = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlDataAdapter adpter = new SqlDataAdapter("SELECT student_course.id, std_table.std_name, course.cou_name,course.fee,course.duration,student_course.adddate,student_course.status FROM student_course JOIN std_table ON student_course.std_id = std_table.std_id JOIN course  ON student_course.cou_id = course.cou_id", con);
            DataTable dt = new DataTable();
            adpter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        assignstd c = new assignstd();

        private void button1_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(ass_id.Text);
            c.adddate = adddate.Text;
            c.status = status.Text;
            c.std_id = int.Parse(stdid.SelectedValue.ToString());
            c.cou_id = int.Parse(couid.SelectedValue.ToString());



            bool done = c.insert(c);
            if (done == true)
            {
                MessageBox.Show("Successfully Added");

            }
            else
            {
                MessageBox.Show("Error found ! ");
            }
        }

        private void assignStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffordUniversityDataSet16.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.staffordUniversityDataSet16.course);
            // TODO: This line of code loads data into the 'staffordUniversityDataSet15.std_table' table. You can move, or remove it, as needed.
            this.std_tableTableAdapter.Fill(this.staffordUniversityDataSet15.std_table);

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
