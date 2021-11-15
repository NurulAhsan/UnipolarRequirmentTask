using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RecruitmentTask.TADAClass
{
    class tadaclass
    {
        public string Date { get; set; }
        public string EmployeeName { get; set; }
        public string TravelCost{ get; set; }
        public string LunchCost { get; set; }
        public string InstrumentCost { get; set; }
        public string TotalCost { get; set; }
        public string Paid { get; set; }

        static string myconnection = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            
            try
            {
                string sql = "SELECT * from DataEntry";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                conn.Open();
                sda.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //Inserting data into Database;
        public bool Insert (tadaclass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);

            try
            {
                
                string sql = "INSERT INTO DataEntry(Date,Name,TravelCost,LunchCost,InstrumentCost,Paid) values(@Date,@Name,@TravelCost,@LunchCost,@InstrumentCost,@Paid)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                

                cmd.Parameters.AddWithValue("@Date", c.Date);
                cmd.Parameters.AddWithValue("@Name", c.EmployeeName);
                cmd.Parameters.AddWithValue("@TravelCost", c.TravelCost);
                cmd.Parameters.AddWithValue("@LunchCost", c.LunchCost);
                cmd.Parameters.AddWithValue("@InstrumentCost", c.InstrumentCost);
                cmd.Parameters.AddWithValue("@Paid", c.Paid);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows>0)
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

                
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
            

            
        }
        
    }
}
