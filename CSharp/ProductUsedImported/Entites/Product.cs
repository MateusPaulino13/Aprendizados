﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUsedImported.Entites
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product()
        { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
            return Name + " $ " + Price.ToString("F2");
        }
    }
}