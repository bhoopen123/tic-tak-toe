namespace TicTacTooGame.Models
{
    public class Cell
    {
        public int Row { get; private set; }
        public int Col { get; private set; }
        public Player Player { get; private set; }
        public CellState CellState { get; set; }
        public Cell(Player player, int row, int col)
        {
            Player = player;
            Row = row;
            Col = col;
        }

    }
}