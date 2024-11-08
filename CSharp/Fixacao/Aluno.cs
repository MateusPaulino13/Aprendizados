using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixacao
{
    internal class Aluno
    {
        public string Name;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double NotaFinal;
        public double Falta = 60.0;

        public bool isAprovado()
        {
            if (NotaFinal >= 60)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public double Restante()
        {
            Falta -= NotaFinal;

            return Falta;
        }
    }
}
