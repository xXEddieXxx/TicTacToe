﻿namespace TicTacToe;

public class Player
{
    public Player(string? name)
    {
        Name = name;
    }

    public string? Name { get; set; }
    public int Score { get; set; }
    
}