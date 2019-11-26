using System;
using System.Collections.Generic;
using System.Text;
using StateDesignPatternDemo.Interfaces;

namespace StateDesignPatternDemo.States
{
    /// <summary>
    /// 
    /// </summary>
    public class SilverState : StateBase
    {
        public SilverState(IState state) : this(state.Balance)
        {
            base.AccountContext = state.AccountContext;

        }
        public SilverState(double balance) : base(balance)
        {
        }

        protected override void Handle(IAccountContext accountContext)
        {
            if (accountContext.AccountBalance < 0)
            {
                accountContext.State = new RedState(this);
            }
            else if (accountContext.AccountBalance > 100000)
            {
                accountContext.State = new GoldState(this);
            }
        }
    }
}
