namespace EventMediator
{
    class Program
    {
        static void Main()
        {
            var game = new Game();
            var player = new Player("r2d2", game);
            var trainer = new Trainer(game);
            
            var count = 10;
            while (count-->0)
            {
                player.Event();
            }
        }
    }
}
