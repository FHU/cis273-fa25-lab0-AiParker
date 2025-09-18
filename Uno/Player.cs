namespace Uno
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; } = new List<Card>();

        public bool HasPlayableCard(Card card)
        {
            return Hand.Any(c => Card.PlaysOn(c, card));
        }

        public Card GetFirstPlayableCard(Card card)
        {
            return Hand.FirstOrDefault(c => Card.PlaysOn(c, card));
        }

        public Color MostCommonColor()
        {
            var counts = new Dictionary<Color, int>
            {
                { Color.Red, 0 },
                { Color.Yellow, 0 },
                { Color.Blue, 0 },
                { Color.Green, 0 }
            };

            foreach (var c in Hand.Where(c => c.Color != Color.Wild))
            {
                counts[c.Color]++;
            }

            if (counts.Values.All(v => v == 0))
                return Color.Wild;

            return counts
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key switch
                {
                    Color.Red => 0,
                    Color.Yellow => 1,
                    Color.Blue => 2,
                    Color.Green => 3,
                    _ => 4
                })
                .First().Key;
        }
    }
}
