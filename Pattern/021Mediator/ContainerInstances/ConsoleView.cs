using static System.Console;

namespace ContainerInstances
{
    class ConsoleView : IView
    {
        public string X { get { Write("Число x: "); return ReadLine(); } }
        public string Y { get { Write("Число y: "); return ReadLine(); } }
        public string Result { set => WriteLine(value); }
    }
}
