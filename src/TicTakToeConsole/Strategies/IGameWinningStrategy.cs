using TicTacToeConsole.Models;

namespace TicTacToeConsole.Strategies
{
    public interface IGameWinningStrategy
    {
        bool CheckWinner(Board board, Player lastMovePlayer, Cell moveCell);
    }
}