using static System.Console;

namespace SimpleState.Anythink
{
    class StateFalse : IState
    {
        public void SetStateFalse(Variable v) => WriteLine("Уже ложь");
        public void SetStateTrue(Variable v)
        {
            WriteLine("Значение установлено в истину");
            v.SetState(new StateTrue());
        }
    }
}
