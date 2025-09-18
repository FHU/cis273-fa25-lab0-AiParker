using System;

namespace Prayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var author = new Author { FirstName = "John", LastName = "Doe", Email = "john@example.com" };
            var scripture = new Scripture { Book = "John", Chapter = 3, StartVerse = 16 };
            var tag = new Tag { Name = "Faith", Color = "Blue", Icon = "✝" };

            var prayer = new Prayer
            {
                Title = "Morning Prayer",
                Subtitle = "A short prayer for strength",
                Body = "Dear Lord, grant me the strength and guidance for today.",
                Author = author,
                ImageURL = new Uri("https://example.com/image.jpg")
            };

            prayer.ScriptureReferences.Add(scripture);
            prayer.Tags.Add(tag);

            Console.WriteLine(prayer);
        }
    }
}

