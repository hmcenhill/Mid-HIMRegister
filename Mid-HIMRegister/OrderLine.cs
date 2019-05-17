using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_HIMRegister
{
    public class OrderLine
    {
        public Product Item { get; set; }
        public int Qty { get; set; }

        public OrderLine(Product item, int qty)
        {
            Item = item;
            Qty = qty;
        }
    }
}
