using System;
using static System.Console;

namespace SimpleState.Something
{
    interface IState
    {
        void SetStateTrue(Variable v);
        void SetStateFalse(Variable v);
    }
}
