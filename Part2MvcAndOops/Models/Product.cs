using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part2MvcAndOops.Models
{
    public class Product
    {
        public string ProductName { get; }
        public decimal Price { get; }
        public string Description { get; }

        public Product(string productName, decimal price, string description)
        {
            ProductName = productName;
            Price = price;
            Description = description;
        }
    }
}
