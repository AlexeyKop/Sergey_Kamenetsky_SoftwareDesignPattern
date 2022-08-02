using ScientistStrategy.Interfaces;
using static System.Console;

namespace ScientistStrategy.Skills
{
    class ProgrammerJS : IProgrammerBehavior
    {
        public void Programming() { WriteLine("Пишу на JS"); }
    }

}
