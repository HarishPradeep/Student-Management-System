using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_University.classes
{
    class assignstd
    {

        public int id { get; set; }
        public int std_id { get; set; }
        public int cou_id { get; set; }
        public string adddate { get; set; }
        public string status { get; set; }


        static string conn = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        //Insert Method
        public bool insert(assignstd c)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(conn);

            try
            {
                //Insert Query
                string sqlQuery = "INSERT INTO student_course(id,adddate,status,std_id,cou_id) VALUES (@id,@adddate,@status,@stdID,@couID)";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@id", c.id);
                cmd.Parameters.AddWithValue("@adddate", c.adddate);
                cmd.Parameters.AddWithValue("@status", c.status);
                cmd.Parameters.AddWithValue("@stdID", c.std_id);
                cmd.Parameters.AddWithValue("@couID", c.cou_id);

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
