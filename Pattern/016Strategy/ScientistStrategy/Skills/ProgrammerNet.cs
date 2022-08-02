using ScientistStrategy.Interfaces;
using static System.Console;

namespace ScientistStrategy.Skills
{
    class ProgrammerNet : IProgrammerBehavior
    {
        public void Programming() { WriteLine("Пишу на C#"); }
    }

}
