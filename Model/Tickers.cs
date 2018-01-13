using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Model
{
    class Tickers
    {
        private string tickerName;
        private int lastPrice;

        public Tickers(string tickerName, int lastPrice)
        {
            this.tickerName = tickerName;
            this.lastPrice = lastPrice;
        }


        public string TickerName
        {
            get { return tickerName; }
            set
            {
                if (tickerName == null) return;
                {
                    Console.WriteLine("no ticker provided");
                }
                if (tickerName != null) return;
                {
                    tickerName = value;
                    Console.WriteLine("ticker name set to", value);
                }
            }
        }
        public int LastPrice
        {
            get { return lastPrice; }
            set
            {
                if (lastPrice == null) return;
                {
                    Console.WriteLine("last price not found");
                }
                if (lastPrice == value) return;
                {
                    Console.WriteLine("last price set to {0}", value);
                }
            }
        }
    }
}
