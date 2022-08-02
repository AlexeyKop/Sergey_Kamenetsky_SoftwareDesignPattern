using static System.Console;

namespace IntroVisitor
{
    class Bird : IAnimal
    {
        public void Move() => WriteLine("Летит ");
        //public void Eat() => WriteLine("Птичка кушает");
    }
}
