﻿namespace Uno;

public class Program
{
    public static void Main(string[] args)
    {
        Card card = new Card();
        card.Type = CardType.Number;
        card.Color = Color.Red;
        card.Number = 3;

        Console.WriteLine(card.ToString() );
    }
}
