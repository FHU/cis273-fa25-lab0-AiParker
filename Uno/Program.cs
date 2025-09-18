namespace Uno
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Card topCard = new Card { Type = CardType.Number, Color = Color.Red, Number = 10 };

            Player player = new Player { Name = "Alice" };
            player.Hand.Add(new Card { Type = CardType.Number, Color = Color.Blue, Number = 10 });
            player.Hand.Add(new Card { Type = CardType.Skip, Color = Color.Blue });
            player.Hand.Add(new Card { Type = CardType.Wild, Color = Color.Wild });

            Console.WriteLine($"Top Card: {topCard}");
            Console.WriteLine($"{player.Name}'s hand:");
            foreach (var c in player.Hand)
                Console.WriteLine($" - {c}");

            Console.WriteLine($"Has playable card? {player.HasPlayableCard(topCard)}");
            Console.WriteLine($"First playable card: {player.GetFirstPlayableCard(topCard)}");
            Console.WriteLine($"Most common color: {player.MostCommonColor()}");
        }
    }
}

