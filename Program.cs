using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enterTicker Symbol: ");
            //string userTicker = Console.ReadLine().ToUpper();
            //Console.WriteLine("you entered: " + userTicker);
            //string userResponse = Console.ReadLine();
            //if(userResponse.Equals("No", StringComparison.InvariantCultureIgnoreCase)  || userTicker == null || userTicker == "")
            //{
            //    Console.WriteLine("Program terminated!");
            //}
            //else if(userResponse.Equals("Yes", StringComparison.InvariantCultureIgnoreCase))
            //{
            //    Demo.Crawler.SiteCrawler(userTicker);
            //}      
            //Console.WriteLine("finished\npress any key to exit.");
            //Console.ReadLine();
        
        //public static void getDB()
        
            AddRecord();
            //RemoveRecord();
            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("Press Enter To Continue....");
            Console.ReadLine();
        }

        static void AddRecord()
        {
            string sConnectionString = "Data Source=LAPTOP-14O5V1I6;Initial Catalog=scraperdb;Integrated Security=True";
            SqlConnection objConn = new SqlConnection(sConnectionString);
            //objConn.ConnectionString = sConnectionString;
            Console.WriteLine("Program 1!");
            objConn.Open();
            Console.WriteLine("Program 2!");
            string sSQL = "INSERT INTO symbols " +
              "(tickername) " + "VALUES ('AAPL')";
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

