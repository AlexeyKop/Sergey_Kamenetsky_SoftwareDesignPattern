using System;
using static System.Console;

namespace SimpleState.Something
{
    class StateTrue : IState
    {
        public void SetStateFalse(Variable v) => v.SetState(new StateFalse());
        public void SetStateTrue(Variable v) { }
        public override string ToString() => "True";
    }
}
