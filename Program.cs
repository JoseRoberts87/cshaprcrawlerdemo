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
                SiteCrawler(userTicker);
            }      
            Console.WriteLine("finished\npress any key to exit.");
            Console.ReadLine();
        }

        static void SiteCrawler(string ticker)
        {
            string myLines = "";
            string linkSite = String.Format("https://finance.yahoo.com/quote/{0}?p={0}", ticker);
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(linkSite);
            var HeaderNames = doc.DocumentNode
                .SelectNodes("//div[contains(@data-test,'summary-table')]//tr").ToList();
            foreach (var item in HeaderNames)
            {
                Console.WriteLine(item.InnerHtml);
                myLines += item.InnerHtml;
            }
            StoreData(myLines);
        }

        static void StoreData(string writethis)
        {
            string path = Directory.GetCurrentDirectory();
            string mypath = @".. \" + path;
            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\rober\\Documents\\Visual Studio 2015\\Projects\\ConsoleApplication1\\myfile.txt");
            file.WriteLine(writethis);
            file.Close();
        }
    }
}
