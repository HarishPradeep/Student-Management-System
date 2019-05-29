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

    public partial class LecturePanel : Form
    {
        public LecturePanel()
        {
            InitializeComponent();
        }
        insertLib lib = new insertLib();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LecturePanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffordUniversityDataSet3.lec_table' table. You can move, or remove it, as needed.
            this.lec_tableTableAdapter.Fill(this.staffordUniversityDataSet3.lec_table);

            // TODO: This line of code loads data into the 'staffordUniversityDataSet1.register' table. You can move, or remove it, as needed.
            this.registerTableAdapter.Fill(this.staffordUniversityDataSet1.register);


        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            lib.lec_id = int.Parse(lecID.Text);
            lib.lec_name = lecName.Text;
            lib.status = lecStatus.Text;
            lib.spl = lecSpl.Text;
            lib.dob = lecDOB.Text;
            lib.add = lecAdd.Text;
            lib.addDate = addedDate.Text;
            lib.regg_id = int.Parse(reg_id.SelectedValue.ToString());
            bool done = lib.insert(lib);
            if (lecID.Text == "" || lecName.Text == "" || lecStatus.Text == "" || lecSpl.Text == "" || lecSpl.Text == "" || lecAdd.Text == "")
            {
                MessageBox.Show("Empty Inputs");
            }
            else if (done == true)
            {
                MessageBox.Show("Successfully Added");
                lecID.Text = "";
                lecName.Text = "";
                lecStatus.Text = "";
                lecSpl.Text = "";
                lecAdd.Text = "";




            }
            else
            {
                MessageBox.Show("Error found ! ");
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool temp = false;
            String conn = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);
            int id = int.Parse(lec_id.Text);
            string sqlQuery = "SELECT * FROM lec_table WHERE lec_id = '" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lecID.Text = dr.GetString(1);
                lecName.Text = dr.GetString(2);
                temp = true;

            }
            if (temp == false)
                MessageBox.Show("not found");
            con.Close();



        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
