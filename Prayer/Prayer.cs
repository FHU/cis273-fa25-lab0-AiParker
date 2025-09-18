using System;
using System.Collections.Generic;

namespace Prayer
{
    public class Prayer
    {
        public string Title { get; set; } = "";
        public string Subtitle { get; set; } = "";
        public string Body { get; set; } = "";
        public List<Scripture> ScriptureReferences { get; set; } = new List<Scripture>();
        public Author Author { get; set; } = new Author();
        public List<Tag> Tags { get; set; } = new List<Tag>();
        public Uri ImageURL { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"{Title} - {Subtitle} by {Author.FirstName} {Author.LastName}";
        }
    }
}
