using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_University.classes
{
    class insertCou
    {

        public int cou_id { get; set; }
        public string cou_name { get; set; }
        public string status { get; set; }
        public int fees { get; set; }
        public string duration { get; set; }
       

        static string conn = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        //Insert Method
        public bool insert(insertCou c)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(conn);

            try
            {
                //Insert Query
                string sqlQuery = "INSERT INTO course(cou_id,cou_name,status,fee,duration) VALUES (@cou_id,@cou_name,@status,@fee,@duration)";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@cou_id", c.cou_id);
                cmd.Parameters.AddWithValue("@cou_name", c.cou_name);
                cmd.Parameters.AddWithValue("@status", c.status);
                cmd.Parameters.AddWithValue("@fee", c.fees);
                cmd.Parameters.AddWithValue("@duration", c.duration);
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
