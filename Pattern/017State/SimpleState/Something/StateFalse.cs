using System;
using static System.Console;

namespace SimpleState.Something
{
    class StateFalse : IState
    {
        public void SetStateFalse(Variable v) { }
        public void SetStateTrue(Variable v) => v.SetState(new StateTrue());
        public override string ToString() => "False";
    }
}
