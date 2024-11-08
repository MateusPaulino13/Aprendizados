using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProdutoEstoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int qnt)
        {
            Quantidade += qnt;
        }

        public void RemoverProdutos(int qnt)
        {
            Quantidade -= qnt;
        }

        public override string ToString()
        {
            return Nome 
                    + ", R$" 
                    + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                    + ", " 
                    + Quantidade 
                    + " unidade, Total: R$" 
                    + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
