using StateDesignPatternDemo.Interfaces;
using StateDesignPatternDemo.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPatternDemo.Impl
{
    public class AccountContext : IAccountContext
    {
        public AccountContext(Guid accountId, IState state)
        {
            this.AccountId = accountId;
            this.State = state;
            this.State.AccountContext = this;
        }

        public IState State { get; set; }
        public Guid AccountId { get; set; }

        public double AccountBalance => State.Balance;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ammount"></param>
        public void Deposit(double ammount)
        {
            State.Deposit(ammount);
            Console.WriteLine("Account Current Balance :" + AccountBalance);
            Console.WriteLine("Account Current State   :" + State.StateInfo);
            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ammount"></param>
        public void Withdraw(double ammount)
        {
            State.Withdraw(ammount);
            Console.WriteLine("Account Current Balance :" + AccountBalance);
            Console.WriteLine("Account Current State   :" + State.StateInfo);
            Console.WriteLine();
        }
    }
}
