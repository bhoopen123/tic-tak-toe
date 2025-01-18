// See https://aka.ms/new-console-template for more information

using System.Reflection;
using TicTacToeConsole.Controllers;
using TicTacToeConsole.Models;

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

GameController gameController = new GameController();
var game = gameController.CreateGame(boardSize, Players);
if (game == null)
{
    Console.WriteLine("Failed to create the Game, please try again..");
    return;
}

// starting the Game
game.Start();

while (game.GameStatus.Equals(GameStatus.InProgress))
{
    Console.WriteLine("Current board looks like: ");
    game.Display();

    Console.WriteLine("Do you want to do an undo? y/n");
    char isUndo = Console.ReadKey().KeyChar;

    if (isUndo.Equals('y'))
    {
        gameController.Undo(game);
    }
    else
    {
        gameController.NextMove(game);
    }


    // draw or ended
    if (game.GameStatus.Equals(GameStatus.EndInWin))
    {
        Console.WriteLine("Game has Ended: ");
        Console.WriteLine("The winner is: " + game.Winner?.Name);
        game.Display();

        break;
    }

    else if (game.GameStatus.Equals(GameStatus.EndInTie))
    {
        Console.WriteLine("The Game has Ended in Tie.");
        game.Display();

        break;
    }
}