namespace TicTacTooGame.Models
{
    public class Bot : Player
    {
        public BotDifficultyLevel BotDifficultyLevel { get; private set; }
        public BotPlayingStrategy BotPlayingStrategy { get; private set; }

        public Bot(string name, char symbol, BotDifficultyLevel botDifficultyLevel) : base(name, symbol, PlayerType.Bot)
        {

        }

        public override Move DecideMove(Board board)
        {
            return null;
        }
    }
}
