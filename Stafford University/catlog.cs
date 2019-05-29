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
    public partial class catlog : Form
    {
        public catlog()
        {
            InitializeComponent();
            view();
        }
        public void view()
        {
            string conn = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);
            string sqlQuery = "INSERT INTO course(cou_id,cou_name,status,fee,duration) VALUES (@cou_id,@cou_name,@status,@fee,@duration)";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataAdapter adpter = new SqlDataAdapter("SELECT course_professor.id, lec_table.lec_name, course.cou_name,course.fee,course.duration,course_professor.adddate,course_professor.status FROM course_professor JOIN lec_table ON course_professor.pro_id = lec_table.lec_id JOIN course  ON course_professor.cou_id = course.cou_id", con);
            DataTable dt = new DataTable();
            adpter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void catlog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffordUniversityDataSet14.course_professor' table. You can move, or remove it, as needed.
            this.course_professorTableAdapter2.Fill(this.staffordUniversityDataSet14.course_professor);
            // TODO: This line of code loads data into the 'staffordUniversityDataSet13.course_professor' table. You can move, or remove it, as needed.
            this.course_professorTableAdapter1.Fill(this.staffordUniversityDataSet13.course_professor);
            // TODO: This line of code loads data into the 'staffordUniversityDataSet12.course_professor' table. You can move, or remove it, as needed.
            this.course_professorTableAdapter.Fill(this.staffordUniversityDataSet12.course_professor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.courseTableAdapter.FillBy(this.staffordUniversityDataSet5.course);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               
        }
    }
}
