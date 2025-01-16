namespace TicTacToeConsole.Models
{
    public class Cell
    {
        public int Row { get; private set; }
        public int Col { get; private set; }
        public Player Player { get; private set; }
        public CellState CellState { get; set; }
        public Cell(int row, int col)
        {
            Row = row;
            Col = col;
            CellState = CellState.Empty;
        }

        public void SetPlayer(Player player)
        {
            Player = player;
            CellState = CellState.Full;
        }

    }
}