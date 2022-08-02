using static System.Console;
namespace SimpleVisitor
{
    class VoiceVisitor : IVisitor
    {
        public virtual void Make(Cat cat) => WriteLine("Мяу");
        public virtual void Make(Dog dog) => WriteLine("Гав");
        public virtual void Make(Bird bird) => WriteLine("Чирик-Чирик");
    }
}
