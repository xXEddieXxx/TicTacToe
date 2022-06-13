namespace TicTacToe;

public class Game
{
    private int _counter;
    private readonly Player _player1, _player2;
    private readonly string[] _pos = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
    private readonly List<int> _taken = new();

    public Game(Player player1, Player player2)
    {
        _player1 = player1;
        _player2 = player2;
        Turn();
    }

    private void Turn()
    {
        while (CheckWin() == false)
        {
            if (_counter > 7)
            {
                Draw();
                break;
            }

            if (CheckWin() == false)
            {
                Move(_player1);
                if (CheckWin() == false)
                {
                    DrawBoard();
                    Move(_player2);
                }
                else if (CheckWin())
                {
                    DrawBoard();
                    Winner(_player1);
                }
            }

            if (CheckWin())
            {
                DrawBoard();
                Winner(_player2);
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
                _taken.Add(Convert.ToInt32(move));
                _pos[move] = current.Symbol;
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
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", _pos[1], _pos[2], _pos[3]);
        Console.WriteLine("-------------------");
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", _pos[4], _pos[5], _pos[6]);
        Console.WriteLine("-------------------");
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", _pos[7], _pos[8], _pos[9]);
    }

    private void Winner(Player current)
    {
        current.Score++;
        Console.WriteLine($"Congrats {current.Name} you won the game");
        Console.WriteLine($"Current Score: {_player1.Name}: {_player1.Score}  {_player2.Name}:{_player2.Score}");
        Console.WriteLine();
    }

    private void Draw()
    {
        Console.WriteLine("Its a draw!");
        Console.WriteLine($"Current Score: {_player1.Name}:{_player1.Score} {_player2.Name}:{_player2.Score}");
        Console.WriteLine();
    }

    private bool CheckMove(int move)
    {
        foreach (var i in _taken)
            if (move == i)
                return false;

        if (move > 9) return false;
        return true;
    }

    private bool CheckWin()
    {
        return (_pos[1] == _pos[2] && _pos[2] == _pos[3]) ||
               (_pos[4] == _pos[5] && _pos[5] == _pos[6]) ||
               (_pos[7] == _pos[8] && _pos[8] == _pos[9]) ||
               (_pos[1] == _pos[5] && _pos[5] == _pos[9]) ||
               (_pos[3] == _pos[5] && _pos[5] == _pos[7]) ||
               (_pos[1] == _pos[4] && _pos[4] == _pos[7]) ||
               (_pos[2] == _pos[5] && _pos[5] == _pos[8]) ||
               (_pos[3] == _pos[6] && _pos[6] == _pos[9]);
    }
}