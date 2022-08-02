namespace SimpleVisitor
{
    class Bird : Animal
    {
        public override void Accept(IVisitor visitor) => visitor.Make(this);
    }
}
