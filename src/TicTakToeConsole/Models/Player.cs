namespace TicTacToeConsole.Models
{
    public class Player
    {
        public char Symbol { get; private set; }
        public PlayerType PlayerType { get; private set; }
        public string Name { get; private set; }

        public Player(string name, char symbol, PlayerType playerType)
        {
            Name = name;
            Symbol = symbol;
            PlayerType = playerType;
        }

        public virtual Move DecideMove(Board board)
        {
            Console.WriteLine("Please provide cell location RowIndex, ColIndex.");
            var input = Console.ReadLine();
            int[] cellLocation = input!.Split(',').Select(c => Convert.ToInt32(c)).ToArray();

            // TODO: Vaidate if the provided cell is empty
            var cell = new Cell(cellLocation[0], cellLocation[1]);
            cell.CellState = CellState.Full;
            return new Move(this, cell);
        }
    }
}
