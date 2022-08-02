using ScientistStrategy.Interfaces;
using static System.Console;

namespace ScientistStrategy.Skills
{
    class NoMusician : IMusician
    {
        public void Play() { WriteLine("Не играю"); }
    }

}
