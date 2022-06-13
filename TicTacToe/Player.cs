namespace TicTacToe;

public class Player
{
    public Player(string? name, string symbol)
    {
        Name = name;
        Symbol = symbol;
    }

    public string? Name { get; set; }
    public int Score { get; set; }
    public string Symbol { get; set; }
    
}