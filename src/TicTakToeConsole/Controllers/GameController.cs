using TicTacToeConsole.Models;

namespace TicTacToeConsole.Controllers
{
    public class GameController
    {
        public void Undo(Game game)
        {
            game?.Undo();
        }

        public Game? CreateGame(int boardSize, List<Player> players)
        {
            try
            {
                return Game.GetBuilder()
                            .CreateBoard(boardSize)
                            .CreatePlayers(players)
                            .BuildGame();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public void DisplayBoard(Game game)
        {
            game?.Display();
        }

        public GameStatus GameStatus(Game game)
        {
            return game.GameStatus;
        }

        public void NextMove(Game game)
        {
            game.MakeNextMove();
        }

        public Player? Winner(Game game)
        {
            return game.Winner;
        }
    }
}