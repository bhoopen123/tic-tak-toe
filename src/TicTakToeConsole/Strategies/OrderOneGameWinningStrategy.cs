using TicTacToeConsole.Models;

namespace TicTacToeConsole.Strategies
{
    public class OrderOneGameWinningStrategy : IGameWinningStrategy
    {
        private int boardSize;

        private List<Dictionary<char, int>> rowSymbolCounts = [];
        private List<Dictionary<char, int>> colSymbolCounts = [];
        private Dictionary<char, int> topLeftDiagonalSymbolCounts = [];
        private Dictionary<char, int> topRightDiagonalSymbolCounts = [];

        public OrderOneGameWinningStrategy(int boardSize)
        {
            this.boardSize = boardSize;
            for (int i = 0; i < boardSize; i++)
            {
                rowSymbolCounts.Add(new Dictionary<char, int>());
                colSymbolCounts.Add(new Dictionary<char, int>());
            }
        }

        public bool CheckWinner(Board board, Player lastMovedPlayer, Cell moveCell)
        {
            char symbol = lastMovedPlayer.Symbol;
            int rowIndex = moveCell.Row;
            int colIndex = moveCell.Col;
            int boardSize = board.BoardSize;

            if (!rowSymbolCounts[rowIndex].ContainsKey(symbol))
            {
                rowSymbolCounts[rowIndex].Add(symbol, 1);
            }
            else
            {
                rowSymbolCounts[rowIndex][symbol] += 1;
            }

            if (!colSymbolCounts[colIndex].ContainsKey(symbol))
            {
                colSymbolCounts[colIndex].Add(symbol, 1);
            }
            else
            {
                colSymbolCounts[colIndex][symbol] += 1;
            }

            // update diagonal data
            // check if cell is partof topLeft diagnonal
            if (IsTopLeftDiagonal(rowIndex, colIndex))
            {
                if (!topLeftDiagonalSymbolCounts.ContainsKey(symbol))
                {
                    topLeftDiagonalSymbolCounts.Add(symbol, 1);
                }
                else
                {
                    topLeftDiagonalSymbolCounts[symbol] += 1;
                }
            }

            // check if cell is partof topRight diagnonal
            if (IsTopRightDiagonal(rowIndex, colIndex))
            {
                if (!topRightDiagonalSymbolCounts.ContainsKey(symbol))
                {
                    topRightDiagonalSymbolCounts.Add(symbol, 1);
                }
                else
                {
                    topRightDiagonalSymbolCounts[symbol] += 1;
                }
            }

            // check winning
            if (rowSymbolCounts[rowIndex][symbol] == boardSize) return true;
            if (colSymbolCounts[colIndex][symbol] == boardSize) return true;
            if (IsTopLeftDiagonal(rowIndex, colIndex) && topLeftDiagonalSymbolCounts[symbol] == boardSize) return true;
            if (IsTopRightDiagonal(rowIndex, colIndex) && topRightDiagonalSymbolCounts[symbol] == boardSize) return true;


            return false;
        }

        private bool IsTopLeftDiagonal(int rowIndex, int colIndex)
        {
            return rowIndex == colIndex;
        }

        private bool IsTopRightDiagonal(int rowIndex, int colIndex)
        {
            return rowIndex + colIndex == boardSize - 1;
        }
    }
}
