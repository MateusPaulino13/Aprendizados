using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductUsedImported.Entites
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double totalPrice()
        {
            return Price + CustomsFee;
        }

        public override string priceTag()
        {
            return Name + " $ " + totalPrice().ToString("F2") + " (Customs fee: $ " + CustomsFee.ToString("F2") + ")";
        }
    }
}