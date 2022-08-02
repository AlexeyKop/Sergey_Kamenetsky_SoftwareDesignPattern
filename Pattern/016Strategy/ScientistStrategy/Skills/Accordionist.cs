using ScientistStrategy.Interfaces;
using static System.Console;

namespace ScientistStrategy.Skills
{
    class Accordionist : IMusician
    {
        public void Play() { WriteLine("Играю на аккордеоне"); }
    }

}
