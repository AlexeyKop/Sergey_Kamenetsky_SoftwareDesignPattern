namespace SimpleVisitor
{
    class Kiwi : Bird
    {
        public override void Accept(IVisitor visitor) => visitor.Make(this);
    }
}
