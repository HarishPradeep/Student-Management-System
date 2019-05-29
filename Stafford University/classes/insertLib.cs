using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_University.classes
{
    class insertLib
    {
        public int lec_id { get; set; }
        public string lec_name { get; set; }
        public string  status { get; set; }
        public string spl { get; set; }
        public string dob { get; set; }
        public string add { get; set; }
        public string addDate { get; set; }
        public int regg_id { get; set; }

        static string conn = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        //Insert Method
        public bool insert(insertLib c)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(conn);

            try
            {
                //Insert Query
                string sqlQuery = "INSERT INTO lec_table (lec_id,lec_name,status,spl,dob,address,adddate,reg_id) VALUES (@lec_id,@lec_name,@status,@spl,@dob,@add,@addDate,@reg_id)";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@lec_id",c.lec_id);
                cmd.Parameters.AddWithValue("@lec_name", c.lec_name);
                cmd.Parameters.AddWithValue("@status", c.status);
                cmd.Parameters.AddWithValue("@spl", c.spl);
                cmd.Parameters.AddWithValue("@dob", c.dob);
                cmd.Parameters.AddWithValue("@add", c.add);
                cmd.Parameters.AddWithValue("@addDate", c.addDate);
                cmd.Parameters.AddWithValue("@reg_id", c.regg_id);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
                
            }
            catch(Exception ex)
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
