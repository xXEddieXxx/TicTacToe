namespace TicTacToe;

public class Game
{
    private string[] Pos = new string[10] { "0", "1", "2","3","4","5","6","7","8","9" };
    private List<int> Taken = new List<int>();
    public Player Player1, Player2;
    int _counter=0;
    public Game(Player player1,Player player2)
    {
        Player1 = player1;
        Player2 = player2;
        Turn();
    }
    private void Turn()
    {
        while (CheckWin() == false)
        {
            if (_counter>7)
            {
                Draw();
                break;
            }
            if (CheckWin() == false)
            {
                Move(Player1);
                if (CheckWin() == false)
                {
                    DrawBoard();
                    Move(Player2);
                }
                else if (CheckWin())
                {
                    DrawBoard();
                    Winner(Player1);
                }
            } 
            if (CheckWin())
            {
                DrawBoard();                   
                Winner(Player2);
            }
        }
    }
    private void Move(Player current)
    {
        DrawBoard(); 
        Console.WriteLine($"Ok {current.Name} your turn:");
        try
        {
            var move = Convert.ToInt32(Console.ReadLine());
            if (CheckMove(move) == false)
            {
                Console.WriteLine("Sorry wrong Move!");
                Console.ReadLine();
                Move(current);
            }
            else
            {
                Taken.Add(Convert.ToInt32(move));
                Pos[move] = current.Symbol;
                _counter += 1;
            }
        }
        catch
        {
            Console.WriteLine("Sorry wrong Move!");
            Console.ReadLine();
            Move(current);
        }
    }
    private void DrawBoard()
    {
        Console.Clear();
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[1], Pos[2], Pos[3]);
        Console.WriteLine("-------------------");
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[4], Pos[5], Pos[6]);
        Console.WriteLine("-------------------");
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[7], Pos[8], Pos[9]);
    }
    private void Winner(Player current)
    {
        current.Score++;
        Console.WriteLine($"Congrats {current.Name} you won the game");
        Console.WriteLine($"Current Score: {Player1.Name}: {Player1.Score}  {Player2.Name}:{Player2.Score}");
        Console.WriteLine();
    }
    private void Draw()
    {
        Console.WriteLine("Its a draw!");
        Console.WriteLine($"Current Score: {Player1.Name}:{Player1.Score} {Player2.Name}:{Player2.Score}");
        Console.WriteLine();
    }
    private bool CheckMove(int move)
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
    private bool CheckWin()
    {
        if (Pos[1]==Pos[2] && Pos[2]==Pos[3] ||
            Pos[4]==Pos[5] && Pos[5]==Pos[6] ||
            Pos[7]==Pos[8] && Pos[8]==Pos[9] ||
            Pos[1]==Pos[5] && Pos[5]==Pos[9] ||
            Pos[3]==Pos[5] && Pos[5]==Pos[7] ||
            Pos[1]==Pos[4] && Pos[4]==Pos[7] ||
            Pos[2]==Pos[5] && Pos[5]==Pos[8] ||
            Pos[3]==Pos[6] && Pos[6]==Pos[9])
        {
            return true;
        }
        return false;
        
    }
}