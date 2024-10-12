using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Water : IProduct
    {
        private decimal price;
        private int stock;

        public Water(decimal price, int stock)
        {
            this.price = price;
            this.stock = stock;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public int GetStock()
        {
            return stock;
        }
    }
}
