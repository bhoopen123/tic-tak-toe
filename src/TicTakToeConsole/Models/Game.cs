using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacTooGame.Models
{
    public class Game
    {
        public Board Board { get; private set; }
        public List<Player> Players { get; private set; }
        public List<Move> Moves { get; private set; }
        public GameStatus GameStatus { get; private set; }

        private int NextPlayerIndex;

        public GameWinningStrategy GameWinningStrategy { get; private set; }
        public Player? Winner { get; private set; }

        public Game(Board board, List<Player> players, GameWinningStrategy gameWinningStrategy)
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

        public void Undo()
        {

        }

        public void MakeNextMove()
        {

        }

        public static Builder GetBuilder()
        {
            return new Builder();
        }
    }
}
