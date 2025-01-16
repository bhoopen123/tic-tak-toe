namespace TicTacToeConsole.Models
{
    public class Board
    {
        public List<List<Cell>> Canvas { get; private set; }
        public int BoardSize { get; private set; }

        public Board(int dimension)
        {
            BoardSize = dimension;
            Canvas = new List<List<Cell>>();

            for (int i = 0; i < dimension; i++)
            {
                Canvas.Add(new List<Cell>());

                for (int j = 0; j < dimension; j++)
                {
                    Canvas[i].Add(new Cell(i, j));
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < Canvas.Count; i++)
            {
                for (int j = 0; j < Canvas[i].Count; j++)
                {
                    if (Canvas[i][j].CellState.Equals(CellState.Empty))
                    {
                        Console.Write("|   |");
                    }
                    else
                    {
                        Console.Write("| " + Canvas[i][j].Player.Symbol + " |");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}