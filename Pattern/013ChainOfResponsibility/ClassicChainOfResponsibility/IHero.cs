namespace ClassicChainOfResponsibility
{
    interface IHero
    {
        int Hp { get; set; }
        Hero Next { get; set; }
        void MustWin(Roshan enemy);
    }
}
