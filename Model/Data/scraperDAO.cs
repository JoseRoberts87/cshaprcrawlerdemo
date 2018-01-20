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
            string sConnectionString = "User ID=<dbo>;Initial Catalog=pubs;Data Source=(local)";
            SqlConnection objConn = new SqlConnection(sConnectionString);
            objConn.Open();
            string sSQL = "INSERT INTO symbols " +
              "(tikername) " + "VALUES ('AAPL')";
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
            string sConnectionString = "User ID=<dbo>;Initial Catalog=pubs;Data Source=(local)";
            SqlConnection objConn = new SqlConnection(sConnectionString);
            objConn.Open();
            string sSQL = "DELETE FROM symbols WHERE tickername = AAPL";
            SqlCommand objCmd = new SqlCommand(sSQL, objConn);
            objCmd.Parameters.Add("@tickername", SqlDbType.Char, 4);
            objCmd.Parameters["@tickername"].Value = "AAPL";
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