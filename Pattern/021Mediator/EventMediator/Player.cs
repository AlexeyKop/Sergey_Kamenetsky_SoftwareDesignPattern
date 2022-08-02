namespace EventMediator
{
    class Player
    {
        public int Score { get; set; }
        public string Name { get; set; }
        private Game game { get; set; }
        public Player(string name, Game game)
        {
            Name = name;
            this.game = game;
        }
        public void Event() => game.Alert(new PlayerGameEventArgs(this.Name, ++Score));
    }
}
