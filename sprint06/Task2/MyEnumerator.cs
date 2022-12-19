using System.Collections;

namespace Task2
{
    public sealed class MyEnumerator : IEnumerator<Book>
    {
        readonly List<Book> _books;
        Predicate<Book> _filter { get; set; }
        int position = -1;
        public MyEnumerator(IEnumerable<Book> books, Predicate<Book> filter)
        {
            _books = books.ToList();
            _filter = filter;
        }
        public Book Current
        {
            get
            {
                if (position < 0 && position > _books.Count)
                    throw new InvalidOperationException();

                return _books[position];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                if (position < 0 && position > _books.Count)
                    throw new InvalidOperationException();

                return _books[position];
            }
        }
        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            while (position < _books.Count)
            {
                position++;
                if (position < _books.Count && _filter(_books[position]))
                {
                    return true;
                }
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}