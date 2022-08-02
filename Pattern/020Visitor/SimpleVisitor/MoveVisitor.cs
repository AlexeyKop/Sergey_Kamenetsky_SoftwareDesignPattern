using static System.Console;
namespace SimpleVisitor
{
    class MoveVisitor : IVisitor
    {
        public void Make(Cat cat) => WriteLine("Крадётся");
        public void Make(Dog dog) => WriteLine("Побежала");
        public void Make(Bird bird) => WriteLine("Полетела");
    }
}
