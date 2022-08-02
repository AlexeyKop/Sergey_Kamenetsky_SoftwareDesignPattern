using static System.Console;

namespace EventMediator
{
    class Trainer
    {
        public Game game { get; set; }
        public Trainer(Game game)
        {
            this.game = game;
            game.AbstractEvent += GameEvent;
        }
        private void GameEvent(object sender, GameEventArgs e)
        {
            if(e is PlayerGameEventArgs playerArgs)
            {
                if (playerArgs.PlayerScore <= 5) 
                    WriteLine($"Ура! {playerArgs.PlayerName} молодцом!");
            }
        }
    }
}
