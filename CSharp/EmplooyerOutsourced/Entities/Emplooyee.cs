using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplooyerOutsourced.Entities
{
    class Emplooyee
    {
        public string Name { get; private set; }
        public int Hours { get; private set; }
        public double valuePerHour { get; private set; }

        public Emplooyee()
        {
        }

        public Emplooyee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            this.valuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return valuePerHour * Hours;
        }
    }
}