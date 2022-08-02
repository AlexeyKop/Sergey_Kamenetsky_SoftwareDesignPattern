using static System.Console;

namespace OutroVisitor
{
    class Bird : IAnimal
    {
        public void Move() => WriteLine("Летит ");
        public void Eat() => WriteLine("Птичка кушает");
    }
}
