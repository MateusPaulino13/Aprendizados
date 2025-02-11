using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUsedImported.Entites
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2") + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
