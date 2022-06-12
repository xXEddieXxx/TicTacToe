namespace TicTacToe;

public class Game
{
    public string[] Pos = new string[10] { "0", "1", "2","3","4","5","6","7","8","9" };
    public List<int> Taken = new List<int>();


    public void turn(Player current)
    {
        while (CheckWin()==false)
        {
            Console.WriteLine($"Ok {current.Name} your turn:");
            var turn = Console.ReadLine();
            if (CheckMove(Convert.ToInt32(turn)) == false)
            {
                Console.WriteLine("Sorry wrong Move!");
            }
        }
    }
    
    public void GameStart()
    {
        Console.WriteLine("Welcome to TicTacToe please insert the Player names!");
        Console.WriteLine("Player1: ");
        var player1 =new Player(Console.ReadLine());
        Console.WriteLine("Player2: ");
        var player2 =new Player(Console.ReadLine());
        Console.WriteLine($"Ok {player1} and {player2} lets go!");
    }
    
    public void DrawBoard()
    {
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[1], Pos[2], Pos[3]);
        Console.WriteLine("-------------------");
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[4], Pos[5], Pos[6]);
        Console.WriteLine("-------------------");
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[7], Pos[8], Pos[9]);
    }

    public bool CheckMove(int move)
    {
        foreach (int i in Taken)
        {
            if (move == i)
            {
                return false;
            }
        }
        
        if (move > 9)
        {
            return false;
        }
        return true;
    }

    public bool CheckWin()
    {
        if (false)
        {
            return true;
        }
            return false;
    }
    
    

}