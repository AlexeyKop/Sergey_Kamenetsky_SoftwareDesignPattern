using static System.Console;

namespace IntroVisitor
{
    class Cat : IAnimal
    {
        public void Move() => WriteLine("Крадётся бесшумно");
        //public void Eat() => WriteLine("Котик кушает");
    }
}
