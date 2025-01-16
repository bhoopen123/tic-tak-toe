using TicTacToeConsole.Models;
using TicTacToeConsole.Strategies;

namespace TicTacToeConsole.Factories
{
    public class BotPlayingStrategyFactory
    {
        public static IBotPlayingStrategy GetBotPlayingStrategy(BotDifficultyLevel botDifficultyLevel)
        {
            return new RandomBotPlayingStrategy();
        }
    }
}
