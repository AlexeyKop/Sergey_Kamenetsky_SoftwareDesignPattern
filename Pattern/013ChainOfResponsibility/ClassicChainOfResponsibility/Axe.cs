namespace ClassicChainOfResponsibility
{
    class Axe : Hero
    {
        public Axe(int hp = 110, Hero next = null) : base(hp, next) { }
    }
}
