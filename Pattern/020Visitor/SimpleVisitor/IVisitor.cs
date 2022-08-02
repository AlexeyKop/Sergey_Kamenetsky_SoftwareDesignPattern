namespace SimpleVisitor
{
    interface IVisitor
    {
        void Make(Cat cat);
        void Make(Dog dog);
        void Make(Bird bird);
    }
}
