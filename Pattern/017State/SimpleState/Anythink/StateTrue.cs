using static System.Console;

namespace SimpleState.Anythink
{
    class StateTrue : IState
    {
        public void SetStateTrue(Variable v) => WriteLine("Уже истина");
        public void SetStateFalse(Variable v)
        {
            WriteLine("Значение установлено в ложь");
            v.SetState(new StateFalse());
        }
    }
}
