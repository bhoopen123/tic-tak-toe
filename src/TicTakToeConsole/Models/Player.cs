namespace TicTacTooGame.Models
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
            return null;
        }
    }
}
