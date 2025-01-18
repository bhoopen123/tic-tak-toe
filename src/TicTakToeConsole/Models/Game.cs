using TicTacToeConsole.Strategies;

namespace TicTacToeConsole.Models
{
    public class Game
    {
        public Board Board { get; private set; }
        public List<Player> Players { get; private set; }
        public List<Move> Moves { get; private set; }
        public GameStatus GameStatus { get; private set; }

        private int NextPlayerIndex;

        public IGameWinningStrategy GameWinningStrategy { get; private set; }
        public Player? Winner { get; private set; }

        public Game(Board board, List<Player> players, IGameWinningStrategy gameWinningStrategy)
        {
            Board = board;
            Players = players;
            GameWinningStrategy = gameWinningStrategy;
            GameStatus = GameStatus.NotStarted;
            Moves = new List<Move>();
            NextPlayerIndex = 0;
        }

        public void Start()
        {
            GameStatus = GameStatus.InProgress;
        }


        // TODO: 
        public void Undo()
        {

        }

        public void MakeNextMove()
        {
            Player toMovePlayer = Players[NextPlayerIndex];
            Console.WriteLine($"This is {toMovePlayer.Name}'s turn.");
            Move move = toMovePlayer.DecideMove(Board);

            int rowIndex = move.Cell.Row;
            int colIndex = move.Cell.Col;

            Board.Canvas[rowIndex][colIndex].SetPlayer(toMovePlayer);
            Console.WriteLine($"Move happened at [{rowIndex}, {colIndex}].");

            Moves.Add(move);

            // Check if the game is Over
            if (GameWinningStrategy.CheckWinner(Board, toMovePlayer, move.Cell))
            {
                GameStatus = GameStatus.EndInWin;
                Winner = toMovePlayer;
            }

            NextPlayerIndex++;
            NextPlayerIndex %= Players.Count;
        }

        public void Display()
        {
            Board.Display();
        }

        public static Builder GetBuilder()
        {
            return new Builder();
        }
    }
}
