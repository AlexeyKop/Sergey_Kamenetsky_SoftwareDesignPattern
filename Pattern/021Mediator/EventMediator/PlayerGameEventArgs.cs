using static System.Console;

namespace EventMediator
{
    class PlayerGameEventArgs : GameEventArgs
    {
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }
        public PlayerGameEventArgs(string player, int score)
        {
            PlayerName = player;
            PlayerScore = score;
        }
        public override void Info() => WriteLine($"У {PlayerName} счёт: {PlayerScore}");
    }
}
