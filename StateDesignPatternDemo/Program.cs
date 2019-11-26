using StateDesignPatternDemo.Impl;
using StateDesignPatternDemo.Interfaces;
using StateDesignPatternDemo.States;
using System;

namespace StateDesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountContext = new AccountContext(Guid.NewGuid(), new SilverState(0.0));
            accountContext.Deposit(1000);
            accountContext.Deposit(10000);
            accountContext.Deposit(90000);
            accountContext.Withdraw(90000);
            accountContext.Withdraw(90000);
            accountContext.Deposit(90000);
            accountContext.Deposit(90000);
        }
    }
}
