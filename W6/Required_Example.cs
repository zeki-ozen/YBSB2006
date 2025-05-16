using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6_OOP
{
    public class Article
    {
        public required string Title { get; init; }
        public string? Subtitle { get; init; }
        public required string Author { get; init; }
        public required DateTime Published { get; init; }

        public override string ToString() =>
            Subtitle is null
                ? $"{Title} by {Author} ({Published:d})"
                : $"{Title}: {Subtitle} by {Author} ({Published:d})";
    }

}

