using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixacao
{
    internal class Conversor
    {
        public static double Cotacao = 5.21;

        public static double TotalaSerPago(double dolares)
        {
            return (dolares * Cotacao) + ((dolares * Cotacao) * 0.06);
        }
    }
}
