using BankStuffLibrary;
using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // class library
            // https://www.youtube.com/watch?v=Jms3C-J-m2M&list=PLdo4fOcmZ0oWoazjhXQzBKMrFuArxpW80&index=5

            var account = new BankAccount("HuanZ", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");


            Console.WriteLine(account.GetAccountHistory());


            // Ctrl K + C, comment out, Ctrl K + U uncomment
            // Test that the initial balances must be positive.
            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            //// Test for a negative balance.
            //try
            //{
            //    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}
        }
    }
}
