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
            Console.WriteLine("console line is this");
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.yellowpages.com/providence-ri/sofware?autocorrect=off");
            var HeaderNames = doc.DocumentNode
                .SelectNodes("//a[@class='business-name']").ToList();
            foreach(var item in HeaderNames)
            {
                Console.WriteLine(item.InnerHtml);
            }
            
        }
    }
}
