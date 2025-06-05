using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gererics.Entities
{
    class Product : IComparable
    {
            
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name}, {Price:C}";
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Product other))
            {
                throw new ArgumentException("Object is not a Product");
            }
            Product otherProduct = (Product)obj;
            return Price.CompareTo(otherProduct.Price);
        }
    }
}
