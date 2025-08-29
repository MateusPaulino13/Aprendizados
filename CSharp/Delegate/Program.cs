using Delegate.Services;

namespace Delegate
{
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 3;

            //passando a referencia do metodo do service
            // só pode usar as funções/métodos que casam com a assinatura, não posso (neste caso) colocar uma função que recebe apenas um paramentro ou que tenha outro tipo de retorno
            // como no caso da função Square do CalculationService
            BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation opVerboso = new BinaryNumericOperation(CalculationService.Sum); // muito verboso;

            double resultInvoke = op.Invoke(a, b); //Ele esta chamando/"Invocando" a função/método que você definiu (no nosso caso é Sum())
            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}
