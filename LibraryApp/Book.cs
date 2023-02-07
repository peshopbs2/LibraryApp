using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Book
    {
        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyCollection<string> Authors { get; private set; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors.ToList();
        }

        public override string ToString()
        {
            return $"{Title} - {Year} by {string.Join(" ", Authors)}";
        }
    }
}
