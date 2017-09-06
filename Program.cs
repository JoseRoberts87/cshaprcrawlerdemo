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
            Console.WriteLine("enter URL :");
            string userUrl = Console.ReadLine();
            Console.WriteLine("you entered :" + userUrl);
            if(Console.ReadLine().Equals("Yes", StringComparison.InvariantCultureIgnoreCase))
            {
                SiteCrawler(userUrl);
            }       
            Console.WriteLine("finished");
        }

        static void SiteCrawler(string url)
        {
            string myLines = "";
            Console.WriteLine("console line is this");
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
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
            string path = Directory.GetCurrentDirectory();
            string mypath = @".. \" + path;
            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\rober\\Documents\\Visual Studio 2015\\Projects\\ConsoleApplication1\\myfile.txt");
            file.WriteLine(writethis);
            file.Close();
        }
    }
}
