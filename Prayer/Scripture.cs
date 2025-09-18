namespace Prayer
{
    public class Scripture
    {
        public string Book { get; set; } = "";
        public int Chapter { get; set; }
        public int StartVerse { get; set; }
        public int EndVerse { get; set; }

        public override string ToString()
        {
            return EndVerse > StartVerse
                ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}"
                : $"{Book} {Chapter}:{StartVerse}";
        }
    }
}
