namespace TicTacToe;

public class Gamestart
{
    public void GameStart()
    {
        Console.WriteLine("Welcome to TicTacToe please insert the Player names!");
        Console.WriteLine("Player1: ");
        var player1 =new Player(Console.ReadLine(),"X");
        Console.WriteLine("Player2: ");
        var player2 =new Player(Console.ReadLine(),"O");
        Console.WriteLine($"Ok {player1.Name} and {player2.Name} lets go!");

        var playing = true;
        while (playing)
        {
            var game = new Game(player1, player2);
            Console.WriteLine("want to continue?(y/n) :");
            var input = Console.ReadLine();
            if (input == "n" || input == "N")
            {
                playing = false;
            }
        }
    } 
}