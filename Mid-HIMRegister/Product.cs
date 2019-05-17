using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_HIMRegister
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        public Product(string name, string cat, string desc, float price)
        {
            Name = name;
            Category = cat;
            Description = desc;
            Price = price;
        }
    }
}
