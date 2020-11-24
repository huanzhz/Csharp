using System;
using Xunit;
using BankStuffLibrary;

namespace BankingTests
{
    public class BasicTest
    {
        [Fact]
        public void TrueIsTrue()
        {
            Assert.True(true);
            // unit test
            // https://www.youtube.com/watch?v=QBiBZ8bsfcU&list=PLdo4fOcmZ0oWoazjhXQzBKMrFuArxpW80&index=7
        }
        [Fact]
        public void CantTakeMoreThanYouHave()
        {
            // Right click on Test2 to run test in visual studio 2019
            // Import BankAccount library in dependencies
            var account = new BankAccount("HuanZ", 10000);

            // Ctrl K + C, comment out, Ctrl K + U uncomment
            // Test for a negative balance.
            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw")
            );
        }

        [Fact]
        public void NeedMoneyToStart()
        {
            // Test that the initial balances must be positive.
            Assert.Throws<ArgumentOutOfRangeException>(
                ()=> new BankAccount("invalid", -55)
            );
        }
    }
}
