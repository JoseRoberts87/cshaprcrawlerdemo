using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication1.Model.Data
{
    class ScraperDAO
    {
        public static void getDB()
        {
            AddRecord();
            RemoveRecord();
            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("Press Enter To Continue....");
            Console.ReadLine();
        }

        static void AddRecord()
        {
            string sConnectionString = "User ID=<UID>;Initial Catalog=pubs;Data Source=(local)";
            SqlConnection objConn = new SqlConnection(sConnectionString);
            objConn.Open();
            string sSQL = "INSERT INTO Ticker " +
              "(emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date) " +
                      "VALUES ('MSD12923F', 'Duncan', 'W', 'Mackenzie', 10, 82,'0877','2001-01-01')";
            SqlCommand objCmd = new SqlCommand(sSQL, objConn);
            try
            {
                objCmd.ExecuteNonQuery();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Record Added");
        }

        static void RemoveRecord()
        {
            string sConnectionString = "User ID=<UID>;Initial Catalog=pubs;Data Source=(local)";
            SqlConnection objConn = new SqlConnection(sConnectionString);
            objConn.Open();
            string sSQL = "DELETE FROM Employee WHERE emp_id = @emp_id";
            SqlCommand objCmd = new SqlCommand(sSQL, objConn);
            objCmd.Parameters.Add("@emp_id", SqlDbType.Char, 9);
            objCmd.Parameters["@emp_id"].Value = "MSD12923F";
            try
            {
                objCmd.ExecuteNonQuery();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Record Deleted");
        }
    }
}