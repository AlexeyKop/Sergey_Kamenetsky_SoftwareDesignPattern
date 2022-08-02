using static System.Console;

namespace OutroVisitor
{
    class Dog : IAnimal
    {
        public void Move() => WriteLine("Бежит");
        public void Eat() => WriteLine("Собачка кушает");
    }
}
