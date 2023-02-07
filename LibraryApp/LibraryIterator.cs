using System.Collections;

namespace LibraryApp
{
    internal class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currentIndex;
        public LibraryIterator(List<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public Book Current
        {
            get { return this.books[currentIndex];  }
        }

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            return ++currentIndex < this.books.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}