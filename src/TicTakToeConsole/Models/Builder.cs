
using TicTacToeConsole.Exceptions;
using TicTacToeConsole.Strategies;

namespace TicTacToeConsole.Models
{
    public class Builder
    {
        private int BoardSize;
        private List<Player> Players;

        public Builder CreateBoard(int boardSize)
        {
            BoardSize = boardSize;
            return this;
        }

        public Builder CreatePlayers(List<Player> players)
        {
            Players = players;
            return this;
        }

        public Game BuildGame()
        {
            // Validations
            ValidateGameParameters();

            Board board = new Board(BoardSize);
            IGameWinningStrategy gameWinningStrategy = new OrderOneGameWinningStrategy(BoardSize);

            Game game = new Game(board, Players, gameWinningStrategy);

            return game;
        }

        private void ValidateGameParameters()
        {
            if (BoardSize < 3)
                throw new InvalidGameConstructorParameterException("Board Size can't be less than 3");

            if (Players.Count() != BoardSize - 1)
                throw new InvalidGameConstructorParameterException("Incorrect player count");

            // validate players having same symbols

            // validate there is only one bot in the game
        }
    }
}
