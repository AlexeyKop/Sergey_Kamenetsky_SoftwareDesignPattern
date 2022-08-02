using static System.Console;

namespace OutroVisitor
{
    class Cat : IAnimal
    {
        public void Move() => WriteLine("Крадётся бесшумно");
        public void Eat()=> WriteLine("Котик кушает");
    }
}
