namespace TicTacTooGame.Models
{
    public class Move
    {
        public Player Player { get; private set; }
        public Cell Cell { get; private set; }

        public Move(Player player, Cell cell)
        {
            Player = player;
            Cell = cell;
        }
    }
}