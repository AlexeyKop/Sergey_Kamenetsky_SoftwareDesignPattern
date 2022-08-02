using static System.Console;

namespace IntroVisitor
{
    class Dog : IAnimal
    {
        public void Move() => WriteLine("Бежит");
        //public void Eat() => WriteLine("Собачка кушает");
    }
}
