using System;
using Aula126UpcastingDowncasting.Entities;

namespace Aula126UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "mateus", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "gabriel", 0, 500);

            //UPPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "bob", 0, 200);
            Account acc3 = new SavingsAccount(1004, "ana", 0, 0.01);

            //DOWNCASTING
            //BusinessAccount acc4 = acc2 as BusinessAccount;
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            //===========================AULA 127 SOBREPOSIÇÃO,OVERRIE E BASE===========================
            Account account1 = new Account(1001,"Alex",500);
            Account account2 = new SavingsAccount(1002,"Ana",500,0.01);

            account1.Withdraw(10.0);
            account2.Withdraw(10.0);

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);
        }
    }
}
