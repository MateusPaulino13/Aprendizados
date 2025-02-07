using System;
using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            Console.WriteLine(account.Balance);
        }
    }
}