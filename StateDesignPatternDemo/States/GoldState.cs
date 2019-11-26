using System;
using System.Collections.Generic;
using System.Text;
using StateDesignPatternDemo.Interfaces;

namespace StateDesignPatternDemo.States
{
    public class GoldState : StateBase
    {
        public GoldState(IState state) : this(state.Balance)
        {
            base.AccountContext = state.AccountContext;
        }
        public GoldState(double balance):base(balance)
        {

        }
        protected override void Handle(IAccountContext accountContext)
        {
            if (accountContext.AccountBalance < 100000&& accountContext.AccountBalance>0)
            {
                accountContext.State = new SilverState(this);
            }
            else if (accountContext.AccountBalance <0)
            {
                accountContext.State = new RedState(this);
            }
        }
    }
}
