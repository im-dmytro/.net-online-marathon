namespace Task2
{
    class MyUtils
    {
        public static List<Book> GetFiltered(IEnumerable<Book> books, Predicate<Book> filter)
        {
            Library library = new Library(books) { Filter=filter};
            return library.ToList();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            var filterd=MyUtils.GetFiltered(new List<Book>() { new Book("First","Anderson",444),
                new Book("Second","Anderson2",12),
                new Book("Third","A21nderson",43),
            }, x=>x.Title == "First"||x.Title=="Third");
            foreach (var item in filterd)
            {
                Console.WriteLine(item.Title);
            }

        }
    }
}