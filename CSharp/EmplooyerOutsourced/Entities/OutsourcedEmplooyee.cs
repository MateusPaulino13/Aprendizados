using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplooyerOutsourced.Entities
{
    class OutsourcedEmplooyee : Emplooyee
    {
        public double AdditionalCharge { get; private set; }

        public OutsourcedEmplooyee()
        {
        }

        public OutsourcedEmplooyee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (1.1 * AdditionalCharge);
        }
    }
}