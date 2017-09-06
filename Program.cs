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
            
            Console.WriteLine("finished");
        }

        static void SiteCrawler()
        {
            string myLines = "";
            Console.WriteLine("console line is this");
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://providence.craigslist.org/search/sss?query=supra&sort=rel");
            var HeaderNames = doc.DocumentNode
                .SelectNodes("//a").ToList();
            foreach (var item in HeaderNames)
            {
                Console.WriteLine(item.InnerHtml);
                myLines += item.InnerHtml;
                
            }
            StoreData(myLines);
        }

        static void StoreData(string writethis)
        {
            string lines = "save me";
            string path = Directory.GetCurrentDirectory();
            string mypath = @".. \" + path;
            //Console.WriteLine(path);
            //Console.WriteLine(mypath);
            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\rober\\Documents\\Visual Studio 2015\\Projects\\ConsoleApplication1\\myfile.txt");
            file.WriteLine(writethis);
            file.Close();
        }
    }
}
