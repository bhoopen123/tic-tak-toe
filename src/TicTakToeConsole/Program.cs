// See https://aka.ms/new-console-template for more information

using TicTacTooGame.Models;

Console.WriteLine("Hello, in Tic Tac Toe game world!");

// take the input from the user
Console.WriteLine("Enter Board Size (3 >= && <= 10) :: ");
var boardSize = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Are there a Bot in this Game? y/n ");
Char isBot = Console.ReadKey().KeyChar;

List<Player> Players = new List<Player>();
int toIterate = boardSize - 1;

if (isBot.Equals('y'))
{
    toIterate--;

    Player botPlayer = new Bot("Bot", 'b', BotDifficultyLevel.Easy);
    Players.Add(botPlayer);
}

for (int i = 0; i < toIterate; i++)
{
    Console.WriteLine("Enter the name of the Player: ");
    var name = Console.ReadLine();

    Console.WriteLine("Enter the Player Symbol :");
    var symbol = Console.ReadKey().KeyChar;

    //TODO: Add validation for already taken symbol

    Players.Add(new Player(name, symbol, PlayerType.Human));
}
