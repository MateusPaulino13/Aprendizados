using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Entities
{
    class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Tier { get; set; }

        public Category(Guid id, string name, int tier)
        {
            Id = id;
            Name = name;
            Tier = tier;
        }
    }
}
