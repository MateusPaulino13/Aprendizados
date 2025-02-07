using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //upcasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1004, "Mateus", 0.0, 250.0);
            Account acc3 = new SavingAccount(1005, "Ana", 0.0, 0.01);

            //downcasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            //acc2.Loan(200.0); da erro pq o compilador n sabe q ela era um business account

            // BusinessAccount acc5 = (BusinessAccount)acc3; | vai dar erro em tempo de execucao pq acc3 é uma saving account

            //verificando se a variavel é uma instancia de uma classe
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan! Loan!");
            }

            if (acc3 is SavingAccount)
            {
                SavingAccount acc5 = (SavingAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update Balance");
            }
        }
    }
}