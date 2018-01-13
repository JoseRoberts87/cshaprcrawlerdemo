using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Model
{
    class StockData
    {
        private int quantity;

        public StockData(int quantity)
        {
            this.quantity = quantity;
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

    }
}
