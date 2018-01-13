using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enterTicker Symbol: ");
            string userTicker = Console.ReadLine().ToUpper();
            Console.WriteLine("you entered: " + userTicker);
            string userResponse = Console.ReadLine();
            if(userResponse.Equals("No", StringComparison.InvariantCultureIgnoreCase)  || userTicker == null || userTicker == "")
            {
                Console.WriteLine("Program terminated!");
            }
            else if(userResponse.Equals("Yes", StringComparison.InvariantCultureIgnoreCase))
            {
                Crawler.SiteCrawler(userTicker);
            }      
            Console.WriteLine("finished\npress any key to exit.");
            Console.ReadLine();
        }

        

    }
}
