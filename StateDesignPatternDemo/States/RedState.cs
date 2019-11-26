using System;
using System.Collections.Generic;
using System.Text;
using StateDesignPatternDemo.Interfaces;

namespace StateDesignPatternDemo.States
{
    public class RedState : StateBase
    {
        public RedState(IState state) : this(state.Balance)
        {
            base.AccountContext = state.AccountContext;
        }
        public RedState(double balance):base(balance)
        {

        }
        protected override void Handle(IAccountContext accountContext)
        {
            if (accountContext.AccountBalance > 0)
            {
                accountContext.State = new SilverState(this);
            }
        }
    }
}
