using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Demo
{
    public class Crawler
    {

        public static void SiteCrawler(string ticker)
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
            StoreData.StoreToDatabase(myLines);
        }
    }
}
