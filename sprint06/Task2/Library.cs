using System.Collections;

namespace Task2
{
    public class Library : IEnumerable<Book>
    {
        List<Book> _books;
        public IEnumerable<Book> Books { get => _books; }
        public Predicate<Book> Filter { get; set; } = x => x is Book;
        public Library(IEnumerable<Book> books)
        {
            _books = (List<Book>)books;
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new MyEnumerator(_books, Filter);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyEnumerator(_books, Filter);
        }
    }
}