using TicTacToeConsole.Factories;
using TicTacToeConsole.Strategies;

namespace TicTacToeConsole.Models
{
    public class Bot : Player
    {
        public BotDifficultyLevel BotDifficultyLevel { get; private set; }
        public IBotPlayingStrategy BotPlayingStrategy { get; private set; }

        public Bot(string name, char symbol, BotDifficultyLevel botDifficultyLevel) : base(name, symbol, PlayerType.Bot)
        {
            BotPlayingStrategy = BotPlayingStrategyFactory.GetBotPlayingStrategy(botDifficultyLevel);
        }

        public override Move DecideMove(Board board)
        {
            return BotPlayingStrategy.DecideMove(this, board);
        }
    }
}
