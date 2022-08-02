namespace SimpleVisitor
{
    class Cat : Animal
    {
        public override void Accept(IVisitor visitor) => visitor.Make(this);
    }
}
