namespace SimpleVisitor
{
    abstract class Animal
    {
        public abstract void Accept(IVisitor visitor);
    }
}
