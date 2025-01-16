using TicTacToeConsole.Models;

namespace TicTacToeConsole.Strategies
{
    public class OrderOneGameWinningStrategy : IGameWinningStrategy
    {
        private int boardSize;

        public OrderOneGameWinningStrategy(int boardSize)
        {
            this.boardSize = boardSize;
        }

        public bool CheckWinner(Board board, Player lastMovePlayer, Cell moveCell)
        {
            return false;
        }
    }
}
