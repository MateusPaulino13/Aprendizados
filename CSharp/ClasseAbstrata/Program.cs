using Heranca.Entities;
using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace ClasseAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> contas = new List<Account>();

            contas.Add(new SavingAccount(1001, "Alex", 500.0, 0.01));
            contas.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            contas.Add(new SavingAccount(1003, "Bob", 500.0, 0.01));
            contas.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach (Account acc in contas)
            {
                sum += acc.Balance;
            }

            Console.WriteLine($"Total Balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach (Account acc in contas)
            {
                acc.WithDraw(10.0);
            }

            foreach (Account acc in contas)
            {
                Console.WriteLine($"Update balance for account {acc.Number} : {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}