using StateDesignPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPatternDemo.States
{
    public interface IState
    {

        IAccountContext AccountContext { get; set; }
        double Balance { get; set; }
        void Deposit(double amount);
        void Withdraw(double amount);
        string StateInfo { get; }
    }
}
