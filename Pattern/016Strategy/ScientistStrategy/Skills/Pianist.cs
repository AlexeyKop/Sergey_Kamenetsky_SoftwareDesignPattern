using ScientistStrategy.Interfaces;
using static System.Console;

namespace ScientistStrategy.Skills
{
    class Pianist : IMusician
    {
        public void Play() { WriteLine("Играю на пианино"); }
    }

}
