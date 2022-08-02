namespace ClassicChainOfResponsibility
{


    class Program
    {
        static void Main()
        {
            var enemy = new Roshan(30);

            var ursa = new Ursa();
            var timber = new Timbersaw();
            var axe = new Axe();

            ursa.Next = timber;
            timber.Next = axe;

            ursa.MustWin(enemy);

        }
    }
}
