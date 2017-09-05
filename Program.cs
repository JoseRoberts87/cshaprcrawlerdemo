using System;
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
    }
}
