using System;
using System.Collections.Generic;
using System.Text;
using StateDesignPatternDemo.Interfaces;

namespace StateDesignPatternDemo.States
{
    public abstract class StateBase : IState
    {
        protected StateBase(double balance)
        {
            Balance = balance;
        }
        public double Balance { get; set; }
        public IAccountContext AccountContext { get; set; }

        public virtual string StateInfo
        {
            get
            {
                return this.GetType().Name;
            }
        }
        protected abstract void Handle(IAccountContext accountContext);

        public void Deposit(double amount)
        {
            Balance += amount;
            Handle(this.AccountContext);
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
            Handle(this.AccountContext);
        }
    }
}
