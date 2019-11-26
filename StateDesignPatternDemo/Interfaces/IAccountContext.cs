using StateDesignPatternDemo.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPatternDemo.Interfaces
{
    public interface IAccountContext
    {
        Guid AccountId { get; set; }
        double AccountBalance { get; }
        IState State { get; set; }
        void Deposit(double ammount);
        void Withdraw(double ammount);
    }
}
