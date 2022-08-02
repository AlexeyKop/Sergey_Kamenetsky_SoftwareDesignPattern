namespace SimpleVisitor
{
    class Dog : Animal
    {
        public override void Accept(IVisitor visitor) => visitor.Make(this);
    }
}
