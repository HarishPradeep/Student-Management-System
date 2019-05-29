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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

              String conn = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
              string sqlQuery = "SELECT COUNT(*) FROM users WHERE username=@username AND pwd=@pwd ";
              SqlConnection con = new SqlConnection(conn);
              SqlCommand cmd = new SqlCommand(sqlQuery, con);
              cmd.Parameters.AddWithValue("@username", username.Text );
              cmd.Parameters.AddWithValue("@pwd", password.Text);
          
              con.Open();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              if (dt.Rows.Count == 1)
              {
                  MessageBox.Show("Successfully Logged in ");
                  this.SetVisibleCore(false);
                  Home hm = new Home();
                  hm.Show();
                  username.Text = "";
                  password.Text = "";
              }
              else
              {
                  MessageBox.Show("Something went wrong Try again later ! ");
                  username.Text = "";
                  password.Text = "";
              } 
        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffordUniversityDataSet7.roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.staffordUniversityDataSet7.roles);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Text = "Haven't Registered Yet ? ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new index().Show();
        }
    }
}
