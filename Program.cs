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
            if(Console.ReadLine().Equals("No", StringComparison.InvariantCultureIgnoreCase)  || userTicker == null || userTicker == "")
            {
                Console.WriteLine("Program terminated! \npress any key to exit.");
                Console.ReadLine();
            }
            else if(Console.ReadLine().Equals("Yes", StringComparison.InvariantCultureIgnoreCase))
            {
                SiteCrawler(userTicker);
            }      
            Console.WriteLine("finished");
        }

        static void SiteCrawler(string ticker)
        {
            string myLines = "";
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://finance.yahoo.com/quote/GOOG?p=GOOG");
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
