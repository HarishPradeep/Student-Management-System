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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        insertST st = new insertST();

        private void button1_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            Home hs = new Home();
            hs.Show();
        }

        private void student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffordUniversityDataSet6.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.staffordUniversityDataSet6.course);
            // TODO: This line of code loads data into the 'staffordUniversityDataSet4.register' table. You can move, or remove it, as needed.
            this.registerTableAdapter.Fill(this.staffordUniversityDataSet4.register);

        }

        private void AddStd_Click(object sender, EventArgs e)
        {

            try { 
            
                st.std_id = int.Parse(std_id.Text);
                st.std_name = std_name.Text;
                st.mobile_num = int.Parse(mob_num.Text);
                st.course = course.SelectedValue.ToString();
                st.address = address.Text;
                st.dob = dob.Text;
                st.regg_id = int.Parse(reg_id.SelectedValue.ToString());



                bool ïsSuccess = st.insert(st);
                if (ïsSuccess == true)
                {
                    MessageBox.Show("Successfully Added");
                    std_id.Text = "";
                    std_name.Text = "";
                    mob_num.Text = "";
                    address.Text = "";
                    dob.Text = "";
                    reg_id.Text = "";
                }
                else
                {
                    MessageBox.Show("Error found !");
                }

               }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        


    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
