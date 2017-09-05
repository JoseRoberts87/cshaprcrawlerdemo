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
            SiteCrawler();
            StoreData();
            Console.WriteLine("finished");
        }

        static void SiteCrawler()
        {
            Console.WriteLine("console line is this");
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://providence.craigslist.org/search/sss?query=supra&sort=rel");
            var HeaderNames = doc.DocumentNode
                .SelectNodes("//a").ToList();
            foreach (var item in HeaderNames)
            {
                Console.WriteLine(item.InnerHtml);
            }
        }
        
        static void StoreData()
        {
            string lines = "save me";
            string path = Directory.GetCurrentDirectory();
            string mypath = Environment.CurrentDirectory + @"\ ..";
            Console.WriteLine(path);
            Console.WriteLine(mypath);
            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\rober\\Documents\\Visual Studio 2015\\Projects\\ConsoleApplication1\\myfile.txt");
            file.WriteLine(lines);
            file.Close();
        }
    }
}
