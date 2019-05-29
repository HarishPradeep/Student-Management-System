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
    public partial class roster : Form
    {
        public roster()
        {
            InitializeComponent();
            view();
        }

        public void view()
        {
            string conn = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlDataAdapter adpter = new SqlDataAdapter("SELECT student_course.id, std_table.std_name,std_table.mob_num, course.cou_name,course.fee,course.duration,student_course.adddate,student_course.status FROM student_course JOIN std_table ON student_course.std_id = std_table.std_id JOIN course  ON student_course.cou_id = course.cou_id", con);
            DataTable dt = new DataTable();
            adpter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void roster_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new interfaceforlecture().Show();
        }
    }
}
