using Delegate.Services;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 3;

            double result = CalculationService.Sum(a, b);
            Console.WriteLine(result);
        }
    }
}
