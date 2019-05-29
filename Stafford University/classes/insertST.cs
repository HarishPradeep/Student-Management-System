using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_University.classes
{
    class insertST
    {

        public int std_id { get; set; }
        public string std_name { get; set; }
        public int mobile_num { get; set; }
        public string course { get; set; }
        public string address { get; set; }
        public string dob { get; set; }
        public int regg_id { get; set; }

        static string conn = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        //Insert Method
        public bool insert(insertST c)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(conn);

            try
            {
                //Insert Query
                string sqlQuery = "INSERT INTO std_table(std_id,std_name,mob_num,course,address,dob,reg_id) VALUES (@std_id,@std_name,@mobile_num,@course,@address,@dob,@reg_id)";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@std_id", c.std_id);
                cmd.Parameters.AddWithValue("@std_name", c.std_name);
                cmd.Parameters.AddWithValue("@mobile_num", c.mobile_num);
                cmd.Parameters.AddWithValue("@course", c.course);
                cmd.Parameters.AddWithValue("@address", c.address);
                cmd.Parameters.AddWithValue("@dob", c.dob);
                cmd.Parameters.AddWithValue("@reg_id", c.regg_id);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
    }
}
